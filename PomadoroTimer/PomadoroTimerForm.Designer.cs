namespace PomadoroTimer
{
    partial class PomadoroForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PomadoroForm));
            this.BtnStartBreak = new System.Windows.Forms.Button();
            this.BtnPauseBreak = new System.Windows.Forms.Button();
            this.TbBreakTime = new System.Windows.Forms.TextBox();
            this.BtnStartPom = new System.Windows.Forms.Button();
            this.BtnPausePom = new System.Windows.Forms.Button();
            this.TbPomTime = new System.Windows.Forms.TextBox();
            this.LblBreakTimer = new System.Windows.Forms.Label();
            this.LblPomTimer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnStartBreak
            // 
            this.BtnStartBreak.Location = new System.Drawing.Point(12, 192);
            this.BtnStartBreak.Name = "BtnStartBreak";
            this.BtnStartBreak.Size = new System.Drawing.Size(75, 23);
            this.BtnStartBreak.TabIndex = 1;
            this.BtnStartBreak.Text = "Start";
            this.BtnStartBreak.UseVisualStyleBackColor = true;
            // 
            // BtnPauseBreak
            // 
            this.BtnPauseBreak.Location = new System.Drawing.Point(161, 192);
            this.BtnPauseBreak.Name = "BtnPauseBreak";
            this.BtnPauseBreak.Size = new System.Drawing.Size(75, 23);
            this.BtnPauseBreak.TabIndex = 3;
            this.BtnPauseBreak.Text = "Pause";
            this.BtnPauseBreak.UseVisualStyleBackColor = true;
            // 
            // TbBreakTime
            // 
            this.TbBreakTime.Location = new System.Drawing.Point(75, 163);
            this.TbBreakTime.Name = "TbBreakTime";
            this.TbBreakTime.ReadOnly = true;
            this.TbBreakTime.Size = new System.Drawing.Size(100, 23);
            this.TbBreakTime.TabIndex = 4;
            this.TbBreakTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnStartPom
            // 
            this.BtnStartPom.Location = new System.Drawing.Point(12, 56);
            this.BtnStartPom.Name = "BtnStartPom";
            this.BtnStartPom.Size = new System.Drawing.Size(75, 23);
            this.BtnStartPom.TabIndex = 1;
            this.BtnStartPom.Text = "Start";
            this.BtnStartPom.UseVisualStyleBackColor = true;
            this.BtnStartPom.Click += new System.EventHandler(this.BtnStartPom_Click);
            // 
            // BtnPausePom
            // 
            this.BtnPausePom.Location = new System.Drawing.Point(161, 56);
            this.BtnPausePom.Name = "BtnPausePom";
            this.BtnPausePom.Size = new System.Drawing.Size(75, 23);
            this.BtnPausePom.TabIndex = 3;
            this.BtnPausePom.Text = "Pause";
            this.BtnPausePom.UseVisualStyleBackColor = true;
            // 
            // TbPomTime
            // 
            this.TbPomTime.Location = new System.Drawing.Point(75, 27);
            this.TbPomTime.Name = "TbPomTime";
            this.TbPomTime.Size = new System.Drawing.Size(100, 23);
            this.TbPomTime.TabIndex = 4;
            this.TbPomTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblBreakTimer
            // 
            this.LblBreakTimer.AutoSize = true;
            this.LblBreakTimer.Location = new System.Drawing.Point(90, 145);
            this.LblBreakTimer.Name = "LblBreakTimer";
            this.LblBreakTimer.Size = new System.Drawing.Size(69, 15);
            this.LblBreakTimer.TabIndex = 5;
            this.LblBreakTimer.Text = "Break Timer";
            // 
            // LblPomTimer
            // 
            this.LblPomTimer.AutoSize = true;
            this.LblPomTimer.Location = new System.Drawing.Point(79, 9);
            this.LblPomTimer.Name = "LblPomTimer";
            this.LblPomTimer.Size = new System.Drawing.Size(96, 15);
            this.LblPomTimer.TabIndex = 5;
            this.LblPomTimer.Text = "Pomadoro Timer";
            // 
            // PomadoroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 227);
            this.Controls.Add(this.LblPomTimer);
            this.Controls.Add(this.LblBreakTimer);
            this.Controls.Add(this.TbPomTime);
            this.Controls.Add(this.BtnPausePom);
            this.Controls.Add(this.BtnStartPom);
            this.Controls.Add(this.TbBreakTime);
            this.Controls.Add(this.BtnPauseBreak);
            this.Controls.Add(this.BtnStartBreak);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PomadoroForm";
            this.Text = "Pomadoro Timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnStartBreak;
        private System.Windows.Forms.Button BtnPauseBreak;
        private System.Windows.Forms.TextBox TbBreakTime;
        private System.Windows.Forms.Button BtnStartPom;
        private System.Windows.Forms.Button BtnPausePom;
        private System.Windows.Forms.Label LblBreakTimer;
        private System.Windows.Forms.Label LblPomTimer;
        private System.Windows.Forms.TextBox TbPomTime;
    }
}

