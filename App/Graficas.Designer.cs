namespace Regla30.App
{
    partial class Graficas
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
            cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            pictureBox1 = new PictureBox();
            butUnos = new Button();
            butLog = new Button();
            butShan = new Button();
            sveGrafc = new Button();
            svAll = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cartesianChart1
            // 
            cartesianChart1.Location = new Point(12, 12);
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(799, 530);
            cartesianChart1.TabIndex = 0;
            cartesianChart1.Load += cartesianChart1_Load;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(799, 530);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // butUnos
            // 
            butUnos.Location = new Point(876, 41);
            butUnos.Name = "butUnos";
            butUnos.Size = new Size(128, 23);
            butUnos.TabIndex = 2;
            butUnos.Text = "Densidad de Unos";
            butUnos.UseVisualStyleBackColor = true;
            butUnos.Click += butUnos_Click;
            // 
            // butLog
            // 
            butLog.Location = new Point(876, 70);
            butLog.Name = "butLog";
            butLog.Size = new Size(128, 23);
            butLog.TabIndex = 3;
            butLog.Text = "Densidad Log";
            butLog.UseVisualStyleBackColor = true;
            butLog.Click += butLog_Click;
            // 
            // butShan
            // 
            butShan.Location = new Point(876, 99);
            butShan.Name = "butShan";
            butShan.Size = new Size(128, 23);
            butShan.TabIndex = 4;
            butShan.Text = "Entriopia de Shanon";
            butShan.UseVisualStyleBackColor = true;
            butShan.Click += butShan_Click;
            // 
            // sveGrafc
            // 
            sveGrafc.Location = new Point(876, 128);
            sveGrafc.Name = "sveGrafc";
            sveGrafc.Size = new Size(128, 23);
            sveGrafc.TabIndex = 5;
            sveGrafc.Text = "Guardar Grafica";
            sveGrafc.UseVisualStyleBackColor = true;
            sveGrafc.Click += sveGrafc_Click;
            // 
            // svAll
            // 
            svAll.Location = new Point(876, 157);
            svAll.Name = "svAll";
            svAll.Size = new Size(128, 23);
            svAll.TabIndex = 6;
            svAll.Text = "Guardar Todas";
            svAll.UseVisualStyleBackColor = true;
            svAll.Click += svAll_Click;
            // 
            // Graficas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 554);
            Controls.Add(svAll);
            Controls.Add(sveGrafc);
            Controls.Add(butShan);
            Controls.Add(butLog);
            Controls.Add(butUnos);
            Controls.Add(cartesianChart1);
            Controls.Add(pictureBox1);
            Name = "Graficas";
            Text = "Graficas";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
        private PictureBox pictureBox1;
        private Button butUnos;
        private Button butLog;
        private Button butShan;
        private Button sveGrafc;
        private Button svAll;
    }
}