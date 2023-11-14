namespace Parti_Secim_Grafik_İstatistik
{
    partial class FrmGrafikler
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.groupBoxGrafikler = new System.Windows.Forms.GroupBox();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.groupBoxİlceDegerleri = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBoxİlceSecim = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.progressBar2 = new System.Windows.Forms.ProgressBar();
			this.progressBar3 = new System.Windows.Forms.ProgressBar();
			this.progressBar4 = new System.Windows.Forms.ProgressBar();
			this.progressBar5 = new System.Windows.Forms.ProgressBar();
			this.labelA = new System.Windows.Forms.Label();
			this.labelB = new System.Windows.Forms.Label();
			this.labelC = new System.Windows.Forms.Label();
			this.labelD = new System.Windows.Forms.Label();
			this.labelE = new System.Windows.Forms.Label();
			this.groupBoxGrafikler.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.groupBoxİlceDegerleri.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxGrafikler
			// 
			this.groupBoxGrafikler.Controls.Add(this.chart1);
			this.groupBoxGrafikler.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBoxGrafikler.Location = new System.Drawing.Point(3, 10);
			this.groupBoxGrafikler.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
			this.groupBoxGrafikler.Name = "groupBoxGrafikler";
			this.groupBoxGrafikler.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
			this.groupBoxGrafikler.Size = new System.Drawing.Size(822, 286);
			this.groupBoxGrafikler.TabIndex = 0;
			this.groupBoxGrafikler.TabStop = false;
			this.groupBoxGrafikler.Text = "GRAFİKLER";
			// 
			// chart1
			// 
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
			legend1.Name = "Legend1";
			this.chart1.Legends.Add(legend1);
			this.chart1.Location = new System.Drawing.Point(2, 18);
			this.chart1.Name = "chart1";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Partiler";
			this.chart1.Series.Add(series1);
			this.chart1.Size = new System.Drawing.Size(818, 267);
			this.chart1.TabIndex = 0;
			this.chart1.Text = "chart1";
			// 
			// groupBoxİlceDegerleri
			// 
			this.groupBoxİlceDegerleri.Controls.Add(this.labelE);
			this.groupBoxİlceDegerleri.Controls.Add(this.labelD);
			this.groupBoxİlceDegerleri.Controls.Add(this.labelC);
			this.groupBoxİlceDegerleri.Controls.Add(this.labelB);
			this.groupBoxİlceDegerleri.Controls.Add(this.labelA);
			this.groupBoxİlceDegerleri.Controls.Add(this.progressBar5);
			this.groupBoxİlceDegerleri.Controls.Add(this.progressBar4);
			this.groupBoxİlceDegerleri.Controls.Add(this.progressBar3);
			this.groupBoxİlceDegerleri.Controls.Add(this.progressBar2);
			this.groupBoxİlceDegerleri.Controls.Add(this.label6);
			this.groupBoxİlceDegerleri.Controls.Add(this.label5);
			this.groupBoxİlceDegerleri.Controls.Add(this.label4);
			this.groupBoxİlceDegerleri.Controls.Add(this.label3);
			this.groupBoxİlceDegerleri.Controls.Add(this.progressBar1);
			this.groupBoxİlceDegerleri.Controls.Add(this.label2);
			this.groupBoxİlceDegerleri.Controls.Add(this.comboBoxİlceSecim);
			this.groupBoxİlceDegerleri.Controls.Add(this.label1);
			this.groupBoxİlceDegerleri.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBoxİlceDegerleri.Location = new System.Drawing.Point(12, 320);
			this.groupBoxİlceDegerleri.Name = "groupBoxİlceDegerleri";
			this.groupBoxİlceDegerleri.Size = new System.Drawing.Size(813, 415);
			this.groupBoxİlceDegerleri.TabIndex = 1;
			this.groupBoxİlceDegerleri.TabStop = false;
			this.groupBoxİlceDegerleri.Text = "İLÇE DEĞERLERİ";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(21, 322);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(69, 18);
			this.label6.TabIndex = 12;
			this.label6.Text = "E Partisi:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(21, 261);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(70, 18);
			this.label5.TabIndex = 10;
			this.label5.Text = "D Partisi:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(22, 196);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(69, 18);
			this.label4.TabIndex = 8;
			this.label4.Text = "C Partisi:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(22, 147);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(69, 18);
			this.label3.TabIndex = 6;
			this.label3.Text = "B Partisi:";
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(110, 87);
			this.progressBar1.Maximum = 200;
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(370, 36);
			this.progressBar1.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(22, 87);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 18);
			this.label2.TabIndex = 4;
			this.label2.Text = "A Partisi:";
			// 
			// comboBoxİlceSecim
			// 
			this.comboBoxİlceSecim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxİlceSecim.FormattingEnabled = true;
			this.comboBoxİlceSecim.Location = new System.Drawing.Point(110, 42);
			this.comboBoxİlceSecim.Name = "comboBoxİlceSecim";
			this.comboBoxİlceSecim.Size = new System.Drawing.Size(184, 26);
			this.comboBoxİlceSecim.TabIndex = 3;
			this.comboBoxİlceSecim.SelectedIndexChanged += new System.EventHandler(this.comboBoxİlceSecim_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 18);
			this.label1.TabIndex = 2;
			this.label1.Text = "İlçe Seçim:";
			// 
			// progressBar2
			// 
			this.progressBar2.Location = new System.Drawing.Point(110, 147);
			this.progressBar2.Maximum = 200;
			this.progressBar2.Name = "progressBar2";
			this.progressBar2.Size = new System.Drawing.Size(370, 36);
			this.progressBar2.TabIndex = 14;
			// 
			// progressBar3
			// 
			this.progressBar3.Location = new System.Drawing.Point(110, 196);
			this.progressBar3.Maximum = 200;
			this.progressBar3.Name = "progressBar3";
			this.progressBar3.Size = new System.Drawing.Size(370, 36);
			this.progressBar3.TabIndex = 15;
			// 
			// progressBar4
			// 
			this.progressBar4.Location = new System.Drawing.Point(110, 261);
			this.progressBar4.Maximum = 200;
			this.progressBar4.Name = "progressBar4";
			this.progressBar4.Size = new System.Drawing.Size(370, 36);
			this.progressBar4.TabIndex = 16;
			// 
			// progressBar5
			// 
			this.progressBar5.Location = new System.Drawing.Point(110, 322);
			this.progressBar5.Maximum = 200;
			this.progressBar5.Name = "progressBar5";
			this.progressBar5.Size = new System.Drawing.Size(370, 36);
			this.progressBar5.TabIndex = 17;
			// 
			// labelA
			// 
			this.labelA.AutoSize = true;
			this.labelA.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelA.Location = new System.Drawing.Point(505, 92);
			this.labelA.Name = "labelA";
			this.labelA.Size = new System.Drawing.Size(22, 24);
			this.labelA.TabIndex = 18;
			this.labelA.Text = "0";
			// 
			// labelB
			// 
			this.labelB.AutoSize = true;
			this.labelB.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelB.Location = new System.Drawing.Point(505, 159);
			this.labelB.Name = "labelB";
			this.labelB.Size = new System.Drawing.Size(22, 24);
			this.labelB.TabIndex = 19;
			this.labelB.Text = "0";
			// 
			// labelC
			// 
			this.labelC.AutoSize = true;
			this.labelC.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelC.Location = new System.Drawing.Point(505, 208);
			this.labelC.Name = "labelC";
			this.labelC.Size = new System.Drawing.Size(22, 24);
			this.labelC.TabIndex = 20;
			this.labelC.Text = "0";
			// 
			// labelD
			// 
			this.labelD.AutoSize = true;
			this.labelD.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelD.Location = new System.Drawing.Point(505, 273);
			this.labelD.Name = "labelD";
			this.labelD.Size = new System.Drawing.Size(22, 24);
			this.labelD.TabIndex = 21;
			this.labelD.Text = "0";
			// 
			// labelE
			// 
			this.labelE.AutoSize = true;
			this.labelE.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelE.Location = new System.Drawing.Point(505, 322);
			this.labelE.Name = "labelE";
			this.labelE.Size = new System.Drawing.Size(22, 24);
			this.labelE.TabIndex = 22;
			this.labelE.Text = "0";
			// 
			// FrmGrafikler
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(4F, 8F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.ClientSize = new System.Drawing.Size(914, 740);
			this.Controls.Add(this.groupBoxİlceDegerleri);
			this.Controls.Add(this.groupBoxGrafikler);
			this.Font = new System.Drawing.Font("Georgia", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FrmGrafikler";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "VTGS";
			this.Load += new System.EventHandler(this.FrmGrafikler_Load);
			this.groupBoxGrafikler.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.groupBoxİlceDegerleri.ResumeLayout(false);
			this.groupBoxİlceDegerleri.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxGrafikler;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBoxİlceDegerleri;
        private System.Windows.Forms.ComboBox comboBoxİlceSecim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labelE;
		private System.Windows.Forms.Label labelD;
		private System.Windows.Forms.Label labelC;
		private System.Windows.Forms.Label labelB;
		private System.Windows.Forms.Label labelA;
		private System.Windows.Forms.ProgressBar progressBar5;
		private System.Windows.Forms.ProgressBar progressBar4;
		private System.Windows.Forms.ProgressBar progressBar3;
		private System.Windows.Forms.ProgressBar progressBar2;
	}
}