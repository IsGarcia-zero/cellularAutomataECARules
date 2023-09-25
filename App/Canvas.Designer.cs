namespace Regla30
{
    partial class Canvas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            dibujoAutomata = new PictureBox();
            btnColor1 = new Button();
            colorDialog1 = new ColorDialog();
            btnColor2 = new Button();
            iniciar = new Button();
            button1 = new Button();
            guardarSolucion = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dibujoAutomata).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(dibujoAutomata);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1001, 1001);
            panel1.TabIndex = 0;
            // 
            // dibujoAutomata
            // 
            dibujoAutomata.Location = new Point(0, 0);
            dibujoAutomata.Name = "dibujoAutomata";
            dibujoAutomata.Size = new Size(1001, 1001);
            dibujoAutomata.SizeMode = PictureBoxSizeMode.Zoom;
            dibujoAutomata.TabIndex = 0;
            dibujoAutomata.TabStop = false;
            dibujoAutomata.MouseDown += dibujoAutomata_MouseDown;
            dibujoAutomata.MouseMove += dibujoAutomata_MouseMove;
            // 
            // btnColor1
            // 
            btnColor1.Location = new Point(1019, 70);
            btnColor1.Name = "btnColor1";
            btnColor1.Size = new Size(103, 23);
            btnColor1.TabIndex = 1;
            btnColor1.Text = "Color Fondo";
            btnColor1.UseVisualStyleBackColor = true;
            btnColor1.Click += btnColor1_Click;
            // 
            // btnColor2
            // 
            btnColor2.Location = new Point(1019, 41);
            btnColor2.Name = "btnColor2";
            btnColor2.Size = new Size(103, 23);
            btnColor2.TabIndex = 2;
            btnColor2.Text = "Color celula";
            btnColor2.UseVisualStyleBackColor = true;
            btnColor2.Click += btnColor2_Click;
            // 
            // iniciar
            // 
            iniciar.Location = new Point(1019, 12);
            iniciar.Name = "iniciar";
            iniciar.Size = new Size(103, 23);
            iniciar.TabIndex = 3;
            iniciar.Text = "Dibujar";
            iniciar.UseVisualStyleBackColor = true;
            iniciar.Click += iniciar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1019, 99);
            button1.Name = "button1";
            button1.Size = new Size(105, 23);
            button1.TabIndex = 4;
            button1.Text = "Guardar Imagen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // guardarSolucion
            // 
            guardarSolucion.Location = new Point(1019, 128);
            guardarSolucion.Name = "guardarSolucion";
            guardarSolucion.Size = new Size(103, 23);
            guardarSolucion.TabIndex = 5;
            guardarSolucion.Text = "Guardar sol";
            guardarSolucion.UseVisualStyleBackColor = true;
            guardarSolucion.Click += guardarSolucion_Click;
            // 
            // Canvas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 1061);
            Controls.Add(guardarSolucion);
            Controls.Add(button1);
            Controls.Add(iniciar);
            Controls.Add(btnColor2);
            Controls.Add(btnColor1);
            Controls.Add(panel1);
            Name = "Canvas";
            Text = "Canvas";
            KeyPress += Canvas_KeyPress;
            PreviewKeyDown += Canvas_PreviewKeyDown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dibujoAutomata).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox dibujoAutomata;
        private Button btnColor1;
        private ColorDialog colorDialog1;
        private Button btnColor2;
        private Button iniciar;
        private Button button1;
        private Button guardarSolucion;
    }
}