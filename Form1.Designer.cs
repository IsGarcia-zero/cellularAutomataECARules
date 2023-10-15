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
            canvas = new Button();
            insertarCadena = new Button();
            regla = new TextBox();
            colorButton = new Button();
            colorDialog1 = new ColorDialog();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label1 = new Label();
            label2 = new Label();
            listBox1 = new ListBox();
            label3 = new Label();
            tamanoCanvas = new TextBox();
            dibujarCadena = new Button();
            largoCadena = new TextBox();
            cadenaLbl = new Label();
            cadenosa = new TextBox();
            hScrollBar1 = new HScrollBar();
            porcentajeLbl = new Label();
            datosSave = new Button();
            cargarDatos = new Button();
            openFileDialog1 = new OpenFileDialog();
            button1 = new Button();
            allBut = new Button();
            grafics = new Button();
            SuspendLayout();
            // 
            // canvas
            // 
            canvas.Location = new Point(12, 189);
            canvas.Name = "canvas";
            canvas.Size = new Size(134, 23);
            canvas.TabIndex = 0;
            canvas.Text = "Iniciar Simulacion";
            canvas.UseVisualStyleBackColor = true;
            canvas.Click += canvas_Click;
            // 
            // insertarCadena
            // 
            insertarCadena.Location = new Point(325, 209);
            insertarCadena.Name = "insertarCadena";
            insertarCadena.Size = new Size(123, 23);
            insertarCadena.TabIndex = 1;
            insertarCadena.Text = "Datos Aleatorios";
            insertarCadena.UseVisualStyleBackColor = true;
            insertarCadena.Click += insertarCadena_Click;
            // 
            // regla
            // 
            regla.Location = new Point(171, 40);
            regla.Name = "regla";
            regla.PlaceholderText = "Inserte la Regla";
            regla.Size = new Size(117, 23);
            regla.TabIndex = 2;
            // 
            // colorButton
            // 
            colorButton.Location = new Point(325, 180);
            colorButton.Name = "colorButton";
            colorButton.Size = new Size(123, 23);
            colorButton.TabIndex = 3;
            colorButton.Text = "Seleccione Color";
            colorButton.UseVisualStyleBackColor = true;
            colorButton.Click += colorButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(185, 12);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 4;
            label1.Text = "Inserte la Regla";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 224);
            label2.Name = "label2";
            label2.Size = new Size(143, 15);
            label2.TabIndex = 5;
            label2.Text = "Numero mayor a alcanzar";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "255", "511", "1023", "2047", "4095", "8191", "16383", "32767", "65535" });
            listBox1.Location = new Point(12, 242);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(134, 19);
            listBox1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(128, 66);
            label3.Name = "label3";
            label3.Size = new Size(201, 15);
            label3.TabIndex = 7;
            label3.Text = "Inserte el Tamaño(min 10, max 22500\r\n";
            // 
            // tamanoCanvas
            // 
            tamanoCanvas.Location = new Point(171, 84);
            tamanoCanvas.Name = "tamanoCanvas";
            tamanoCanvas.PlaceholderText = "Inserte Tamaño";
            tamanoCanvas.Size = new Size(117, 23);
            tamanoCanvas.TabIndex = 8;
            // 
            // dibujarCadena
            // 
            dibujarCadena.Location = new Point(325, 238);
            dibujarCadena.Name = "dibujarCadena";
            dibujarCadena.Size = new Size(123, 23);
            dibujarCadena.TabIndex = 9;
            dibujarCadena.Text = "Dibujar Cadena";
            dibujarCadena.UseVisualStyleBackColor = true;
            dibujarCadena.Click += dibujarCadena_Click;
            // 
            // largoCadena
            // 
            largoCadena.Location = new Point(220, 238);
            largoCadena.Name = "largoCadena";
            largoCadena.PlaceholderText = "Ingrese el Largo de la cadena";
            largoCadena.Size = new Size(99, 23);
            largoCadena.TabIndex = 10;
            // 
            // cadenaLbl
            // 
            cadenaLbl.AutoSize = true;
            cadenaLbl.Location = new Point(173, 110);
            cadenaLbl.Name = "cadenaLbl";
            cadenaLbl.Size = new Size(98, 15);
            cadenaLbl.TabIndex = 11;
            cadenaLbl.Text = "Ingrese la cadena";
            // 
            // cadenosa
            // 
            cadenosa.Location = new Point(12, 128);
            cadenosa.Name = "cadenosa";
            cadenosa.PlaceholderText = "Ingrese la cadena, por ejemplo (0110011100010)";
            cadenosa.Size = new Size(436, 23);
            cadenosa.TabIndex = 12;
            // 
            // hScrollBar1
            // 
            hScrollBar1.Location = new Point(359, 18);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(89, 21);
            hScrollBar1.TabIndex = 13;
            hScrollBar1.Scroll += hScrollBar1_Scroll;
            // 
            // porcentajeLbl
            // 
            porcentajeLbl.AutoSize = true;
            porcentajeLbl.Location = new Point(359, 3);
            porcentajeLbl.Name = "porcentajeLbl";
            porcentajeLbl.Size = new Size(0, 15);
            porcentajeLbl.TabIndex = 14;
            // 
            // datosSave
            // 
            datosSave.Location = new Point(220, 209);
            datosSave.Name = "datosSave";
            datosSave.Size = new Size(99, 23);
            datosSave.TabIndex = 15;
            datosSave.Text = "Guardar Datos";
            datosSave.UseVisualStyleBackColor = true;
            datosSave.Click += datosSave_Click;
            // 
            // cargarDatos
            // 
            cargarDatos.Location = new Point(220, 180);
            cargarDatos.Name = "cargarDatos";
            cargarDatos.Size = new Size(99, 23);
            cargarDatos.TabIndex = 16;
            cargarDatos.Text = "Cargar Datos";
            cargarDatos.UseVisualStyleBackColor = true;
            cargarDatos.Click += cargarDatos_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            button1.Location = new Point(12, 160);
            button1.Name = "button1";
            button1.Size = new Size(134, 23);
            button1.TabIndex = 17;
            button1.Text = "Cargar Preprocesado";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // allBut
            // 
            allBut.Location = new Point(12, 12);
            allBut.Name = "allBut";
            allBut.Size = new Size(134, 23);
            allBut.TabIndex = 18;
            allBut.Text = "Simular las 256 reglas";
            allBut.UseVisualStyleBackColor = true;
            allBut.Click += allBut_Click;
            // 
            // grafics
            // 
            grafics.Location = new Point(325, 84);
            grafics.Name = "grafics";
            grafics.Size = new Size(123, 23);
            grafics.TabIndex = 19;
            grafics.Text = "Ver Graficas";
            grafics.UseVisualStyleBackColor = true;
            grafics.Click += grafics_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 273);
            Controls.Add(grafics);
            Controls.Add(allBut);
            Controls.Add(button1);
            Controls.Add(cargarDatos);
            Controls.Add(datosSave);
            Controls.Add(porcentajeLbl);
            Controls.Add(hScrollBar1);
            Controls.Add(cadenosa);
            Controls.Add(cadenaLbl);
            Controls.Add(largoCadena);
            Controls.Add(dibujarCadena);
            Controls.Add(tamanoCanvas);
            Controls.Add(label3);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(colorButton);
            Controls.Add(regla);
            Controls.Add(insertarCadena);
            Controls.Add(canvas);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
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
        private Button datosSave;
        private Button cargarDatos;
        private OpenFileDialog openFileDialog1;
        private Button button1;
        private Button allBut;
        private Button grafics;
    }
}