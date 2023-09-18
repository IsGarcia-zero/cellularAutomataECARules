namespace Regla30.App
{
    partial class DibujarCadena
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
            this.daleGo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1500, 400);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // daleGo
            // 
            this.daleGo.Location = new System.Drawing.Point(1435, 426);
            this.daleGo.Name = "daleGo";
            this.daleGo.Size = new System.Drawing.Size(75, 23);
            this.daleGo.TabIndex = 1;
            this.daleGo.Text = "Calcular";
            this.daleGo.UseVisualStyleBackColor = true;
            this.daleGo.Click += new System.EventHandler(this.daleGo_Click);
            // 
            // DibujarCadena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 461);
            this.Controls.Add(this.daleGo);
            this.Controls.Add(this.panel1);
            this.Name = "DibujarCadena";
            this.Text = "DibujarCadena";
            this.Load += new System.EventHandler(this.DibujarCadena_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button daleGo;
    }
}