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

        private void graffo_Click(object sender, EventArgs e)
        {
            var cadenaDOT = new StringBuilder("digraph G {");
            for (int i = 0; i < dats.CadenaAtrctList.Count - 1; i++)
            {
                cadenaDOT.AppendLine($"\"{dats.CadenaAtrctList[i].CadenaAnterior}\" -> \"{dats.CadenaAtrctList[i].CadenaActual}\";");
            }
            cadenaDOT.AppendLine("}");
            cadenaDOT = cadenaDOT.Replace("\r\n", "");
            File.WriteAllText(paths.Path6 + "\\grafico.dot", cadenaDOT.ToString());
            Process process = new Process();
            process.StartInfo.FileName = "dot";
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

            pictureBox1.Image = Image.FromFile(paths.Path6 + "\\graph.png");

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
