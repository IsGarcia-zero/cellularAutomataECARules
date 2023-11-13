using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Intrinsics.X86;
using Regla30.Objetos;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;
using System.IO;

namespace Regla30.App
{
    public partial class Graficas : Form
    {
        Intermedios inte;
        Objetos.Celulas cel;
        private Paths paths = new();
        public Graficas(Intermedios inte, Celulas cel)
        {
            InitializeComponent();
            this.inte = inte;
            this.cel = cel;
            cartesianChart1.EasingFunction = null;
        }

        private void cartesianChart1_Load(object sender, EventArgs e)
        {
        }

        private void butUnos_Click(object sender, EventArgs e)
        {
            Utilidades.CalculoGrafs calcrr = new(inte, cel);
            graficarAsync(265, 265, 1);
        }

        private void butLog_Click(object sender, EventArgs e)
        {
            Utilidades.CalculoGrafs calcrr = new(inte, cel);
            graficarAsync(265, 265, 2);
        }

        private void butShan_Click(object sender, EventArgs e)
        {
            Utilidades.CalculoGrafs calcrr = new(inte, cel);
            graficarAsync(265, 265, 3);
        }
        private System.Windows.Forms.Timer timer;
        private void graficarAsync(int irl, double jrl, int op) {
            
            Utilidades.CalculoGrafs calcrr = new(inte, cel);
            if (irl != 265 || jrl != 265)
            {
                try
                {
                    StringBuilder pathPro2 = new();
                    pathPro2.Append(paths.Path2 + "\\" + irl + "\\Archivo" + jrl + "pp.txt");
                    var sr = new StreamReader(pathPro2.ToString());
                    string jsonString = sr.ReadToEnd();
                    jsonString = jsonString.TrimEnd('\r', '\n');
                    inte.CadenasReales = jsonString.Split("\n");
                    sr.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    MessageBox.Show(ex.Message);
                }

            }
            switch (op) {
                case 1:
                    List<int> dd = new();
                    for (int i = 0; i < inte.CadenasReales.Length; i++)
                    {
                        Int64 num = 0;
                        String s = inte.CadenasReales[i];
                        num = calcrr.densidad1s(s);
                        dd.Add(Convert.ToInt32(num));

                    }
                    
                    cartesianChart1.Series = new ISeries[] {
                        new LineSeries<int>{
                            Values = dd,
                            GeometryStroke = null,
                            GeometryFill = null
                            }
                    };
                    cartesianChart1.ZoomMode = LiveChartsCore.Measure.ZoomAndPanMode.X;
                    //Thread.Sleep(1000);
                    //cartesianChart1.Update();
                    break;
                case 2:
                    List<double> dd2 = new();
                    for (int i = 0; i < inte.CadenasReales.Length; i++)
                    {
                        Int64 num = 0;
                        Double logn = 0;
                        String s = inte.CadenasReales[i];
                        num = calcrr.densidad1s(s);
                        logn = calcrr.densidad1sLog(num);
                        dd2.Add(logn);
                    }
                    cartesianChart1.Series = new ISeries[] {
                        new LineSeries<double>{
                            Values = dd2,
                            GeometryStroke = null,
                            GeometryFill = null
                        }
                    };
                    cartesianChart1.ZoomMode = LiveChartsCore.Measure.ZoomAndPanMode.X;
                    //Thread.Sleep(1000);
                    //cartesianChart1.Update();
                    break;
                case 3:
                    List<double> dd3 = new();
                    for (int i = 0; i < inte.CadenasReales.Length; i++)
                    {
                        Double shanon = 0;
                        String s = inte.CadenasReales[i];
                        shanon = calcrr.entriopiaShanon(s);
                        dd3.Add(shanon);
                    }
                    cartesianChart1.Series = new ISeries[] {
                        new LineSeries<double>{
                            Values = dd3,
                            GeometryStroke = null,
                            GeometryFill = null
                        }
                    };
                    cartesianChart1.ZoomMode = LiveChartsCore.Measure.ZoomAndPanMode.X;
                    //cartesianChart1.Update();
                    //Thread.Sleep(1000);
                    break;
            }
            Application.DoEvents();
            if (irl != 265 && jrl != 265)
            {

                GuardarComoImagen(irl, jrl, op);
                
            }
        }

        private void GuardarComoImagen(int irl, double jrl, int op)
        {
            StringBuilder pathPro = new();
            
            Bitmap bmp = new Bitmap(cartesianChart1.Width, cartesianChart1.Height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                cartesianChart1.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
            }
            
            pathPro.Append(paths.Path4 + "\\" + irl + "\\"+op);
            if (Directory.Exists(pathPro.ToString()))
            {
                Console.WriteLine("That path exists already.");
                //return;
            }

            try
            {
               

                // Try to create the directory.
                DirectoryInfo di = Directory.CreateDirectory(pathPro.ToString());
                Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(pathPro.ToString()));
            }
            catch (Exception ex)
            {
                Console.WriteLine("The process failed: {0}", ex.ToString());
            }
            
            bmp.Save(pathPro.ToString() + "\\Graf" + jrl + "pp.png");

        }

        private void sveGrafc_Click(object sender, EventArgs e)
        {
            GuardarComoImagen(265, 265, 1);
        }

        private void svAll_Click(object sender, EventArgs e)
        {
            Utilidades.TodasReglas rodas = new();

            rodas.borrarRutas(4);
            rodas.crearRutas(4);
            double gg = 0;
            for (int r = 1; r < 4; r++)
            {
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
                        graficarAsync(j, gg, r);
                    }

                }
            }
        }
    }
}
