using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Regla30.App
{
    public partial class DibujarCadena : Form
    {
        Objetos.Celulas cel;
        Objetos.Intermedios inte;
        private Rectangle[] rectangulos;
        private Boolean[] estadoCeldas;
        public DibujarCadena(Objetos.Celulas cel, Objetos.Intermedios inte)
        {
            InitializeComponent();
            this.cel = cel;
            this.inte = inte;
            panel1.Paint += panel1_Paint;
            panel1.MouseClick += panel1_MouseClick;

        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (rectangulos != null)
            {
                for (int i = 0; i < rectangulos.Length; i++)
                {
                    Rectangle rect = rectangulos[i];
                    Brush brush = estadoCeldas[i] ? Brushes.Black : Brushes.White;
                    e.Graphics.FillRectangle(brush, rect);
                }
            }
        }
        private bool mouse = false;
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (mouse)
            {
                mouse = false;
                return;
            }
            for (int i = 0; i < rectangulos.Length; i++)
            {
                Rectangle rect = rectangulos[i];
                if (rect.Contains(e.Location))
                {
                    estadoCeldas[i] = !estadoCeldas[i];
                    panel1.Invalidate();
                    break;
                }
            }
            mouse = true;
        }

        private void DibujarCadena_Load(object sender, EventArgs e)
        {
            estadoCeldas = new Boolean[cel.TamCadena];

            rectangulos = new Rectangle[cel.TamCadena];
            int rectWidth = (panel1.Width / cel.TamCadena);
            int rectHeight = panel1.Height;
            int y = 10;

            for (int i = 0; i < rectangulos.Length; i++)
            {
                int x = i * rectWidth;
                rectangulos[i] = new Rectangle(x, y, rectWidth, rectHeight);
            }

            panel1.Invalidate();
        }

        private void daleGo_Click(object sender, EventArgs e)
        {
            Utilidades.Reglas regl = new(cel, inte);
            Canvas canvas = new(cel, inte);
            StringBuilder sb = new();
            foreach (bool s in estadoCeldas)
            {
                sb.Append(s ? "1" : "0");
            }
            cel.Cadena = sb.ToString();
            regl.conversion(0,0);
            canvas.Show();
            this.Hide();
        }

        private void saveDat_Click(object sender, EventArgs e)
        {
            string nombreArchivo;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Archivos JSON (*.json)|*.json";
            saveFileDialog1.Title = "Guarde los datos iniciales";
            saveFileDialog1.ShowDialog();
            StringBuilder sb = new();
            foreach (bool s in estadoCeldas)
            {
                sb.Append(s ? "1" : "0");
            }
            cel.Cadena = sb.ToString();
            string jsonSerializer = JsonSerializer.Serialize(cel);
            if (saveFileDialog1.FileName != "" || saveFileDialog1.FileName == "*.json")
            {
                nombreArchivo = saveFileDialog1.FileName;
                File.WriteAllText(nombreArchivo, jsonSerializer);
            }
        }
    }
}
