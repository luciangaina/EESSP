using System;
using System.Collections.Generic;
using System.Text;

namespace EESSP.Models
{
    public class Consultatie
    {
        public int Id { get; set; }
        public string CnpPacient { get; set; }
        public DateTime DataConsultatie { get; set; }
        public string CodDiagnostic { get; set; }
        public string Medicatie { get; set; }
        public string Recoamndari { get; set; }
        public bool EsteSters { get; set; }
    }
}
