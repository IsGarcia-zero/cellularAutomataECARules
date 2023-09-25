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
            panel1 = new Panel();
            daleGo = new Button();
            saveDat = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(1500, 400);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            panel1.MouseClick += panel1_MouseClick;
            // 
            // daleGo
            // 
            daleGo.Location = new Point(1435, 426);
            daleGo.Name = "daleGo";
            daleGo.Size = new Size(75, 23);
            daleGo.TabIndex = 1;
            daleGo.Text = "Calcular";
            daleGo.UseVisualStyleBackColor = true;
            daleGo.Click += daleGo_Click;
            // 
            // saveDat
            // 
            saveDat.Location = new Point(1325, 426);
            saveDat.Name = "saveDat";
            saveDat.Size = new Size(104, 23);
            saveDat.TabIndex = 2;
            saveDat.Text = "Guardar Datos";
            saveDat.UseVisualStyleBackColor = true;
            saveDat.Click += saveDat_Click;
            // 
            // DibujarCadena
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1584, 461);
            Controls.Add(saveDat);
            Controls.Add(daleGo);
            Controls.Add(panel1);
            Name = "DibujarCadena";
            Text = "DibujarCadena";
            Load += DibujarCadena_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button daleGo;
        private Button saveDat;
    }
}