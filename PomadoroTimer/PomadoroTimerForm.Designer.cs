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
            this.TbBreakTime = new System.Windows.Forms.TextBox();
            this.BtnStartPom = new System.Windows.Forms.Button();
            this.TbPomTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnStartBreak
            // 
            this.BtnStartBreak.Location = new System.Drawing.Point(75, 156);
            this.BtnStartBreak.Name = "BtnStartBreak";
            this.BtnStartBreak.Size = new System.Drawing.Size(100, 50);
            this.BtnStartBreak.TabIndex = 1;
            this.BtnStartBreak.Text = "Start Break";
            this.BtnStartBreak.UseVisualStyleBackColor = true;
            this.BtnStartBreak.Click += new System.EventHandler(this.BtnStartBreak_Click);
            // 
            // TbBreakTime
            // 
            this.TbBreakTime.Location = new System.Drawing.Point(75, 127);
            this.TbBreakTime.Name = "TbBreakTime";
            this.TbBreakTime.ReadOnly = true;
            this.TbBreakTime.Size = new System.Drawing.Size(100, 23);
            this.TbBreakTime.TabIndex = 4;
            this.TbBreakTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnStartPom
            // 
            this.BtnStartPom.Location = new System.Drawing.Point(75, 56);
            this.BtnStartPom.Name = "BtnStartPom";
            this.BtnStartPom.Size = new System.Drawing.Size(100, 50);
            this.BtnStartPom.TabIndex = 1;
            this.BtnStartPom.Text = "Start Pomadoro";
            this.BtnStartPom.UseVisualStyleBackColor = true;
            this.BtnStartPom.Click += new System.EventHandler(this.BtnStartPom_Click);
            // 
            // TbPomTime
            // 
            this.TbPomTime.Location = new System.Drawing.Point(75, 27);
            this.TbPomTime.Name = "TbPomTime";
            this.TbPomTime.ReadOnly = true;
            this.TbPomTime.Size = new System.Drawing.Size(100, 23);
            this.TbPomTime.TabIndex = 4;
            this.TbPomTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PomadoroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 227);
            this.Controls.Add(this.TbPomTime);
            this.Controls.Add(this.BtnStartPom);
            this.Controls.Add(this.TbBreakTime);
            this.Controls.Add(this.BtnStartBreak);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(264, 266);
            this.MinimumSize = new System.Drawing.Size(264, 266);
            this.Name = "PomadoroForm";
            this.Text = "Pomadoro Timer";
            this.Load += new System.EventHandler(this.PomadoroForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnStartBreak;
        private System.Windows.Forms.TextBox TbBreakTime;
        private System.Windows.Forms.Button BtnStartPom;
        private System.Windows.Forms.TextBox TbPomTime;
    }
}

