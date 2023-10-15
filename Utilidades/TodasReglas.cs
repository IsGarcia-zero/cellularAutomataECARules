using System;
using System.Collections.Generic;
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
                        pathPro.Append(path1+"\\"+i);
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
                            pathPro.Append(path1 + "\\" + i+"\\Archivo"+j+"pp.json");
                            break;
                        case 2:
                            pathPro.Append(path2 + "\\" + i + "\\Archivo" + j + "pp.txt");
                            break;
                        case 3:
                            pathPro.Append(path3 + "\\" + i + "\\Archivo" + j + "pp.png");
                            break;
                        case 4:
                            pathPro.Append(path4 + "\\" + i  +"\\Archivo" + j + "pp.png");
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
        
    }
}
