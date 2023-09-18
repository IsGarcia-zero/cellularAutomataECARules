using Regla30.Objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Regla30
{
    public partial class Canvas : Form
    {
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
            foreach (String s in inte.CadenasReales)
            {
                File.AppendAllText("C:\\Users\\Iljim\\Desktop\\log2.txt", s + "\n");
            }
        }

        private void btnColor2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                cel.Celula = colorDialog1.Color;
            }
        }
        private void pintarMatriz()
        {
            longitudPixel = (cel.TamCadena > 1000 || cel.T > 1000) ? (22501/cel.TamCadena ) : (originalHeight / Math.Max(cel.T, cel.TamCadena)); 
            Bitmap bmp = (cel.TamCadena > 1000 || cel.T > 1000) ? new Bitmap(cel.TamCadena + 1, cel.T + 1) : new Bitmap(originalWidth, originalHeight);
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
            Bitmap originalImagen = (Bitmap)dibujoAutomata.Image;
            originalImagen.RotateFlip(RotateFlipType.Rotate90FlipNone);
            dibujoAutomata.Image = originalImagen;
            originalWidth = dibujoAutomata.Image.Width;
            originalHeight = dibujoAutomata.Image.Height;
            dibujoAutomata.Image.Save("C:\\Users\\Iljim\\Desktop\\log2.png");
        }
        private void pintarPixel(Bitmap bmp, int x, int y, Color color)
        {
            int mayor = Math.Max(cel.T, cel.TamCadena);
            int menor = Math.Min(cel.T, cel.TamCadena);

            int pixelSize = originalHeight / mayor;

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
            pintarMatriz();
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
    }
}

