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
using ZedGraph;
namespace Regla30.App
{
    public partial class Grafo : Form
    {
        Intermedios inte;
        Objetos.Celulas cel;
        private ZedGraphControl zedGraphControl1;

        public Grafo(Celulas cel, Intermedios inte)
        {
            InitializeComponent();
            this.cel = cel;
            this.inte = inte;
            zedGraphControl1 = new ZedGraphControl();
            zedGraphControl1.Dock = DockStyle.Fill;
            Controls.Add(zedGraphControl1);
        }

        private void graffo_Click(object sender, EventArgs e)
        {
            Utilidades.Reglas regl = new(cel, inte);
            regl.conversion(0, 0);

            List<List<AtractorInfo>> atractoresPorGeneracion = regl.ObtenerAtractoresEnTodasLasGeneraciones(0, 0);

            // Dibujar atractores en el gráfico ZedGraph
            zedGraphControl1.GraphPane.CurveList.Clear();

            for (int i = 0; i < atractoresPorGeneracion.Count; i++)
            {
                PointPairList puntosAtractores = new PointPairList();

                foreach (var atractor in atractoresPorGeneracion[i])
                {
                    puntosAtractores.Add(atractor.Inicio, atractor.Longitud);
                }

                LineItem curvaAtractores = new LineItem($"Generación {i + 1}", puntosAtractores, Color.Blue, SymbolType.Circle);
                curvaAtractores.Line.IsVisible = true; // Mostrar líneas de conexión entre puntos
                zedGraphControl1.GraphPane.CurveList.Add(curvaAtractores);

                // Agregar etiquetas a cada punto
                for (int j = 0; j < puntosAtractores.Count; j++)
                {
                    TextObj etiqueta = new TextObj($"P{j + 1}", puntosAtractores[j].X, puntosAtractores[j].Y);
                    etiqueta.FontSpec.Size = 10;
                    etiqueta.FontSpec.Border.IsVisible = false;
                    zedGraphControl1.GraphPane.GraphObjList.Add(etiqueta);
                }
            }

            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
        }
    }
}
