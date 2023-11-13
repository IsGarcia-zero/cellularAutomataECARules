using Regla30.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Regla30.Datos;

namespace Regla30.Utilidades
{
    public class Reglas
    {
        Intermedios inter;
        Objetos.Celulas cel;
        TodasReglas todasrrr = new();
        DatsAtrct dArAtrct;
        
        public Reglas(Celulas cel, Intermedios inter, DatsAtrct dArAtrct) { 
            this.cel = cel;
            this.inter = inter;
            this.dArAtrct = dArAtrct;
        }
        public void conversion(int irl, double jrl) {
            String reglaConvertida = Convert.ToString(cel.Regla, 2).Trim();
            int mayo = cel.NumeroMayor switch
            {
                255 => 8,
                511 => 9,
                1023 => 10,
                2047 => 11,
                4095 => 12,
                8191 => 13,
                16383 => 14,
                32767 => 15,
                65535 => 16,
                131071 => 17,
                262143 => 18,
                524287 => 19,
                1048575 => 20,
                2097151 => 21,
                4194303 => 22,
                8388607 => 23,
                16777215 => 24,
                33554431 => 25,
                67108863 => 26,
                134217727 => 27,
                268435455 => 28,
                536870911 => 29,
                1073741823 => 30,
                2147483647 => 31,
                4294967295 => 32,
                8589934591 => 33,
                17179869183 => 34,
                34359738367 => 35,
                68719476735 => 36,
                137438953471 => 37,
                274877906943 => 38,
                549755813887 => 39,
                _ => 8
            };
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
            if (jrl == 454213 && irl == 454213)
            {
                dArAtrct.CadenaAtrctList = conjuntoResultados2();
            }
            else
            {
                inter.CadenasReales = conjuntoResultados();
                StringBuilder otroSting = new();
                foreach (String s in inter.CadenasReales)
                {
                    otroSting.AppendLine(s);
                }
                todasrrr.crearArchivos(2, otroSting.ToString(), irl, jrl);
            }
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
        private List<CadenaAtr> conjuntoResultados2()
        {
            List<CadenaAtr> cadenaAtrctList = new();
            Atractores atractores = new(inter, cel);
            List<Universo> uni = atractores.calcularPosibilidades(cel.TamCadena);
            
            List<String> final = new();
            final.Insert(0, cel.Cadena);
            List<String> aux = new();
            int i = 0;
            while (atractores.estaLleno(cel.TamCadena, uni))
            {
                Universo universo = new Universo();
                int f = 0;
                foreach (Universo pepe in uni)
                {
                    if (final[i] == pepe.EstadoActual && pepe.EstaOcupado == false)
                    {
                        uni[f].EstaOcupado = true;
                        break;
                    }
                    if (final[i] == pepe.EstadoActual && pepe.EstaOcupado)
                    {
                        int hg = 0;
                        foreach (Universo coincidencias in uni)
                        {
                            if (!coincidencias.EstaOcupado)
                            {
                                final[i] = coincidencias.EstadoActual;
                                uni[hg].EstaOcupado = true;
                                break;
                            }

                            hg++;
                        }
                        break;
                    }
                    f++;
                }
                aux.Insert(i, final[i]);
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
                
                
                final.Insert(i + 1, aux2.ToString());
                CadenaAtr s = new();
                s.CadenaAnterior = final[i];
                s.CadenaActual = final[i + 1];
                cadenaAtrctList.Add(s);
                i++;
            }

            return cadenaAtrctList;
        }
        private String union(String sd2)
        {
            int conv = Convert.ToInt32(sd2, 2);
            return inter.ReglaComponentes[conv] ? "1" : "0";
        }
        

    }
}
