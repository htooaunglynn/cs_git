namespace HelloWorldGUI
{
    partial class SimpleCalculatorUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFirstNumber = new System.Windows.Forms.TextBox();
            this.txtSecondNumber = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtAddition = new System.Windows.Forms.Button();
            this.txtSub = new System.Windows.Forms.Button();
            this.txtMultiplication = new System.Windows.Forms.Button();
            this.txtDivision = new System.Windows.Forms.Button();
            this.txtRemainder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtClean = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Number   ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Second Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Result";
            // 
            // txtFirstNumber
            // 
            this.txtFirstNumber.Location = new System.Drawing.Point(390, 77);
            this.txtFirstNumber.Name = "txtFirstNumber";
            this.txtFirstNumber.Size = new System.Drawing.Size(100, 20);
            this.txtFirstNumber.TabIndex = 1;
            // 
            // txtSecondNumber
            // 
            this.txtSecondNumber.Location = new System.Drawing.Point(390, 137);
            this.txtSecondNumber.Name = "txtSecondNumber";
            this.txtSecondNumber.Size = new System.Drawing.Size(100, 20);
            this.txtSecondNumber.TabIndex = 2;
            this.txtSecondNumber.TextChanged += new System.EventHandler(this.txtSecondNumber_TextChanged);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(390, 200);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(100, 20);
            this.txtResult.TabIndex = 3;
            // 
            // txtAddition
            // 
            this.txtAddition.Location = new System.Drawing.Point(46, 322);
            this.txtAddition.Name = "txtAddition";
            this.txtAddition.Size = new System.Drawing.Size(75, 23);
            this.txtAddition.TabIndex = 4;
            this.txtAddition.Text = "Addition";
            this.txtAddition.UseVisualStyleBackColor = true;
            this.txtAddition.Click += new System.EventHandler(this.txtAddition_Click);
            // 
            // txtSub
            // 
            this.txtSub.Location = new System.Drawing.Point(185, 322);
            this.txtSub.Name = "txtSub";
            this.txtSub.Size = new System.Drawing.Size(75, 23);
            this.txtSub.TabIndex = 5;
            this.txtSub.Text = "Substraction";
            this.txtSub.UseVisualStyleBackColor = true;
            this.txtSub.Click += new System.EventHandler(this.txtSub_Click);
            // 
            // txtMultiplication
            // 
            this.txtMultiplication.Location = new System.Drawing.Point(328, 322);
            this.txtMultiplication.Name = "txtMultiplication";
            this.txtMultiplication.Size = new System.Drawing.Size(75, 23);
            this.txtMultiplication.TabIndex = 6;
            this.txtMultiplication.Text = "Multiplication";
            this.txtMultiplication.UseVisualStyleBackColor = true;
            this.txtMultiplication.Click += new System.EventHandler(this.txtMultiplication_Click);
            // 
            // txtDivision
            // 
            this.txtDivision.Location = new System.Drawing.Point(474, 322);
            this.txtDivision.Name = "txtDivision";
            this.txtDivision.Size = new System.Drawing.Size(75, 23);
            this.txtDivision.TabIndex = 7;
            this.txtDivision.Text = "Division";
            this.txtDivision.UseVisualStyleBackColor = true;
            this.txtDivision.Click += new System.EventHandler(this.txtDivision_Click);
            // 
            // txtRemainder
            // 
            this.txtRemainder.Location = new System.Drawing.Point(638, 322);
            this.txtRemainder.Name = "txtRemainder";
            this.txtRemainder.Size = new System.Drawing.Size(75, 23);
            this.txtRemainder.TabIndex = 8;
            this.txtRemainder.Text = "Remainder";
            this.txtRemainder.UseVisualStyleBackColor = true;
            this.txtRemainder.Click += new System.EventHandler(this.txtRemainder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Simple calculator with C# window form";
            // 
            // txtClean
            // 
            this.txtClean.Location = new System.Drawing.Point(328, 390);
            this.txtClean.Name = "txtClean";
            this.txtClean.Size = new System.Drawing.Size(75, 23);
            this.txtClean.TabIndex = 10;
            this.txtClean.Text = "Clean";
            this.txtClean.UseVisualStyleBackColor = true;
            this.txtClean.Click += new System.EventHandler(this.txtClean_Click);
            // 
            // SimpleCalculatorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 459);
            this.Controls.Add(this.txtClean);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRemainder);
            this.Controls.Add(this.txtDivision);
            this.Controls.Add(this.txtMultiplication);
            this.Controls.Add(this.txtSub);
            this.Controls.Add(this.txtAddition);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtSecondNumber);
            this.Controls.Add(this.txtFirstNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SimpleCalculatorUI";
            this.Text = "SimpleCalculatorUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFirstNumber;
        private System.Windows.Forms.TextBox txtSecondNumber;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button txtAddition;
        private System.Windows.Forms.Button txtSub;
        private System.Windows.Forms.Button txtMultiplication;
        private System.Windows.Forms.Button txtDivision;
        private System.Windows.Forms.Button txtRemainder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button txtClean;
    }
}