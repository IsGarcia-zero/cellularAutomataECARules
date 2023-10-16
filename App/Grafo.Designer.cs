namespace Regla30.App
{
    partial class Grafo
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
            graffo = new Button();
            SuspendLayout();
            // 
            // graffo
            // 
            graffo.Location = new Point(699, 22);
            graffo.Name = "graffo";
            graffo.Size = new Size(89, 25);
            graffo.TabIndex = 1;
            graffo.Text = "Dibujar Gra";
            graffo.UseVisualStyleBackColor = true;
            graffo.Click += graffo_Click;
            // 
            // Grafo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(graffo);
            Name = "Grafo";
            Text = "Grafo";
            ResumeLayout(false);
        }

        #endregion
        private Button graffo;
    }
}