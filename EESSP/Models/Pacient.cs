using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EESSP.Models
{
    public class Pacient
    {
        public int Id { get; set; }
        public string CNP { get; set; }
        public string NrFisa { get; set; }
        public string Gen { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public DateTime DataNastere { get; set; }
        public int Varsta { get; set; }
        public bool Asigurare { get; set; }
        public string Telefon { get; set; }
        public string Localitate { get; set; }
        public string Judet { get; set; }
        public string Strada { get; set; }
        public string Numar { get; set; }
        public string Bloc { get; set; }
        public string Scara { get; set; }
        public string Apartament { get; set; }
        public string GrupaSg { get; set; }
        public string Rh { get; set; }
        public float Greutate { get; set; }
        public int Inaltime { get; set; }
        public DateTime DataDeces { get; set; }
        public bool EstePacient { get; set; }
    }
}
