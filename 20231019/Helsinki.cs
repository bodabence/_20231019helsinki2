using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20231019
{
    internal class Helsinki
    {
        public int Helyezes { get; set; }
        public int sportolokSzama { get; set; }
        public string sportagNeve { get; set; }
        public string versenySzamNeve { get; set; }


        public Helsinki(string s) {
            var v = s.Split(' ');
            this.Helyezes = int.Parse(v[0]);
            this.sportolokSzama = int.Parse(v[1]);
            this.sportagNeve = v[2];
            this.versenySzamNeve = v[3];
        
        }
        

    }
}
