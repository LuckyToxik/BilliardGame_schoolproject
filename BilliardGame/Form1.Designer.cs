namespace BilliardGame
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gamefield = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_x = new System.Windows.Forms.Label();
            this.label_y = new System.Windows.Forms.Label();
            this.textBox_dx = new System.Windows.Forms.TextBox();
            this.textBox_dx1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gamefield)).BeginInit();
            this.SuspendLayout();
            // 
            // gamefield
            // 
            this.gamefield.Location = new System.Drawing.Point(3, 12);
            this.gamefield.Name = "gamefield";
            this.gamefield.Size = new System.Drawing.Size(1280, 720);
            this.gamefield.TabIndex = 0;
            this.gamefield.TabStop = false;
            this.gamefield.Click += new System.EventHandler(this.gamefield_Click);
            this.gamefield.Paint += new System.Windows.Forms.PaintEventHandler(this.gamefield_Paint);
            this.gamefield.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gamefield_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(452, 740);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(544, 740);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y:";
            // 
            // label_x
            // 
            this.label_x.AutoSize = true;
            this.label_x.Location = new System.Drawing.Point(476, 740);
            this.label_x.Name = "label_x";
            this.label_x.Size = new System.Drawing.Size(35, 13);
            this.label_x.TabIndex = 3;
            this.label_x.Text = "label3";
            // 
            // label_y
            // 
            this.label_y.AutoSize = true;
            this.label_y.Location = new System.Drawing.Point(568, 739);
            this.label_y.Name = "label_y";
            this.label_y.Size = new System.Drawing.Size(35, 13);
            this.label_y.TabIndex = 4;
            this.label_y.Text = "label3";
            // 
            // textBox_dx
            // 
            this.textBox_dx.Location = new System.Drawing.Point(787, 740);
            this.textBox_dx.Name = "textBox_dx";
            this.textBox_dx.Size = new System.Drawing.Size(100, 20);
            this.textBox_dx.TabIndex = 5;
            // 
            // textBox_dx1
            // 
            this.textBox_dx1.Location = new System.Drawing.Point(1032, 740);
            this.textBox_dx1.Name = "textBox_dx1";
            this.textBox_dx1.Size = new System.Drawing.Size(100, 20);
            this.textBox_dx1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 762);
            this.Controls.Add(this.textBox_dx1);
            this.Controls.Add(this.textBox_dx);
            this.Controls.Add(this.label_y);
            this.Controls.Add(this.label_x);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gamefield);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gamefield)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.PictureBox gamefield;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_x;
        private System.Windows.Forms.Label label_y;
        private System.Windows.Forms.TextBox textBox_dx;
        private System.Windows.Forms.TextBox textBox_dx1;
    }
}

