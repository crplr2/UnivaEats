using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnivaEats.Clases
{
    class Analiza
    { 
        public int Caracteres(string Texto)
        {
            char[] caracteres = new char[] { '`', '~', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '_', '=', '+', '{', '}', '[', ']', '"', '<', '>', '?', '/' };
            var cuentacaracteres = 0;
            for (int i = 0; i < Texto.Length; i++)
            {
                var actual = Texto[i];
                for (int c = 0; c < caracteres.Length; c++)
                {
                    if (actual == caracteres[c])
                        cuentacaracteres++;
                }
            }
            return cuentacaracteres;
        }
        public int Letras(string mensaje)
        {
            char[] letras = new char[] { ' ','a', 'A', 'b','B', 'C', 'c', 'd', 'D', 'E', 'e', 'F', 'f', 'G', 'g', 'H', 'h', 'I', 'i', 'J', 'j', 'K', 'k', 'L', 'l',
                'N', 'n','M', 'm', 'O', 'o', 'P', 'p', 'Q', 'q', 'R', 'r', 'S', 's', 'T', 't', 'U', 'u', 'V', 'v', 'W', 'w', 'X', 'x', 'Y', 'y', 'Z', 'z' };
            var cuenta = 0;
            for (int i = 0; i < mensaje.Length; i++)
            {
                var actual = mensaje[i];
                for (int c = 0; c < letras.Length; c++)
                {
                    if (actual == letras[c])
                        cuenta++;
                }
            }
            return cuenta;
        }
    }
}
