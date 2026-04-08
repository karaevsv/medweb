using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWasmTest.Classes
{
    public class Vital
    {
        public double Glucose {get; set;}
        public int SystolicBP { get; set; }
        public int DiastolicBP { get; set; }
        public int Pulse { get; set; }
        public double Weight { get; set; }
        public string Comment { get; set; }

        User user { get; set; }
    }
}