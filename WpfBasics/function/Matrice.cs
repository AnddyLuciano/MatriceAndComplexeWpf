using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfBasics.function
{
    class Matrice
    {
        private int[,] _contenu;

        public Matrice(int lignes, int colonnes)   //constructeur
        {
            this._contenu = new int[lignes, colonnes];
        }

        public int this[int ligne, int colonne]    //propriété
        {
            get
            {
                return _contenu[ligne, colonne];
            }
            set
            {
                _contenu[ligne, colonne] = value;
            }
        }

        public override string ToString()
        {
            return string.Format("[{0} {1}]\n[{2} {3}]", this[0, 1], this[0, 1]);
        }
    }
}
