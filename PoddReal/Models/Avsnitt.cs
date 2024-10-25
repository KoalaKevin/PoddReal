using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Avsnitt
    {
        public String Namn { get; set; }
        public String Beskrivning { get; set; }
        public Avsnitt(string namn, string beskrivning)
        {
            Namn = namn;
            Beskrivning = beskrivning;
        }
        public Avsnitt() { }   
    }
}
