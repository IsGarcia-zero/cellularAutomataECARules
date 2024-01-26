using Regla30.Objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Regla30.Datos;
using System.Diagnostics;
using LiveChartsCore.Measure;
using Timer = System.Threading.Timer;

namespace Regla30.App
{
    public partial class Grafo : Form
    {
        Intermedios inte;
        Objetos.Celulas cel;
        private DatsAtrct dats;
        private Paths paths = new();
        private int zoom = 0;
        public Grafo(Celulas cel, Intermedios inte, DatsAtrct dats)
        {
            InitializeComponent();
            this.cel = cel;
            this.inte = inte;
            this.dats = dats;
            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(Grafo_KeyPress);
        }
        private Random random = new Random();

        private string RandomColor()
        {
            return String.Format("#{0:X6}", random.Next(0x1000000)); // Genera un color hexadecimal aleatorio
        }

        private void graffo_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            var cadenaDOT = new StringBuilder("digraph G {");
            cadenaDOT.Append("bgcolor=\"black\";");
            for (int i = 0; i < dats.CadenaAtrctList.Count ; i++)
            {
                // Generar colores aleatorios para cada nodo
                int r = random.Next(0, 256);
                int g = random.Next(0, 256);
                int b = random.Next(0, 256);

                string color = $"#{r:X2}{g:X2}{b:X2}";

                // Añadir los nodos con borde de color aleatorio y fondo negro
                cadenaDOT.AppendLine($"\"{dats.CadenaAtrctList[i].CadenaAnterior}\" [style=filled, fillcolor=\"{color}\"];");
                cadenaDOT.AppendLine($"\"{dats.CadenaAtrctList[i].CadenaActual}\" [style=filled, fillcolor=\"{color}\"]");

                // Añadir las aristas
                cadenaDOT.AppendLine($"\"{dats.CadenaAtrctList[i].CadenaAnterior}\" -> \"{dats.CadenaAtrctList[i].CadenaActual}\"[color=\"{color}\"];");
            }

            cadenaDOT.AppendLine("}");
            cadenaDOT = cadenaDOT.Replace("\r\n", "");
            File.WriteAllText(paths.Path6 + "\\grafico.dot", cadenaDOT.ToString());
            Process process = new Process();    
            process.StartInfo.FileName = "circo";
            process.StartInfo.Arguments = $"-Tpng {paths.Path6 + "\\grafico.dot"} -o {paths.Path6 + "\\graph.png"}";
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.Start();


            process.WaitForExit();

            string errors = process.StandardError.ReadToEnd();
            if (!string.IsNullOrEmpty(errors))
            {
                Console.WriteLine($"Error en: {errors}");
            }


            process.Close();
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            pictureBox1.Image = Image.FromFile(paths.Path6 + "\\graph.png");
            File.AppendAllText(paths.Path6 + "\\estatus.txt", $"Tomo {ts.Minutes} min");
        }

        private Int32 Conversion(string cadena)
        {
            return Convert.ToInt32(cadena, 2);
        }

        private void Grafo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '+')
            {
                zoom++;
                pictureBox1.Height += zoom;
                pictureBox1.Width += zoom;
            }
            else if (e.KeyChar == '-')
            {
                if (zoom > 0.2f)
                {
                    zoom--;
                    pictureBox1.Height -= zoom;
                    pictureBox1.Width -= zoom;
                }
            }
        }

        private void pictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            pictureBox1.Width = pictureBox1.Image.Width;
            pictureBox1.Height = pictureBox1.Image.Height;
        }
    }
}
