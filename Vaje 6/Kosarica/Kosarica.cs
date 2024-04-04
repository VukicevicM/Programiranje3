using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kosarica
{
    internal class Kosarica
    {
        static void Main(string[] args)
        {
        }
    }

    public class Kosarica<T>
    {
        private T objekt;

        public Kosarica(T objekt)
        {
            this.objekt = objekt;
        }

        public T Vsebina
        {
            get
            {
                return objekt;
            }
            set
            {
                objekt = value;
            }
        }
        public override string ToString()
        {
            return objekt.ToString();
        }
    }
}

