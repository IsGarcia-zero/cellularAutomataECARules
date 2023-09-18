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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dibujoAutomata = new System.Windows.Forms.PictureBox();
            this.btnColor1 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnColor2 = new System.Windows.Forms.Button();
            this.iniciar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dibujoAutomata)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.dibujoAutomata);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1001, 1001);
            this.panel1.TabIndex = 0;
            // 
            // dibujoAutomata
            // 
            this.dibujoAutomata.Location = new System.Drawing.Point(0, 0);
            this.dibujoAutomata.Name = "dibujoAutomata";
            this.dibujoAutomata.Size = new System.Drawing.Size(1001, 1001);
            this.dibujoAutomata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dibujoAutomata.TabIndex = 0;
            this.dibujoAutomata.TabStop = false;
            this.dibujoAutomata.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dibujoAutomata_MouseDown);
            this.dibujoAutomata.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dibujoAutomata_MouseMove);
            // 
            // btnColor1
            // 
            this.btnColor1.Location = new System.Drawing.Point(1040, 70);
            this.btnColor1.Name = "btnColor1";
            this.btnColor1.Size = new System.Drawing.Size(89, 23);
            this.btnColor1.TabIndex = 1;
            this.btnColor1.Text = "Color Fondo";
            this.btnColor1.UseVisualStyleBackColor = true;
            this.btnColor1.Click += new System.EventHandler(this.btnColor1_Click);
            // 
            // btnColor2
            // 
            this.btnColor2.Location = new System.Drawing.Point(1040, 41);
            this.btnColor2.Name = "btnColor2";
            this.btnColor2.Size = new System.Drawing.Size(84, 23);
            this.btnColor2.TabIndex = 2;
            this.btnColor2.Text = "Color celula";
            this.btnColor2.UseVisualStyleBackColor = true;
            this.btnColor2.Click += new System.EventHandler(this.btnColor2_Click);
            // 
            // iniciar
            // 
            this.iniciar.Location = new System.Drawing.Point(1040, 12);
            this.iniciar.Name = "iniciar";
            this.iniciar.Size = new System.Drawing.Size(84, 23);
            this.iniciar.TabIndex = 3;
            this.iniciar.Text = "Dibujar";
            this.iniciar.UseVisualStyleBackColor = true;
            this.iniciar.Click += new System.EventHandler(this.iniciar_Click);
            // 
            // Canvas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 1061);
            this.Controls.Add(this.iniciar);
            this.Controls.Add(this.btnColor2);
            this.Controls.Add(this.btnColor1);
            this.Controls.Add(this.panel1);
            this.Name = "Canvas";
            this.Text = "Canvas";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Canvas_KeyPress);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Canvas_PreviewKeyDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dibujoAutomata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox dibujoAutomata;
        private Button btnColor1;
        private ColorDialog colorDialog1;
        private Button btnColor2;
        private Button iniciar;
    }
}