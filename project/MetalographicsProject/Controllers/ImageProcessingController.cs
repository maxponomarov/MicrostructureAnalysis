using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using MetalographicsProject.Analysators;
using MetalographicsProject.Filters;
using MetalographicsProject.Model;

namespace MetalographicsProject.Controllers {
    class ImageProcessingController {
        private readonly List<Node> Nodes;
        private static ImageProcessingController instance;
        public static ImageProcessingController Instance => instance;
        public int NodesCount => Nodes.Count;
        
        public ImageProcessingController(Bitmap bitmap) {
            Nodes = new List<Node>();
            EmptyFilter filter = new EmptyFilter();
            Node firstNode = new Node(bitmap, filter);
            Nodes.Add(firstNode);
            instance = this;
        }
        
        //просчитать элементы, начиная с выбранного
        public void RebuildNodes(int startIndex = 1) {
            //если у нас только стартовый нод, его не нужно перестраивать
            if (NodesCount == 0) return;
            if (startIndex == 0) startIndex = 1;

            //для остальных случаев
            for (int i = startIndex; i < Nodes.Count; i++) {
                Nodes[i].Process();
            }
        }

        public List<Bitmap> GetOutputImages() {
            return Nodes.Select(node => node.Output).ToList();
        } 

        public void AddNode(AbstractFilter filter) { Nodes.Add(new Node(new List<Node> {Nodes.Last()}, filter)); }
        public void AddNode(AbstractDetector detector) { Nodes.Add(new Node(new List<Node> { Nodes.Last() }, detector)); }

        public void DeleteNode(int index) {
            //TODO Delete child nodes
            Nodes.RemoveAt(index); 
        }
        public Node GetNode(int index) { return Nodes[index]; }
        public Node GetNode() { return Nodes.Last(); }
        public void UpdateNode(AbstractFilter filter, int index) {
            Nodes[index].SetFilter(filter);
            Nodes[index].Process();
        }
        public void UpdateNode(AbstractDetector detector, int index) {
            Nodes[index].SetDetector(detector);
            Nodes[index].Process();
        }




    }
}
