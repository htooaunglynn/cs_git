namespace HelloWorldGUI
{
    partial class Form1
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
            this.btnSayHi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGoToLogin = new System.Windows.Forms.Button();
            this.btnGoToSimpleCalculatorUI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSayHi
            // 
            this.btnSayHi.Location = new System.Drawing.Point(191, 147);
            this.btnSayHi.Name = "btnSayHi";
            this.btnSayHi.Size = new System.Drawing.Size(111, 23);
            this.btnSayHi.TabIndex = 0;
            this.btnSayHi.Text = "Say Hello World";
            this.btnSayHi.UseVisualStyleBackColor = true;
            this.btnSayHi.Click += new System.EventHandler(this.btnSayHi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "This is Label.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnGoToLogin
            // 
            this.btnGoToLogin.Location = new System.Drawing.Point(337, 147);
            this.btnGoToLogin.Name = "btnGoToLogin";
            this.btnGoToLogin.Size = new System.Drawing.Size(75, 23);
            this.btnGoToLogin.TabIndex = 2;
            this.btnGoToLogin.Text = "Go To Login";
            this.btnGoToLogin.UseVisualStyleBackColor = true;
            this.btnGoToLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGoToSimpleCalculatorUI
            // 
            this.btnGoToSimpleCalculatorUI.Location = new System.Drawing.Point(92, 146);
            this.btnGoToSimpleCalculatorUI.Name = "btnGoToSimpleCalculatorUI";
            this.btnGoToSimpleCalculatorUI.Size = new System.Drawing.Size(75, 23);
            this.btnGoToSimpleCalculatorUI.TabIndex = 3;
            this.btnGoToSimpleCalculatorUI.Text = "Calculator";
            this.btnGoToSimpleCalculatorUI.UseVisualStyleBackColor = true;
            this.btnGoToSimpleCalculatorUI.Click += new System.EventHandler(this.btnGoToSimpleCalculatorUI_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 327);
            this.Controls.Add(this.btnGoToSimpleCalculatorUI);
            this.Controls.Add(this.btnGoToLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSayHi);
            this.Name = "Form1";
            this.Text = "Hello GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSayHi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGoToLogin;
        private System.Windows.Forms.Button btnGoToSimpleCalculatorUI;
    }
}

