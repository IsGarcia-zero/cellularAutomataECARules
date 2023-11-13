using Regla30.Objetos;
using Regla30.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Regla30
{
    public partial class Canvas : Form
    {
        private Paths paths = new();
        private Objetos.Celulas cel;
        private Objetos.Intermedios inte;
        private int longitud = 80;
        private int longitudPixel;
        private int zoom = 0;
        private int originalWidth;
        private int originalHeight;

        public Canvas(Objetos.Celulas cel, Intermedios inte)
        {
            InitializeComponent();
            this.cel = cel;
            this.inte = inte;
            originalWidth = dibujoAutomata.Width;
            originalHeight = dibujoAutomata.Height;
            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(Canvas_KeyPress);
        }




        private void btnColor1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                cel.Fondo = colorDialog1.Color;
            }

        }

        private void btnColor2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                cel.Celula = colorDialog1.Color;
            }
        }
        private void pintarMatriz(int irl, double jrl)
        {
            StringBuilder pathPro = new();

            longitudPixel = (cel.TamCadena > 1000 || cel.T > 1000) ? (Math.Max(cel.TamCadena, cel.T) / Math.Max(cel.TamCadena, cel.T)) : (originalHeight / Math.Max(cel.T, cel.TamCadena));
            Bitmap bmp = (cel.TamCadena > 1000 || cel.T > 1000) ? new Bitmap(cel.TamCadena + 1, cel.T + 1) : new Bitmap(originalWidth, originalHeight);
            if (irl != 265 || jrl != 265)
            {
                try
                {
                    StringBuilder pathPro2 = new();
                    pathPro2.Append(paths.Path2 + "\\" + irl + "\\Archivo" + jrl + "pp.txt");
                    var sr = new StreamReader(pathPro2.ToString());
                    string jsonString = sr.ReadToEnd();
                    inte.CadenasReales = jsonString.Split("\n");
                    sr.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    MessageBox.Show(ex.Message);
                }

            }
            for (int x = 0; x < inte.CadenasReales.Length; x++)
            {

                String s = inte.CadenasReales[x];

                for (int y = 0; y < s.Length; y++)
                {
                    if (s[y] == '0')
                    {
                        pintarPixel(bmp, x, y, cel.Fondo);
                    }
                    else
                    {
                        pintarPixel(bmp, x, y, cel.Celula);
                    }
                }
            }
            dibujoAutomata.Image = bmp;
            pathPro.Append(paths.Path3 + "\\" + irl + "\\Archivo" + jrl + "pp.png");
            Bitmap originalImagen = (Bitmap)dibujoAutomata.Image;
            originalImagen.RotateFlip(RotateFlipType.Rotate90FlipNone);
            dibujoAutomata.Image = originalImagen;
            originalWidth = dibujoAutomata.Image.Width;
            originalHeight = dibujoAutomata.Image.Height;
            if (irl != 265 || jrl != 265)
            {
                dibujoAutomata.Image.Save(pathPro.ToString());
                if (irl == 255 && jrl == 95) Console.Beep();
            }
            //dibujoAutomata.Image.Save("C:\\Users\\Iljim\\Desktop\\log2.png");
        }
        private void pintarPixel(Bitmap bmp, int x, int y, Color color)
        {


            int pixelSize = (cel.TamCadena > 1000 || cel.T > 1000) ? (Math.Max(cel.TamCadena, cel.T) / Math.Max(cel.TamCadena, cel.T)) : (originalHeight / Math.Max(cel.T, cel.TamCadena));

            int startX = x * pixelSize;
            int startY = y * pixelSize;
            int endX = startX + pixelSize;
            int endY = startY + pixelSize;

            for (int i = startX; i < endX; i++)
            {
                for (int j = startY; j < endY; j++)
                {
                    if (i >= 0 && i < bmp.Width && j >= 0 && j < bmp.Height)
                    {
                        bmp.SetPixel(i, j, color);
                    }
                }
            }
        }
        private void iniciar_Click(object sender, EventArgs e)
        {
            pintarMatriz(265, 265);
            dibujoAutomata.Focus();
        }
        private void Canvas_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }


        private void dibujoAutomata_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void dibujoAutomata_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Canvas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '+')
            {
                zoom++;
                dibujoAutomata.Height += zoom;
                dibujoAutomata.Width += zoom;
            }
            else if (e.KeyChar == '-')
            {
                if (zoom > 0.2f)
                {
                    zoom--;
                    dibujoAutomata.Height -= zoom;
                    dibujoAutomata.Width -= zoom;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog Guardar = new SaveFileDialog();
            Guardar.Filter = "JPEG(*.JPG)|*.JPG|BMP(*.BMP)|*.BMP|PNG(*.PNG)|*.PNG";
            if (Guardar.ShowDialog() == DialogResult.OK)
            {
                dibujoAutomata.Image.Save(Guardar.FileName);
            }
        }

        private void guardarSolucion_Click(object sender, EventArgs e)
        {
            string nombreArchivo;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Archivos TXT (*.txt)|*.txt";
            saveFileDialog1.Title = "Guarde los datos iniciales";
            saveFileDialog1.ShowDialog();
            StringBuilder sr = new();
            foreach (string hola in inte.CadenasReales)
            {
                sr.Append(hola);
                sr.Append("\n");
            }
            sr.Remove(sr.Length - 1, 1);
            if (saveFileDialog1.FileName != "" || saveFileDialog1.FileName == "*.json")
            {
                nombreArchivo = saveFileDialog1.FileName;
                File.WriteAllText(nombreArchivo, sr.ToString());
            }
        }

        private void allImag_Click(object sender, EventArgs e)
        {
            Stopwatch timer = new();
            timer.Start();
            Utilidades.TodasReglas rrr = new();
            rrr.borrarRutas(3);
            rrr.crearRutas(3);
            double gg = 0;
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
                    pintarMatriz(j, gg);
                }
            }
            timer.Stop();
            TimeSpan tiempoTardado = timer.Elapsed;
            MessageBox.Show($"Se tardo {tiempoTardado} en dibujar todos los estados de los automatas");
        }

        private void grfcs_Click(object sender, EventArgs e)
        {
            Stopwatch timer = new();
            timer.Start();
            Utilidades.TodasReglas rrr = new();
            rrr.borrarRutas(5);
            rrr.crearRutas(5);
            double gg = 0;
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
                    recorridoCadenas(j, gg);
                }
            }
            timer.Stop();
            TimeSpan tiempoTardado = timer.Elapsed;
            MessageBox.Show($"Se tardo {tiempoTardado} en dibujar todos los estados de los automatas");
        }
        private void recorridoCadenas(int irl, double jrl)
        {
            CalculoGrafs calcrr = new(inte, cel);
            Utilidades.TodasReglas rrr = new();
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
                StringBuilder sss = new();

                for (int i = 0; i < inte.CadenasReales.Length; i++)
                {
                    Int64 num = 0;
                    Double logn = 0, shanon = 0;
                    String s = inte.CadenasReales[i];
                    num = calcrr.densidad1s(s);
                    logn = calcrr.densidad1sLog(num);
                    shanon = calcrr.entriopiaShanon(s);
                    sss.Append(i + "," + num + "," + logn + "," + shanon + "," + s + "\n");
                }

                rrr.crearArchivos(5, sss.ToString(), irl, jrl);
            }
        }

        private void graphsss_Click(object sender, EventArgs e)
        {
            App.Graficas graficas = new(inte, cel);
            graficas.ShowDialog();
        }
    }
}

