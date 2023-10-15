using Regla30.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regla30.Utilidades
{
    public class Atractores
    {
        Intermedios inte;
        Objetos.Celulas cel;

        public Atractores(Intermedios inte, Celulas cel)
        {
            this.inte = inte ?? throw new ArgumentNullException(nameof(inte));
            this.cel = cel ?? throw new ArgumentNullException(nameof(cel));
        }
        public void atractores()
        {
            String[] cadenas = inte.CadenasReales;
            for (int i = 1; i < inte.CadenasReales.Length; i++)
            {
                
            }
            inte.CadenasReales = cadenas;
        }
    }
}
