using Regla30.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regla30.Utilidades
{
    public class CalculoGrafs
    {
        Intermedios inter;
        Objetos.Celulas cel;
        public CalculoGrafs(Intermedios inter, Celulas cel)
        {
            this.inter = inter;
            this.cel = cel;
        }
        public Int64 densidad1s(String cadena) {
            Int64 densidadUnos = 0;
           
            foreach (char item1 in cadena)
            {
                if (item1 == '1')
                {
                    densidadUnos++;
                }
            }
            return densidadUnos;
        }
        public Double densidad1sLog(Int64 den) {
            Double elPRI = 0;
            elPRI = Math.Log(Convert.ToDouble(den), 10);
            return elPRI;
        }
        public Double entriopiaShanon(String cadena) {
            Int64[] frecuencias = new Int64[2];
            frecuencias[0] = 0;
            frecuencias[1] = 0;
            foreach (char item1 in cadena)
            {
                if (item1 == '1')
                {
                    frecuencias[0]++;
                }
                else {
                    frecuencias[1]++;
                }
            }
            Double entriopia = 0;
            foreach (Int64 item in frecuencias)
            {
                Double p = (double)item / cadena.Length;
                if (p > 0)
                {
                    entriopia -= p * Math.Log(p) / Math.Log(2);
                }
            }
            return entriopia;
        }
    }
}
