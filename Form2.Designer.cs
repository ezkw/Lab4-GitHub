namespace GitHubLab4
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblText = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // lblText
            //
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblText.Location = new System.Drawing.Point(77, 44);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(207, 20);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Это вторая форма проекта";
            //
            // btnBack
            //
            this.btnBack.Location = new System.Drawing.Point(113, 92);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(135, 35);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Закрыть";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            //
            // Form2
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 160);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblText);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Вторая форма";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
