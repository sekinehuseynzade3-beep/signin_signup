namespace tapşırıq1
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
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            label1 = new Label();
            checkBox1 = new CheckBox();
            button1 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            label3 = new Label();
            textBox3 = new TextBox();
            button2 = new Button();
            checkBox2 = new CheckBox();
            label4 = new Label();
            textBox4 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.AppWorkspace;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(30, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(332, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sign in";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(28, 81);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 58);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(28, 234);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(159, 24);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Show me password";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(110, 317);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Sign in";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(28, 152);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 129);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 5;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.AppWorkspace;
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Location = new Point(429, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(342, 426);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sign up";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 129);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(28, 152);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(110, 317);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Sign up";
            button2.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(28, 234);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(159, 24);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "Show me password";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 58);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 1;
            label4.Text = "Username";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(28, 81);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Sign in";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private TextBox textBox2;
        private Button button1;
        private CheckBox checkBox1;
        private Label label1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private Label label3;
        private TextBox textBox3;
        private Button button2;
        private CheckBox checkBox2;
        private Label label4;
        private TextBox textBox4;
    }
}
