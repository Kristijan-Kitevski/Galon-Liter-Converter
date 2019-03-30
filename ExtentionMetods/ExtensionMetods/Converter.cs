using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMetods
{
    public static class Converter
    {
        public static double GalonToLiter( string G)
        {
            double Galon = double.Parse( G);
            double Liter = Galon * 3.185;
            return Liter;
        }

        public static double LiterToGalion(string L)
        {
            double Liter = double.Parse(L);
            double Galon = Liter / 3.185;
            return Galon;
        }
    }
}
