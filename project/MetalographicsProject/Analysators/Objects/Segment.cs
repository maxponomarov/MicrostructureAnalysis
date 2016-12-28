using System.Collections.Generic;
using System.Drawing;

namespace MetalographicsProject.Analysators.Objects {
    class Segment {
        public List<Point> Pixels { get; }
        public List<Point> Border { get; }
        
        public int Perimeter { get; }  
    }
}
