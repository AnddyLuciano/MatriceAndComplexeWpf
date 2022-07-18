using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfBasics.function
{
    class Complexe
    {
        public int Reel { get; set; }
        public int Imaginaire { get; set; }

        public Complexe(int reel, int imaginaire)
        {
            this.Reel = reel;
            this.Imaginaire = imaginaire;
        }

        public override string ToString()
        {
            return $"{Reel} + i{Imaginaire}";
        }
    }
}
