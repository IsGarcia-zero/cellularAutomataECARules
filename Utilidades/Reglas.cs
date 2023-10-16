using Regla30.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regla30.Utilidades
{
    public class Reglas
    {
        Intermedios inter;
        Objetos.Celulas cel;
        TodasReglas todasrrr = new();
        public Reglas(Celulas cel, Intermedios inter) { 
            this.cel = cel;
            this.inter = inter;
        }
        public void conversion(int irl, double jrl) {
            String reglaConvertida = Convert.ToString(cel.Regla, 2).Trim();
            int mayo = 0;
            switch (cel.NumeroMayor) {
                case 255:
                    mayo = 8;
                    break;
                case 511:
                    mayo = 9;
                    break;
                case 1023:
                    mayo = 10;
                    break;
                case 2047:
                    mayo = 11;
                    break;
                case 4095:
                    mayo = 12;
                    break;
                case 8191:
                    mayo = 13;
                    break;
                case 16383:
                    mayo = 14;
                    break;
                case 32767:
                    mayo = 15;
                    break;
                case 65535:
                    mayo = 16;
                    break;
                case 131071:
                    mayo = 17;
                    break;
                case 262143:
                    mayo = 18;
                    break;
                case 524287:
                    mayo = 19;
                    break;
                case 1048575:
                    mayo = 20;
                    break;
                case 2097151:
                    mayo = 21;
                    break;
                case 4194303:
                    mayo = 22;
                    break;
                case 8388607:
                    mayo = 23;
                    break;
                case 16777215:
                    mayo = 24;
                    break;
                case 33554431:
                    mayo = 25;
                    break;
                case 67108863:
                    mayo = 26;
                    break;
                case 134217727:
                    mayo = 27;
                    break;
                case 268435455:
                    mayo = 28;
                    break;
                case 536870911:
                    mayo = 29;
                    break;
                case 1073741823:
                    mayo = 30;
                    break;
                case 2147483647:
                    mayo = 31;
                    break;
                case 4294967295:
                    mayo = 32;
                    break;
                case 8589934591:
                    mayo = 33;
                    break;
                case 17179869183:
                    mayo = 34;
                    break;
                case 34359738367:
                    mayo = 35;
                    break;
                case 68719476735:
                    mayo = 36;
                    break;
                case 137438953471:
                    mayo = 37;
                    break;
                case 274877906943:
                    mayo = 38;
                    break;
                case 549755813887:
                    mayo = 39;
                    break;
                default:
                    mayo = 8;
                    break;
            }
            if (reglaConvertida.Length < mayo) {
                int faltantes = mayo - reglaConvertida.Length;
                for (int i = 0; i < faltantes; i++)
                {
                    reglaConvertida = "0" + reglaConvertida;
                }
            }
            Boolean[] componentes = new Boolean[reglaConvertida.Length];
            char[] reverso = new char[reglaConvertida.Length];
            reverso = reglaConvertida.ToCharArray();
            Array.Reverse(reverso);
            for (int i = 0; i < reglaConvertida.Length; i++)
            {
                if (reverso[i] == '1')
                {
                    componentes[i] = true;
                }
                else
                {
                    componentes[i] = false;
                }
            }
            inter.ReglaComponentes = componentes;
            inter.CadenasReales = conjuntoResultados();
            StringBuilder otroSting = new();
            foreach (String s in inter.CadenasReales) {
                otroSting.AppendLine(s);
            }
            todasrrr.crearArchivos(2, otroSting.ToString(), irl, jrl);
            if ((irl == 255&&jrl == 95) || cel.T > 5000 || cel.TamCadena> 5000)
            {
                Console.Beep(100, 5000);
            }
        }
        private String[] conjuntoResultados() {
            String[] final = new String[cel.T + 1];
            final[0] = cel.Cadena;
            String[] aux = new String[cel.T + 1];
            for (int i = 0; i < cel.T; i++)  
            { 
                aux[i] = final[i];
                char[] cadenaMala = new char[cel.Cadena.Length];
                cadenaMala = aux[i].ToCharArray();
                StringBuilder aux2 = new();
                for (int j = 0; j < cadenaMala.Length; j++) 
                {
                    var sd = new StringBuilder();
                    if (j == 0)
                    {

                        sd.Append((cadenaMala[cadenaMala.Length - 1]).ToString());
                        sd.Append(cadenaMala[j].ToString());
                        sd.Append(cadenaMala[j + 1].ToString());

                        aux2.Append(union(sd.ToString()));
                    }
                    else if (j == cadenaMala.Length - 1)
                    {
                        sd.Append(cadenaMala[j - 1].ToString());
                        sd.Append(cadenaMala[j].ToString());
                        sd.Append(cadenaMala[0].ToString());
                        
                        aux2.Append(union(sd.ToString()));
                    }
                    else 
                    {
                        sd.Append(cadenaMala[j - 1].ToString());
                        sd.Append(cadenaMala[j].ToString());
                        sd.Append(cadenaMala[j + 1].ToString());
                        
                        aux2.Append(union(sd.ToString()));
                    }
                }
                final[i + 1] = aux2.ToString();
            }
            
            return final;
        }
        private String union(String sd2) {
            
            int conv = Convert.ToInt32(sd2, 2);
            if (inter.ReglaComponentes[conv]) {
                return "1";
            }
            else { 
                return "0";
            }
        }
        public List<List<AtractorInfo>> ObtenerAtractoresEnTodasLasGeneraciones(int irl, double jrl)
        {
            conversion(irl, jrl);

            List<List<AtractorInfo>> atractoresPorGeneracion = new List<List<AtractorInfo>>();

            // Buscar atractores en cada generación
            for (int i = 0; i < inter.CadenasReales.Length; i++)
            {
                List<AtractorInfo> atractores = BuscarAtractores(inter.CadenasReales[i]);
                atractoresPorGeneracion.Add(atractores);
            }

            return atractoresPorGeneracion;
        }
        private List<AtractorInfo> BuscarAtractores(string cadena)
        {
            List<AtractorInfo> atractores = new List<AtractorInfo>();
            Dictionary<string, int> frecuencia = new Dictionary<string, int>();

            for (int i = 0; i < cadena.Length; i++)
            {
                for (int j = i + 1; j <= cadena.Length; j++)
                {
                    string subcadena = cadena.Substring(i, j - i);
                    if (frecuencia.ContainsKey(subcadena))
                    {
                        int inicio = frecuencia[subcadena];
                        int longitud = i - inicio;
                        atractores.Add(new AtractorInfo { Inicio = inicio, Longitud = longitud, Atractor = subcadena });
                    }
                    else
                    {
                        frecuencia[subcadena] = i;
                    }
                }
            }

            return atractores;
        }

    }
}
