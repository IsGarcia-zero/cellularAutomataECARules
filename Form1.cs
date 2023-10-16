
using Regla30.App;
using Regla30.Objetos;
using Regla30.Utilidades;
using System.IO;
using System.Security;
using System.Text;
using System.Text.Json;

namespace Regla30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.SetSelected(0, true);
            hScrollBar1.Value = 50;
            porcentajeLbl.Text = $"Porcentaje {hScrollBar1.Value}%";
            cel.PorcentajeRandom = hScrollBar1.Value;
        }
        Objetos.Celulas cel = new();
        Objetos.Intermedios inte = new();
        Utilidades.RandomPro rand = new();

        private void canvas_Click(object sender, EventArgs e)
        {
            Utilidades.Reglas regl = new(cel, inte);
            Canvas canvas = new Canvas(cel, inte);
            try
            {
                cel.Regla = Convert.ToInt32(regla.Text);
                cel.NumeroMayor = Convert.ToInt64(listBox1.Text);
                cel.T = Convert.ToInt32(tamanoCanvas.Text);
                cel.Cadena = cadenosa.Text;
                cel.TamCadena = cadenosa.Text.Length;
                cel.Fondo = cel.Celula.Equals(Color.White) ? Color.Black : Color.White;
                cel.Celula = cel.Fondo.Equals(Color.White) ? Color.Black : Color.White;
                cel.PorcentajeRandom = hScrollBar1.Value;
                //string jsonString = JsonSerializer.Serialize(cel);
                //File.WriteAllText("C:\\Users\\Iljim\\Desktop\\datos.json", jsonString);
                regl.conversion(0, 0);
                if (comprovacion()) MessageBox.Show("Algun campo no esta llenado correctamente");
                else canvas.ShowDialog();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show(ex.Message);
            }
        }

        private void insertarCadena_Click(object sender, EventArgs e)
        {
            double porcentajeActual = hScrollBar1.Value;
            double relacion = porcentajeActual / 100;
            try
            {
                cadenosa.Text = rand.GenerateRandomBinaryString(Convert.ToInt64(largoCadena.Text), relacion);

            }
            catch (Exception exx)
            {
                MessageBox.Show("Inserte un largo para la cadena");
            }
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                cel.Celula = colorDialog1.Color;
            }

        }
        private bool comprovacion()
        {
            return ((cel.Regla > cel.NumeroMayor || cel.Regla < 0)
                && (cel.T < 10 || cel.T > 22500)
                && (string.IsNullOrEmpty(cel.Cadena))
                );
        }
        private bool comprovacion2()
        {
            return ((cel.Regla > cel.NumeroMayor || cel.Regla < 0)
                && (cel.T < 10 || cel.T > 22500)
                && (cel.TamCadena < 0)
                );
        }
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int valorActual = hScrollBar1.Value;
            cel.PorcentajeRandom = valorActual;
            porcentajeLbl.Text = $"Porcentaje {valorActual}%";
        }

        private void dibujarCadena_Click(object sender, EventArgs e)
        {
            Utilidades.Reglas regl = new(cel, inte);
            App.DibujarCadena dibCadena = new(cel, inte);
            try
            {
                cel.Regla = Convert.ToInt32(regla.Text);
                cel.NumeroMayor = Convert.ToInt64(listBox1.Text);
                cel.T = Convert.ToInt32(tamanoCanvas.Text);
                cel.TamCadena = Convert.ToInt32(largoCadena.Text);
                cel.Fondo = cel.Celula.Equals(Color.White) ? Color.Black : Color.White;
                //regl.conversion();
                if (comprovacion2()) MessageBox.Show("Algun campo no esta llenado correctamente");
                else dibCadena.ShowDialog();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show(ex.Message);
            }
        }

        private void datosSave_Click(object sender, EventArgs e)
        {
            string nombreArchivo;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Archivos JSON (*.json)|*.json";
            saveFileDialog1.Title = "Guarde los datos iniciales";
            saveFileDialog1.ShowDialog();
            cel.Regla = Convert.ToInt32(regla.Text);
            cel.NumeroMayor = Convert.ToInt64(listBox1.Text);
            cel.T = Convert.ToInt32(tamanoCanvas.Text);
            cel.Cadena = cadenosa.Text;
            cel.TamCadena = (string.IsNullOrEmpty(largoCadena.Text)) ? cadenosa.Text.Length : Convert.ToInt32(largoCadena.Text);
            cel.Fondo = cel.Celula.Equals(Color.White) ? Color.Black : Color.White;
            cel.Celula = cel.Fondo.Equals(Color.White) ? Color.Black : Color.White;
            cel.PorcentajeRandom = hScrollBar1.Value;
            string jsonSerializer = JsonSerializer.Serialize(cel);
            if (saveFileDialog1.FileName != "" || saveFileDialog1.FileName == "*.json")
            {
                nombreArchivo = saveFileDialog1.FileName;
                File.WriteAllText(nombreArchivo, jsonSerializer);
            }

        }

        private void cargarDatos_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivos JSON (*.json)|*.json";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var sr = new StreamReader(openFileDialog1.FileName);
                    string jsonString = sr.ReadToEnd();
                    cel = JsonSerializer.Deserialize<Objetos.Celulas>(jsonString);
                    regla.Text = cel.Regla.ToString();
                    listBox1.Text = cel.NumeroMayor.ToString();
                    tamanoCanvas.Text = cel.T.ToString();
                    cadenosa.Text = cel.Cadena;
                    largoCadena.Text = cel.TamCadena.ToString();
                    hScrollBar1.Value = Convert.ToInt32(cel.PorcentajeRandom);
                    porcentajeLbl.Text = $"Porcentaje {cel.PorcentajeRandom}%";
                    sr.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivos TXT (*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var sr = new StreamReader(openFileDialog1.FileName);
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
            cel.Regla = Convert.ToInt32(regla.Text);
            cel.NumeroMayor = Convert.ToInt64(listBox1.Text);
            cel.T = Convert.ToInt32(tamanoCanvas.Text);
            cel.Cadena = cadenosa.Text;
            cel.TamCadena = cadenosa.Text.Length;
            cel.Fondo = cel.Celula.Equals(Color.White) ? Color.Black : Color.White;
            cel.Celula = cel.Fondo.Equals(Color.White) ? Color.Black : Color.White;
            cel.PorcentajeRandom = hScrollBar1.Value;
            Canvas canvas = new Canvas(cel, inte);
            canvas.ShowDialog();
        }

        private void allBut_Click(object sender, EventArgs e)
        {
            Canvas canvas = new Canvas(cel, inte);
            Utilidades.Reglas regl = new(cel, inte);
            Utilidades.TodasReglas rrr = new();
            rrr.borrarRutas(1);
            rrr.crearRutas(1);
            rrr.borrarRutas(2);
            rrr.crearRutas(2);
            cel.NumeroMayor = 255;
            cel.T = 1000;
            cel.TamCadena = 1000;
            cel.Fondo = Color.White;
            cel.Celula = Color.Black;
            for (int i = 0; i < 4; i++)
            {
                switch (i)
                {
                    case 0:
                        cel.Cadena = rand.GenerateRandomBinaryString(1000, 0.02);
                        cel.PorcentajeRandom = 2;
                        break;
                    case 1:
                        cel.Cadena = rand.GenerateRandomBinaryString(1000, 0.5);
                        cel.PorcentajeRandom = 50;
                        break;
                    case 2:
                        cel.Cadena = rand.GenerateRandomBinaryString(1000, 0.75);
                        cel.PorcentajeRandom = 75;
                        break;
                    case 3:
                        cel.Cadena = rand.GenerateRandomBinaryString(1000, 0.95);
                        cel.PorcentajeRandom = 95;
                        break;
                }
                for (int j = 0; j < 256; j++)
                {
                    cel.Regla = j;
                    string jsonBuilder = JsonSerializer.Serialize(cel);
                    rrr.crearArchivos(1, jsonBuilder, j, cel.PorcentajeRandom);
                    regl.conversion(j, cel.PorcentajeRandom);
                }
            }
            canvas.ShowDialog();
        }

        private void grafics_Click(object sender, EventArgs e)
        {
            Utilidades.Reglas regl = new(cel, inte);
            Grafo grafo = new(cel, inte);
            try
            {
                cel.Regla = Convert.ToInt32(regla.Text);
                cel.NumeroMayor = Convert.ToInt64(listBox1.Text);
                cel.T = Convert.ToInt32(tamanoCanvas.Text);
                cel.Cadena = cadenosa.Text;
                cel.TamCadena = cadenosa.Text.Length;
                cel.Fondo = cel.Celula.Equals(Color.White) ? Color.Black : Color.White;
                cel.Celula = cel.Fondo.Equals(Color.White) ? Color.Black : Color.White;
                cel.PorcentajeRandom = hScrollBar1.Value;
                //string jsonString = JsonSerializer.Serialize(cel);

                if (comprovacion()) MessageBox.Show("Algun campo no esta llenado correctamente");
                else grafo.ShowDialog();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show(ex.Message);
            }
        }

        private void latexGen_Click(object sender, EventArgs e)
        {
            TodasReglas rrrr = new();
            StringBuilder latexContent = rrrr.generarL();
            //Escribir el string en un archivo
            string nombreArchivo = "C:\\Users\\Iljim\\Desktop\\AutomatasCelularesInfo\\Anexo.tex";
            using (StreamWriter writer = new StreamWriter(nombreArchivo))
            {
                int chunkSize = 4096; // Tamaño del trozo a escribir (puedes ajustar esto según sea necesario)
                int index = 0;

                while (index < latexContent.Length)
                {
                    int remainingLength = latexContent.Length - index;
                    int writeLength = Math.Min(chunkSize, remainingLength);

                    writer.Write(latexContent.ToString(index, writeLength));

                    index += writeLength;
                }
            }

        }
    }
}