using System;
using System.Drawing;
using MetalographicsProject.Analysators;
using MetalographicsProject.Filters;
using System.Collections.Generic;
using System.Linq;

namespace MetalographicsProject.Model {
    public enum NodeType {
        Image,
        Filter,
        Detector
    }

    public class Node : IImageGenerator {
        public Guid GUID = Guid.NewGuid();
        public List<Node> InputNodes;
        public Bitmap Input { get; private set; }
        public Bitmap Output { get; private set; }
        public AbstractFilter Filter { get; private set; }
        public AbstractDetector Detector { get; private set; }
        public NodeType NodeType;

        //For initing first Node
        public Node(Bitmap input, AbstractFilter filter) {
            Input = input;
            Filter = filter;
            NodeType = NodeType.Image;
            Process();
        }

        //For creating child nodes from other nodes
        public Node(List<Node> input, AbstractFilter filter) {
            InputNodes = input;
            Filter = filter;
            NodeType = NodeType.Filter;
            Process();
        }

        //For chreating child nodes from other nodes
        public Node(List<Node> input, AbstractDetector detector) {
            InputNodes = input;
            Detector = detector;
            NodeType = NodeType.Detector;
            Process();
        }

        //Generate node output
        public void Process() {
            switch (NodeType) {
                case NodeType.Filter:
                    Output = Filter.ApplyFilter(InputNodes.Select(node => node.Output).ToList());
                    break;
                case NodeType.Detector:
                    Output = Detector.GetResultBitmap();
                    break;
                case NodeType.Image:
                    Output = Input;
                    break;
            }
        }
        
        public void SetInput(Bitmap bitmap) {
            Input = bitmap;
        }

        public void SetInput(List<Node> nodes) {
            InputNodes = nodes;
        }

        public void SetFilter(AbstractFilter filter) {
            Filter = filter;
        }

        public void SetDetector(AbstractDetector detector) {
            Detector = detector;
        }

        public Bitmap GetResultBitmap() {
            Process();
            return Output;
        }
    }
    
}
