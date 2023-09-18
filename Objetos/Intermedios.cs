using System;

namespace Regla30.Objetos
{
    public class Intermedios
    {
        private Boolean[] reglaComponentes;
        private String[] cadenasReales;

        public Boolean[] ReglaComponentes
        {
            get { return reglaComponentes; }
            set { reglaComponentes = value; }
        }

        public String[] CadenasReales
        {
            get { return cadenasReales; }
            set { cadenasReales = value; }
        }
    }
}
