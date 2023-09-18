namespace Regla30
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.canvas = new System.Windows.Forms.Button();
            this.insertarCadena = new System.Windows.Forms.Button();
            this.regla = new System.Windows.Forms.TextBox();
            this.colorButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tamanoCanvas = new System.Windows.Forms.TextBox();
            this.dibujarCadena = new System.Windows.Forms.Button();
            this.largoCadena = new System.Windows.Forms.TextBox();
            this.cadenaLbl = new System.Windows.Forms.Label();
            this.cadenosa = new System.Windows.Forms.TextBox();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.porcentajeLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.Location = new System.Drawing.Point(12, 189);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(114, 23);
            this.canvas.TabIndex = 0;
            this.canvas.Text = "Iniciar Simulacion";
            this.canvas.UseVisualStyleBackColor = true;
            this.canvas.Click += new System.EventHandler(this.canvas_Click);
            // 
            // insertarCadena
            // 
            this.insertarCadena.Location = new System.Drawing.Point(325, 209);
            this.insertarCadena.Name = "insertarCadena";
            this.insertarCadena.Size = new System.Drawing.Size(123, 23);
            this.insertarCadena.TabIndex = 1;
            this.insertarCadena.Text = "Datos Aleatorios";
            this.insertarCadena.UseVisualStyleBackColor = true;
            this.insertarCadena.Click += new System.EventHandler(this.insertarCadena_Click);
            // 
            // regla
            // 
            this.regla.Location = new System.Drawing.Point(171, 40);
            this.regla.Name = "regla";
            this.regla.PlaceholderText = "Inserte la Regla";
            this.regla.Size = new System.Drawing.Size(117, 23);
            this.regla.TabIndex = 2;
            // 
            // colorButton
            // 
            this.colorButton.Location = new System.Drawing.Point(325, 180);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(123, 23);
            this.colorButton.TabIndex = 3;
            this.colorButton.Text = "Seleccione Color";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Inserte la Regla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Numero mayor a alcanzar";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "255",
            "511",
            "1023",
            "2047",
            "4095",
            "8191",
            "16383",
            "32767",
            "65535"});
            this.listBox1.Location = new System.Drawing.Point(12, 242);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(113, 19);
            this.listBox1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Inserte el Tamaño(min 10, max 22500\r\n";
            // 
            // tamanoCanvas
            // 
            this.tamanoCanvas.Location = new System.Drawing.Point(171, 84);
            this.tamanoCanvas.Name = "tamanoCanvas";
            this.tamanoCanvas.PlaceholderText = "Inserte Tamaño";
            this.tamanoCanvas.Size = new System.Drawing.Size(117, 23);
            this.tamanoCanvas.TabIndex = 8;
            // 
            // dibujarCadena
            // 
            this.dibujarCadena.Location = new System.Drawing.Point(325, 238);
            this.dibujarCadena.Name = "dibujarCadena";
            this.dibujarCadena.Size = new System.Drawing.Size(123, 23);
            this.dibujarCadena.TabIndex = 9;
            this.dibujarCadena.Text = "Dibujar Cadena";
            this.dibujarCadena.UseVisualStyleBackColor = true;
            this.dibujarCadena.Click += new System.EventHandler(this.dibujarCadena_Click);
            // 
            // largoCadena
            // 
            this.largoCadena.Location = new System.Drawing.Point(220, 238);
            this.largoCadena.Name = "largoCadena";
            this.largoCadena.PlaceholderText = "Ingrese el Largo de la cadena";
            this.largoCadena.Size = new System.Drawing.Size(99, 23);
            this.largoCadena.TabIndex = 10;
            // 
            // cadenaLbl
            // 
            this.cadenaLbl.AutoSize = true;
            this.cadenaLbl.Location = new System.Drawing.Point(173, 110);
            this.cadenaLbl.Name = "cadenaLbl";
            this.cadenaLbl.Size = new System.Drawing.Size(98, 15);
            this.cadenaLbl.TabIndex = 11;
            this.cadenaLbl.Text = "Ingrese la cadena";
            // 
            // cadenosa
            // 
            this.cadenosa.Location = new System.Drawing.Point(12, 128);
            this.cadenosa.Name = "cadenosa";
            this.cadenosa.PlaceholderText = "Ingrese la cadena, por ejemplo (0110011100010)";
            this.cadenosa.Size = new System.Drawing.Size(436, 23);
            this.cadenosa.TabIndex = 12;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(359, 18);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(89, 21);
            this.hScrollBar1.TabIndex = 13;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // porcentajeLbl
            // 
            this.porcentajeLbl.AutoSize = true;
            this.porcentajeLbl.Location = new System.Drawing.Point(359, 3);
            this.porcentajeLbl.Name = "porcentajeLbl";
            this.porcentajeLbl.Size = new System.Drawing.Size(0, 15);
            this.porcentajeLbl.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 273);
            this.Controls.Add(this.porcentajeLbl);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.cadenosa);
            this.Controls.Add(this.cadenaLbl);
            this.Controls.Add(this.largoCadena);
            this.Controls.Add(this.dibujarCadena);
            this.Controls.Add(this.tamanoCanvas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.regla);
            this.Controls.Add(this.insertarCadena);
            this.Controls.Add(this.canvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button canvas;
        private Button insertarCadena;
        private TextBox regla;
        private Button colorButton;
        private ColorDialog colorDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
        private Label label2;
        private ListBox listBox1;
        private Label label3;
        private TextBox tamanoCanvas;
        private Button dibujarCadena;
        private TextBox largoCadena;
        private Label cadenaLbl;
        private TextBox cadenosa;
        private HScrollBar hScrollBar1;
        private Label porcentajeLbl;
    }
}