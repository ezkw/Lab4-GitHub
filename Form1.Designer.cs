namespace GitHubLab4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnOpenForm2;
        private System.Windows.Forms.Button btnAuth;
        private System.Windows.Forms.Button btnTest;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnOpenForm2 = new System.Windows.Forms.Button();
            this.btnAuth = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // lblTitle
            //
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblTitle.Location = new System.Drawing.Point(72, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(243, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Практическая работа GitHub";
            //
            // btnOpenForm2
            //
            this.btnOpenForm2.Location = new System.Drawing.Point(92, 78);
            this.btnOpenForm2.Name = "btnOpenForm2";
            this.btnOpenForm2.Size = new System.Drawing.Size(200, 36);
            this.btnOpenForm2.TabIndex = 1;
            this.btnOpenForm2.Text = "Открыть вторую форму";
            this.btnOpenForm2.UseVisualStyleBackColor = true;
            this.btnOpenForm2.Click += new System.EventHandler(this.btnOpenForm2_Click);
            //
            // btnAuth
            //
            this.btnAuth.Location = new System.Drawing.Point(92, 125);
            this.btnAuth.Name = "btnAuth";
            this.btnAuth.Size = new System.Drawing.Size(200, 36);
            this.btnAuth.TabIndex = 2;
            this.btnAuth.Text = "Авторизация";
            this.btnAuth.UseVisualStyleBackColor = true;
            this.btnAuth.Click += new System.EventHandler(this.btnAuth_Click);
            //
            // btnTest
            //
            this.btnTest.Location = new System.Drawing.Point(92, 172);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(200, 36);
            this.btnTest.TabIndex = 3;
            this.btnTest.Text = "Проверить функцию";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 245);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnAuth);
            this.Controls.Add(this.btnOpenForm2);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GitHub Lab 4";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
