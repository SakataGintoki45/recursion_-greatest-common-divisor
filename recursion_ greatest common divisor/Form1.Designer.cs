namespace recursion__greatest_common_divisor
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
            txtNumber1 = new TextBox();
            txtNumber2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnCalculate = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // txtNumber1
            // 
            txtNumber1.Font = new Font("Segoe UI", 15F);
            txtNumber1.Location = new Point(186, 96);
            txtNumber1.Name = "txtNumber1";
            txtNumber1.Size = new Size(113, 34);
            txtNumber1.TabIndex = 0;
            // 
            // txtNumber2
            // 
            txtNumber2.Font = new Font("Segoe UI", 15F);
            txtNumber2.Location = new Point(447, 96);
            txtNumber2.Name = "txtNumber2";
            txtNumber2.Size = new Size(113, 34);
            txtNumber2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(186, 50);
            label1.Name = "label1";
            label1.Size = new Size(100, 28);
            label1.TabIndex = 2;
            label1.Text = "Number 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(447, 50);
            label2.Name = "label2";
            label2.Size = new Size(100, 28);
            label2.TabIndex = 3;
            label2.Text = "Number 2";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(305, 161);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(175, 37);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 15F);
            lblResult.Location = new Point(305, 288);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 28);
            lblResult.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnCalculate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNumber2);
            Controls.Add(txtNumber1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumber1;
        private TextBox txtNumber2;
        private Label label1;
        private Label label2;
        private Button btnCalculate;
        private Label lblResult;
    }
}
