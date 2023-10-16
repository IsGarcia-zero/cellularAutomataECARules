using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Regla30.Utilidades
{
    public class TodasReglas
    {
        public void crearRutas(int n) {
            string path1 = "C:\\Users\\Iljim\\Desktop\\AutomatasCelularesInfo\\Normal\\Configuraciones";
            string path2 = "C:\\Users\\Iljim\\Desktop\\AutomatasCelularesInfo\\Normal\\Valores";
            string path3 = "C:\\Users\\Iljim\\Desktop\\AutomatasCelularesInfo\\Normal\\Imagenes";
            string path4 = "C:\\Users\\Iljim\\Desktop\\AutomatasCelularesInfo\\Normal\\Grafics";
            string path5 = "C:\\Users\\Iljim\\Desktop\\AutomatasCelularesInfo\\Normal\\CSVs";
            for (int i = 0; i < 256; i++)
            {
                StringBuilder pathPro = new();
                switch (n) {
                    case 1:
                        pathPro.Append(path1 + "\\" + i);
                        break;
                    case 2:
                        pathPro.Append(path2 + "\\" + i);
                        break;
                    case 3:
                        pathPro.Append(path3 + "\\" + i);
                        break;
                    case 4:
                        pathPro.Append(path4 + "\\" + i);
                        break;
                    case 5:
                        pathPro.Append(path5 + "\\" + i);
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                }

                try
                {
                    // Determine whether the directory exists.
                    if (Directory.Exists(pathPro.ToString()))
                    {
                        Console.WriteLine("That path exists already.");
                        return;
                    }

                    // Try to create the directory.
                    DirectoryInfo di = Directory.CreateDirectory(pathPro.ToString());
                    Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(pathPro.ToString()));


                }
                catch (Exception ex)
                {
                    Console.WriteLine("The process failed: {0}", ex.ToString());
                }
                finally { }
            }
        }


        public void borrarRutas(int n) {
            string path1 = "C:\\Users\\Iljim\\Desktop\\AutomatasCelularesInfo\\Normal\\Configuraciones";
            string path2 = "C:\\Users\\Iljim\\Desktop\\AutomatasCelularesInfo\\Normal\\Valores";
            string path3 = "C:\\Users\\Iljim\\Desktop\\AutomatasCelularesInfo\\Normal\\Imagenes";
            string path4 = "C:\\Users\\Iljim\\Desktop\\AutomatasCelularesInfo\\Normal\\Grafics";
            string path5 = "C:\\Users\\Iljim\\Desktop\\AutomatasCelularesInfo\\Normal\\CSVs";
            for (int i = 0; i < 256; i++)
            {
                StringBuilder pathPro = new();
                switch (n)
                {
                    case 1:
                        pathPro.Append(path1 + "\\" + i);
                        break;
                    case 2:
                        pathPro.Append(path2 + "\\" + i);
                        break;
                    case 3:
                        pathPro.Append(path3 + "\\" + i);
                        break;
                    case 4:
                        pathPro.Append(path4 + "\\" + i);
                        break;
                    case 5:
                        pathPro.Append(path5 + "\\" + i);
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                }

                try
                {
                    // Determine whether the directory exists.
                    if (!Directory.Exists(pathPro.ToString()))
                    {
                        Console.WriteLine("That path exists already.");
                        return;

                    }
                    // Try to create the directory.
                    DirectoryInfo di = Directory.CreateDirectory(pathPro.ToString());
                    FileInfo[] files = di.GetFiles();
                    foreach (FileInfo file in files)
                    {
                        file.Delete();
                    }
                    di.Delete();
                    DirectoryInfo[] subDirectories = di.GetDirectories();
                    foreach (DirectoryInfo subDirectory in subDirectories)
                    {
                        subDirectory.Delete(true);
                    }
                    Console.WriteLine("The directory was deleted successfully.");


                }
                catch (Exception ex)
                {
                    Console.WriteLine("The process failed: {0}", ex.ToString());
                }
                finally { }
            }
        }

        public void crearArchivos(int n, string json, int i, double j) {
            string path1 = "C:\\Users\\Iljim\\Desktop\\AutomatasCelularesInfo\\Normal\\Configuraciones";
            string path2 = "C:\\Users\\Iljim\\Desktop\\AutomatasCelularesInfo\\Normal\\Valores";
            string path3 = "C:\\Users\\Iljim\\Desktop\\AutomatasCelularesInfo\\Normal\\Imagenes";
            string path4 = "C:\\Users\\Iljim\\Desktop\\AutomatasCelularesInfo\\Normal\\Grafics";
            string path5 = "C:\\Users\\Iljim\\Desktop\\AutomatasCelularesInfo\\Normal\\CSVs";
            StringBuilder pathPro = new();
            switch (n)
            {
                case 1:
                    pathPro.Append(path1 + "\\" + i + "\\Archivo" + j + "pp.json");
                    break;
                case 2:
                    pathPro.Append(path2 + "\\" + i + "\\Archivo" + j + "pp.txt");
                    break;
                case 3:
                    pathPro.Append(path3 + "\\" + i + "\\Archivo" + j + "pp.png");
                    break;
                case 4:
                    pathPro.Append(path4 + "\\" + i + "\\Archivo" + j + "pp.png");
                    break;
                case 5:
                    pathPro.Append(path5 + "\\" + i + "\\Archivo" + j + "pp.csv");
                    break;
                case 6:
                    break;
                case 7:
                    break;
            }

            try
            {
                // Determine whether the directory exists.
                if (File.Exists(pathPro.ToString()))
                {
                    Console.WriteLine("That path exists already.");
                    return;

                }
                // Try to create the directory.
                File.WriteAllText(pathPro.ToString(), json);
                Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(pathPro.ToString()));


            }
            catch (Exception ex)
            {
                Console.WriteLine("The process failed: {0}", ex.ToString());
            }
            finally { }

        }
        public StringBuilder generarL() {
            string path1 = "C:\\Users\\Iljim\\Desktop\\AutomatasCelularesInfo\\Normal\\Configuraciones";
            string path2 = "C:\\Users\\Iljim\\Desktop\\AutomatasCelularesInfo\\Normal\\Valores";
            string path3 = "C:/Users/Iljim/Desktop/AutomatasCelularesInfo/Normal/Imagenes";
            string path4 = "C:/Users/Iljim/Desktop/AutomatasCelularesInfo/Normal/Grafics";
            string path5 = "C:\\Users\\Iljim\\Desktop\\AutomatasCelularesInfo\\Normal\\CSVs";
            StringBuilder strr = new();
            double gg = 0;
            strr.AppendLine("\\section{Anexo}");
            strr.AppendLine("\\subsection{Archivos de Configuracion}");
            for (int i = 0; i < 4; i++)
            {
                switch (i)
                {
                    case 0:
                        gg = 2;
                        break;
                    case 1:
                        gg = 50;
                        break;
                    case 2:
                        gg = 75;
                        break;
                    case 3:
                        gg = 95;
                        break;
                }
                strr.AppendLine("\\subsubsection{Porcentaje "+i+"}");
                for (int j = 0; j < 256; j++)
                {
                    strr.AppendLine("\\begin{lstlisting}[language=json, caption=Regla "+j+ " porcentaje "+i+", label=r"+j+"pp"+i+"]");
                    strr.AppendLine(leerJsonATxt(j, gg, path1));
                    strr.AppendLine("\\end{lstlisting}");
                }
            }/*
            strr.AppendLine("\\subsection{Valores}");
            for (int i = 0; i < 4; i++)
            {
                switch (i)
                {
                    case 0:
                        gg = 2;
                        break;
                    case 1:
                        gg = 50;
                        break;
                    case 2:
                        gg = 75;
                        break;
                    case 3:
                        gg = 95;
                        break;
                }
                strr.AppendLine("\\subsubsection{Porcentaje " + i + "}");
                for (int j = 0; j < 256; j++)
                {
                    strr.AppendLine("\\begin{lstlisting}[language=json, caption=Regla " + j + " porcentaje " + i + ", label=r" + j + "pp" + i + "]");
                    strr.AppendLine(leerArchivoTxt(j, gg, path2));
                    strr.AppendLine("\\end{lstlisting}");
                }
            }
            strr.AppendLine("\\subsection{CSVs}");
            for (int i = 0; i < 4; i++)
            {
                switch (i)
                {
                    case 0:
                        gg = 2;
                        break;
                    case 1:
                        gg = 50;
                        break;
                    case 2:
                        gg = 75;
                        break;
                    case 3:
                        gg = 95;
                        break;
                }
                strr.AppendLine("\\subsubsection{Porcentaje " + i + "}");
                for (int j = 0; j < 256; j++)
                {
                    strr.AppendLine("\\begin{lstlisting}[language=json, caption=Regla " + j + " porcentaje " + i + ", label=r" + j + "pp" + i + "]");
                    strr.AppendLine(leerArchivoCsv(j, gg, path5));
                    strr.AppendLine("\\end{lstlisting}");
                }
            }*/
            strr.AppendLine("\\subsection{Imagenes}");
            for (int i = 0; i < 4; i++)
            {
                switch (i)
                {
                    case 0:
                        gg = 2;
                        break;
                    case 1:
                        gg = 50;
                        break;
                    case 2:
                        gg = 75;
                        break;
                    case 3:
                        gg = 95;
                        break;
                }
                strr.AppendLine("\\subsubsection{Porcentaje " + i + "}");
                for (int j = 0; j < 256; j++)
                {
                    strr.AppendLine("\\begin{figure}[ht]");
                    strr.AppendLine("\\centering");
                    strr.AppendLine("\\includegraphics[width=\\textwidth]{"+path3+ "/" + j+ "/Archivo" + gg+"pp.png}");
                    strr.AppendLine("\\caption{Imagen de regla "+j+" con porcentaje "+gg+"}");
                    strr.AppendLine("\\end{figure}");
                    strr.AppendLine("\\clearpage");
                }
                strr.AppendLine("\\clearpage");
            }
            strr.AppendLine("\\subsection{Graficos}");
            string sssss = "";
            for (int r = 1; r < 4; r++)
            {
                switch (r)
                {
                    case 1:
                        strr.AppendLine("\\subsubsection{Graficas densidad de Unos}");
                        sssss = "Densidad de Unos";
                        break;
                    case 2:
                        strr.AppendLine("\\subsubsection{Graficas densidad Logaritmica}");
                        sssss = "Densidad Logaritmica";
                        break;
                    case 3:
                        strr.AppendLine("\\subsubsection{Graficas entriopia de Shanon}");
                        sssss = "Entriopia de Shannon";
                        break;
                }
                for (int i = 0; i < 4; i++)
                {
                    switch (i)
                    {
                        case 0:
                            gg = 2;
                            break;
                        case 1:
                            gg = 50;
                            break;
                        case 2:
                            gg = 75;
                            break;
                        case 3:
                            gg = 95;
                            break;
                    }
                    
                    for (int j = 0; j < 256; j++)
                    {
                        strr.AppendLine("\\begin{figure}[ht]");
                        strr.AppendLine("\\centering");
                        strr.AppendLine("\\includegraphics[width=\\textwidth]{" + path4 + "/" + j + "/" + r + "/Graf" + gg+"pp.png}");
                        strr.AppendLine("\\caption{Grafico de "+sssss+" de regla " + j + " con porcentaje " + gg + "}");
                        strr.AppendLine("\\end{figure}");
                        strr.AppendLine("\\clearpage");
                    }
                    strr.AppendLine("\\clearpage");
                }
            }
            return strr;
        }
        public string leerJsonATxt(int irl, double jrl, string path1) {
            try {
                
                // Open the text file using a stream reader.  
                using (StreamReader sr = new StreamReader(path1 + "\\" + irl + "\\Archivo" + jrl + "pp.json"))
                {
                    // Read the stream to a string, and write the string to the console.  
                    String line = sr.ReadToEnd();
                    Console.WriteLine(line);
                    return line;
                }
            }   
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
                return "";
            }
            
        }
        public string leerArchivoTxt(int irl, double jrl, string path2) {
            try
            {
                // Open the text file using a stream reader.  
                using (StreamReader sr = new StreamReader(path2 + "\\" + irl + "\\Archivo" + jrl + "pp.txt"))
                {
                    // Read the stream to a string, and write the string to the console.  
                    String line = sr.ReadToEnd();
                    Console.WriteLine(line);
                    return line;
                }
            }
            catch (Exception ex) {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(ex.Message);
                return "";
            }
            
        }
        public string leerArchivoCsv(int irl, double jrl, string path5)
        {
            try
            {
                // Open the text file using a stream reader.  
                using (StreamReader sr = new StreamReader(path5 + "\\" + irl + "\\Archivo" + jrl + "pp.csv"))
                {
                    // Read the stream to a string, and write the string to the console.  
                    String line = sr.ReadToEnd();
                    Console.WriteLine(line);
                    return line;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(ex.Message);
                return "";
            }

        }
    }
}

