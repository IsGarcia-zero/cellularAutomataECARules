using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regla30.Objetos
{
    public class Celulas
    {
        private int regla;
        private int t;
        private Color celula;
        private Color fondo;
        private float porcentajeRandom;
        private String cadena;
        private Int64 numeroMayor;
        private int tamCadena;
        public int Regla
        {
            get { return regla; }
            set { regla = value; }
        }
        
        public int T {
            get { return t; }
            set { t = value; }
        }
        
        public Color Celula {
            get { return celula; }
            set { celula = value; }
        }

        public Color Fondo {
            get { return fondo; }
            set { fondo = value; }
        }

        public float PorcentajeRandom
        {
            get { return porcentajeRandom; }
            set { porcentajeRandom = value; }
        }

        public String Cadena
        {
            get { return cadena; }
            set { cadena = value; }
        }
        public Int64 NumeroMayor
        {
            get { return numeroMayor; }
            set { numeroMayor = value; }
        }
        public int TamCadena {
            get { return tamCadena; }
            set { tamCadena = value; }
        }
    }
}

