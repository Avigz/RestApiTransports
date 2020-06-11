using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPIinMemorydb.Model
{
    public class TransportTab
    {
        private int _id;
        private string _lastbil;
        private string _chauffor;
        private string _dato;
        private int _antalKm;
        private double _gennemsnit;

        public TransportTab() { }
        public TransportTab(int id, string lastbil, string chauffor,string dato, int antalKm, double gennemsnit)
        {
            Id = id;
            Lastbil = lastbil;
            Chauffor = chauffor;
            Dato = dato;
            AntalKm = antalKm;
            Gennemsnit = gennemsnit;
        }
       
        public int Id { get => _id; set => _id = value; }
        public string Lastbil { get => _lastbil; set => _lastbil = value; }
        public string Chauffor { get => _chauffor; set => _chauffor = value; }
        public string Dato { get => _dato; set => _dato = value; }
        public int AntalKm { get => _antalKm; set => _antalKm = value; }
        public double Gennemsnit { get => _gennemsnit; set => _gennemsnit = value; }
    }
}
