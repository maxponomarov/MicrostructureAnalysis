using System.Collections.Generic;

namespace MetalographicsProject.Controllers {
    class MeasureController {
        private static readonly List<Measure.Measure> Measures = new List<Measure.Measure>();
        public static Measure.Measure SelectedMeasure { get; private set; }

        public static void SelectMeasure(Measure.Measure measure) {
            SelectedMeasure = measure;
        }

        public static void ResetMeasure() {
            SelectedMeasure = null;
        }

        public static Measure.Measure[] GetMeasures() {
            return Measures.ToArray();
        }

        public static Measure.Measure GetMeasure(string guid) {
            foreach (Measure.Measure measure in Measures) {
                if (measure.Guid.ToString() == guid)
                    return measure;
            }
            return null;
        }

        public static Measure.Measure AddMeasure(Measure.Measure measure) {
            Measures.Add(measure);
            return measure;
        }

        public static void RemoveMeasure(Measure.Measure measure) {
            Measures.Remove(measure);
        }

        public static void RemoveMeasure(int ID) {
            Measures.RemoveAt(ID);
        }


    }
}
