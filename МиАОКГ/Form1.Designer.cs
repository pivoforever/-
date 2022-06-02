
namespace МиАОКГ
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelSpecialDrawing = new System.Windows.Forms.Label();
            this.labelComplexDrawing = new System.Windows.Forms.Label();
            this.trackBarGamma = new System.Windows.Forms.TrackBar();
            this.trackBarBeta = new System.Windows.Forms.TrackBar();
            this.trackBarAlfa = new System.Windows.Forms.TrackBar();
            this.trackBarZ = new System.Windows.Forms.TrackBar();
            this.trackBarY = new System.Windows.Forms.TrackBar();
            this.trackBarX = new System.Windows.Forms.TrackBar();
            this.labelGamma = new System.Windows.Forms.Label();
            this.labelBeta = new System.Windows.Forms.Label();
            this.labelAlfa = new System.Windows.Forms.Label();
            this.labelZ = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.labelMinX = new System.Windows.Forms.Label();
            this.labelZeroX = new System.Windows.Forms.Label();
            this.labelMaxX = new System.Windows.Forms.Label();
            this.labelMinY = new System.Windows.Forms.Label();
            this.labelZeroY = new System.Windows.Forms.Label();
            this.labelMaxY = new System.Windows.Forms.Label();
            this.labelMinAlfa = new System.Windows.Forms.Label();
            this.labelMaxZ = new System.Windows.Forms.Label();
            this.labelMinZ = new System.Windows.Forms.Label();
            this.labelZeroZ = new System.Windows.Forms.Label();
            this.labelMaxAlfa = new System.Windows.Forms.Label();
            this.labelMaxBeta = new System.Windows.Forms.Label();
            this.labelMaxGamma = new System.Windows.Forms.Label();
            this.labelMinBeta = new System.Windows.Forms.Label();
            this.labelMinGamma = new System.Windows.Forms.Label();
            this.CurValueAlfa = new System.Windows.Forms.Label();
            this.CurValueZ = new System.Windows.Forms.Label();
            this.CurValueX = new System.Windows.Forms.Label();
            this.CurValueY = new System.Windows.Forms.Label();
            this.CurValueGamma = new System.Windows.Forms.Label();
            this.CurValueBeta = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label0 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGamma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAlfa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarX)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(36, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 274);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(538, 45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(370, 274);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox2_Paint);
            // 
            // labelSpecialDrawing
            // 
            this.labelSpecialDrawing.AutoSize = true;
            this.labelSpecialDrawing.Location = new System.Drawing.Point(119, 27);
            this.labelSpecialDrawing.Name = "labelSpecialDrawing";
            this.labelSpecialDrawing.Size = new System.Drawing.Size(157, 15);
            this.labelSpecialDrawing.TabIndex = 2;
            this.labelSpecialDrawing.Text = "Пространственный чертеж";
            // 
            // labelComplexDrawing
            // 
            this.labelComplexDrawing.AutoSize = true;
            this.labelComplexDrawing.Location = new System.Drawing.Point(666, 27);
            this.labelComplexDrawing.Name = "labelComplexDrawing";
            this.labelComplexDrawing.Size = new System.Drawing.Size(128, 15);
            this.labelComplexDrawing.TabIndex = 3;
            this.labelComplexDrawing.Text = "Комплексный чертеж";
            // 
            // trackBarGamma
            // 
            this.trackBarGamma.Location = new System.Drawing.Point(538, 427);
            this.trackBarGamma.Maximum = 360;
            this.trackBarGamma.Name = "trackBarGamma";
            this.trackBarGamma.Size = new System.Drawing.Size(285, 45);
            this.trackBarGamma.TabIndex = 4;
            this.trackBarGamma.Scroll += new System.EventHandler(this.trackBarGamma_Scroll);
            // 
            // trackBarBeta
            // 
            this.trackBarBeta.Location = new System.Drawing.Point(538, 376);
            this.trackBarBeta.Maximum = 360;
            this.trackBarBeta.Name = "trackBarBeta";
            this.trackBarBeta.Size = new System.Drawing.Size(285, 45);
            this.trackBarBeta.TabIndex = 5;
            this.trackBarBeta.Scroll += new System.EventHandler(this.trackBarBeta_Scroll);
            // 
            // trackBarAlfa
            // 
            this.trackBarAlfa.Location = new System.Drawing.Point(538, 325);
            this.trackBarAlfa.Maximum = 360;
            this.trackBarAlfa.Name = "trackBarAlfa";
            this.trackBarAlfa.Size = new System.Drawing.Size(285, 45);
            this.trackBarAlfa.TabIndex = 6;
            this.trackBarAlfa.Scroll += new System.EventHandler(this.trackBarAlfa_Scroll);
            // 
            // trackBarZ
            // 
            this.trackBarZ.Location = new System.Drawing.Point(36, 427);
            this.trackBarZ.Maximum = 60;
            this.trackBarZ.Minimum = -60;
            this.trackBarZ.Name = "trackBarZ";
            this.trackBarZ.Size = new System.Drawing.Size(285, 45);
            this.trackBarZ.TabIndex = 7;
            this.trackBarZ.Scroll += new System.EventHandler(this.trackBarZ_Scroll);
            // 
            // trackBarY
            // 
            this.trackBarY.Location = new System.Drawing.Point(36, 376);
            this.trackBarY.Maximum = 60;
            this.trackBarY.Minimum = -60;
            this.trackBarY.Name = "trackBarY";
            this.trackBarY.Size = new System.Drawing.Size(285, 45);
            this.trackBarY.TabIndex = 8;
            this.trackBarY.Scroll += new System.EventHandler(this.trackBarY_Scroll);
            // 
            // trackBarX
            // 
            this.trackBarX.Cursor = System.Windows.Forms.Cursors.Default;
            this.trackBarX.Location = new System.Drawing.Point(36, 325);
            this.trackBarX.Maximum = 60;
            this.trackBarX.Minimum = -60;
            this.trackBarX.Name = "trackBarX";
            this.trackBarX.Size = new System.Drawing.Size(285, 45);
            this.trackBarX.TabIndex = 9;
            this.trackBarX.Scroll += new System.EventHandler(this.trackBarX_Scroll);
            // 
            // labelGamma
            // 
            this.labelGamma.AutoSize = true;
            this.labelGamma.Location = new System.Drawing.Point(518, 427);
            this.labelGamma.Name = "labelGamma";
            this.labelGamma.Size = new System.Drawing.Size(13, 15);
            this.labelGamma.TabIndex = 10;
            this.labelGamma.Text = "γ";
            // 
            // labelBeta
            // 
            this.labelBeta.AutoSize = true;
            this.labelBeta.Location = new System.Drawing.Point(518, 376);
            this.labelBeta.Name = "labelBeta";
            this.labelBeta.Size = new System.Drawing.Size(14, 15);
            this.labelBeta.TabIndex = 11;
            this.labelBeta.Text = "β";
            // 
            // labelAlfa
            // 
            this.labelAlfa.AutoSize = true;
            this.labelAlfa.Location = new System.Drawing.Point(518, 325);
            this.labelAlfa.Name = "labelAlfa";
            this.labelAlfa.Size = new System.Drawing.Size(14, 15);
            this.labelAlfa.TabIndex = 12;
            this.labelAlfa.Text = "α";
            // 
            // labelZ
            // 
            this.labelZ.AutoSize = true;
            this.labelZ.Location = new System.Drawing.Point(16, 427);
            this.labelZ.Name = "labelZ";
            this.labelZ.Size = new System.Drawing.Size(14, 15);
            this.labelZ.TabIndex = 13;
            this.labelZ.Text = "Z";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(16, 376);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(14, 15);
            this.labelY.TabIndex = 14;
            this.labelY.Text = "Y";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(16, 325);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(14, 15);
            this.labelX.TabIndex = 15;
            this.labelX.Text = "X";
            // 
            // labelMinX
            // 
            this.labelMinX.AutoSize = true;
            this.labelMinX.Location = new System.Drawing.Point(36, 355);
            this.labelMinX.Name = "labelMinX";
            this.labelMinX.Size = new System.Drawing.Size(24, 15);
            this.labelMinX.TabIndex = 16;
            this.labelMinX.Text = "-60";
            // 
            // labelZeroX
            // 
            this.labelZeroX.AutoSize = true;
            this.labelZeroX.Location = new System.Drawing.Point(172, 358);
            this.labelZeroX.Name = "labelZeroX";
            this.labelZeroX.Size = new System.Drawing.Size(13, 15);
            this.labelZeroX.TabIndex = 17;
            this.labelZeroX.Text = "0";
            // 
            // labelMaxX
            // 
            this.labelMaxX.AutoSize = true;
            this.labelMaxX.Location = new System.Drawing.Point(302, 355);
            this.labelMaxX.Name = "labelMaxX";
            this.labelMaxX.Size = new System.Drawing.Size(19, 15);
            this.labelMaxX.TabIndex = 18;
            this.labelMaxX.Text = "60";
            // 
            // labelMinY
            // 
            this.labelMinY.AutoSize = true;
            this.labelMinY.Location = new System.Drawing.Point(36, 406);
            this.labelMinY.Name = "labelMinY";
            this.labelMinY.Size = new System.Drawing.Size(24, 15);
            this.labelMinY.TabIndex = 19;
            this.labelMinY.Text = "-60";
            // 
            // labelZeroY
            // 
            this.labelZeroY.AutoSize = true;
            this.labelZeroY.Location = new System.Drawing.Point(172, 406);
            this.labelZeroY.Name = "labelZeroY";
            this.labelZeroY.Size = new System.Drawing.Size(13, 15);
            this.labelZeroY.TabIndex = 20;
            this.labelZeroY.Text = "0";
            // 
            // labelMaxY
            // 
            this.labelMaxY.AutoSize = true;
            this.labelMaxY.Location = new System.Drawing.Point(302, 406);
            this.labelMaxY.Name = "labelMaxY";
            this.labelMaxY.Size = new System.Drawing.Size(19, 15);
            this.labelMaxY.TabIndex = 21;
            this.labelMaxY.Text = "60";
            // 
            // labelMinAlfa
            // 
            this.labelMinAlfa.AutoSize = true;
            this.labelMinAlfa.Location = new System.Drawing.Point(538, 355);
            this.labelMinAlfa.Name = "labelMinAlfa";
            this.labelMinAlfa.Size = new System.Drawing.Size(13, 15);
            this.labelMinAlfa.TabIndex = 22;
            this.labelMinAlfa.Text = "0";
            // 
            // labelMaxZ
            // 
            this.labelMaxZ.AutoSize = true;
            this.labelMaxZ.Location = new System.Drawing.Point(302, 457);
            this.labelMaxZ.Name = "labelMaxZ";
            this.labelMaxZ.Size = new System.Drawing.Size(19, 15);
            this.labelMaxZ.TabIndex = 23;
            this.labelMaxZ.Text = "60";
            // 
            // labelMinZ
            // 
            this.labelMinZ.AutoSize = true;
            this.labelMinZ.Location = new System.Drawing.Point(36, 457);
            this.labelMinZ.Name = "labelMinZ";
            this.labelMinZ.Size = new System.Drawing.Size(24, 15);
            this.labelMinZ.TabIndex = 24;
            this.labelMinZ.Text = "-60";
            // 
            // labelZeroZ
            // 
            this.labelZeroZ.AutoSize = true;
            this.labelZeroZ.Location = new System.Drawing.Point(172, 457);
            this.labelZeroZ.Name = "labelZeroZ";
            this.labelZeroZ.Size = new System.Drawing.Size(13, 15);
            this.labelZeroZ.TabIndex = 25;
            this.labelZeroZ.Text = "0";
            // 
            // labelMaxAlfa
            // 
            this.labelMaxAlfa.AutoSize = true;
            this.labelMaxAlfa.Location = new System.Drawing.Point(808, 355);
            this.labelMaxAlfa.Name = "labelMaxAlfa";
            this.labelMaxAlfa.Size = new System.Drawing.Size(25, 15);
            this.labelMaxAlfa.TabIndex = 26;
            this.labelMaxAlfa.Text = "360";
            // 
            // labelMaxBeta
            // 
            this.labelMaxBeta.AutoSize = true;
            this.labelMaxBeta.Location = new System.Drawing.Point(808, 406);
            this.labelMaxBeta.Name = "labelMaxBeta";
            this.labelMaxBeta.Size = new System.Drawing.Size(25, 15);
            this.labelMaxBeta.TabIndex = 27;
            this.labelMaxBeta.Text = "360";
            // 
            // labelMaxGamma
            // 
            this.labelMaxGamma.AutoSize = true;
            this.labelMaxGamma.Location = new System.Drawing.Point(808, 457);
            this.labelMaxGamma.Name = "labelMaxGamma";
            this.labelMaxGamma.Size = new System.Drawing.Size(25, 15);
            this.labelMaxGamma.TabIndex = 28;
            this.labelMaxGamma.Text = "360";
            // 
            // labelMinBeta
            // 
            this.labelMinBeta.AutoSize = true;
            this.labelMinBeta.Location = new System.Drawing.Point(538, 406);
            this.labelMinBeta.Name = "labelMinBeta";
            this.labelMinBeta.Size = new System.Drawing.Size(13, 15);
            this.labelMinBeta.TabIndex = 29;
            this.labelMinBeta.Text = "0";
            // 
            // labelMinGamma
            // 
            this.labelMinGamma.AutoSize = true;
            this.labelMinGamma.Location = new System.Drawing.Point(538, 457);
            this.labelMinGamma.Name = "labelMinGamma";
            this.labelMinGamma.Size = new System.Drawing.Size(13, 15);
            this.labelMinGamma.TabIndex = 30;
            this.labelMinGamma.Text = "0";
            // 
            // CurValueAlfa
            // 
            this.CurValueAlfa.AutoSize = true;
            this.CurValueAlfa.Location = new System.Drawing.Point(829, 325);
            this.CurValueAlfa.Name = "CurValueAlfa";
            this.CurValueAlfa.Size = new System.Drawing.Size(130, 15);
            this.CurValueAlfa.TabIndex = 31;
            this.CurValueAlfa.Text = "Текущее значение α =";
            // 
            // CurValueZ
            // 
            this.CurValueZ.AutoSize = true;
            this.CurValueZ.Location = new System.Drawing.Point(327, 427);
            this.CurValueZ.Name = "CurValueZ";
            this.CurValueZ.Size = new System.Drawing.Size(130, 15);
            this.CurValueZ.TabIndex = 32;
            this.CurValueZ.Text = "Текущее значение Z =";
            // 
            // CurValueX
            // 
            this.CurValueX.AutoSize = true;
            this.CurValueX.Location = new System.Drawing.Point(327, 325);
            this.CurValueX.Name = "CurValueX";
            this.CurValueX.Size = new System.Drawing.Size(130, 15);
            this.CurValueX.TabIndex = 33;
            this.CurValueX.Text = "Текущее значение X =";
            // 
            // CurValueY
            // 
            this.CurValueY.AutoSize = true;
            this.CurValueY.Location = new System.Drawing.Point(327, 376);
            this.CurValueY.Name = "CurValueY";
            this.CurValueY.Size = new System.Drawing.Size(130, 15);
            this.CurValueY.TabIndex = 34;
            this.CurValueY.Text = "Текущее значение Y =";
            // 
            // CurValueGamma
            // 
            this.CurValueGamma.AutoSize = true;
            this.CurValueGamma.Location = new System.Drawing.Point(829, 427);
            this.CurValueGamma.Name = "CurValueGamma";
            this.CurValueGamma.Size = new System.Drawing.Size(132, 15);
            this.CurValueGamma.TabIndex = 35;
            this.CurValueGamma.Text = "Текущее значение γ = ";
            // 
            // CurValueBeta
            // 
            this.CurValueBeta.AutoSize = true;
            this.CurValueBeta.Location = new System.Drawing.Point(829, 376);
            this.CurValueBeta.Name = "CurValueBeta";
            this.CurValueBeta.Size = new System.Drawing.Size(130, 15);
            this.CurValueBeta.TabIndex = 36;
            this.CurValueBeta.Text = "Текущее значение β =";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(425, 472);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(89, 41);
            this.buttonExit.TabIndex = 37;
            this.buttonExit.Text = "Выйти из программы";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Location = new System.Drawing.Point(418, 107);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(0, 15);
            this.label0.TabIndex = 38;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 544);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.CurValueBeta);
            this.Controls.Add(this.CurValueGamma);
            this.Controls.Add(this.CurValueY);
            this.Controls.Add(this.CurValueX);
            this.Controls.Add(this.CurValueZ);
            this.Controls.Add(this.CurValueAlfa);
            this.Controls.Add(this.labelMinGamma);
            this.Controls.Add(this.labelMinBeta);
            this.Controls.Add(this.labelMaxGamma);
            this.Controls.Add(this.labelMaxBeta);
            this.Controls.Add(this.labelMaxAlfa);
            this.Controls.Add(this.labelZeroZ);
            this.Controls.Add(this.labelMinZ);
            this.Controls.Add(this.labelMaxZ);
            this.Controls.Add(this.labelMinAlfa);
            this.Controls.Add(this.labelMaxY);
            this.Controls.Add(this.labelZeroY);
            this.Controls.Add(this.labelMinY);
            this.Controls.Add(this.labelMaxX);
            this.Controls.Add(this.labelZeroX);
            this.Controls.Add(this.labelMinX);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelZ);
            this.Controls.Add(this.labelAlfa);
            this.Controls.Add(this.labelBeta);
            this.Controls.Add(this.labelGamma);
            this.Controls.Add(this.trackBarX);
            this.Controls.Add(this.trackBarY);
            this.Controls.Add(this.trackBarZ);
            this.Controls.Add(this.trackBarAlfa);
            this.Controls.Add(this.trackBarBeta);
            this.Controls.Add(this.trackBarGamma);
            this.Controls.Add(this.labelComplexDrawing);
            this.Controls.Add(this.labelSpecialDrawing);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGamma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAlfa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelSpecialDrawing;
        private System.Windows.Forms.Label labelComplexDrawing;
        private System.Windows.Forms.TrackBar trackBarGamma;
        private System.Windows.Forms.TrackBar trackBarBeta;
        private System.Windows.Forms.TrackBar trackBarAlfa;
        private System.Windows.Forms.TrackBar trackBarZ;
        private System.Windows.Forms.TrackBar trackBarY;
        private System.Windows.Forms.TrackBar trackBarX;
        private System.Windows.Forms.Label labelGamma;
        private System.Windows.Forms.Label labelBeta;
        private System.Windows.Forms.Label labelAlfa;
        private System.Windows.Forms.Label labelZ;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelMinX;
        private System.Windows.Forms.Label labelZeroX;
        private System.Windows.Forms.Label labelMaxX;
        private System.Windows.Forms.Label labelMinY;
        private System.Windows.Forms.Label labelZeroY;
        private System.Windows.Forms.Label labelMaxY;
        private System.Windows.Forms.Label labelMinAlfa;
        private System.Windows.Forms.Label labelMaxZ;
        private System.Windows.Forms.Label labelMinZ;
        private System.Windows.Forms.Label labelZeroZ;
        private System.Windows.Forms.Label labelMaxAlfa;
        private System.Windows.Forms.Label labelMaxBeta;
        private System.Windows.Forms.Label labelMaxGamma;
        private System.Windows.Forms.Label labelMinBeta;
        private System.Windows.Forms.Label labelMinGamma;
        private System.Windows.Forms.Label CurValueAlfa;
        private System.Windows.Forms.Label CurValueZ;
        private System.Windows.Forms.Label CurValueX;
        private System.Windows.Forms.Label CurValueY;
        private System.Windows.Forms.Label CurValueGamma;
        private System.Windows.Forms.Label CurValueBeta;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label0;
    }
}

