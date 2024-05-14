namespace WinFormsApp1
{
    partial class calculator
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            textBox1 = new TextBox();
            button7 = new Button();
            button6 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rage Italic", 20F, FontStyle.Underline);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(281, 30);
            label1.Name = "label1";
            label1.Size = new Size(243, 43);
            label1.TabIndex = 0;
            label1.Text = "Simple Calculator";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label2.Location = new Point(50, 120);
            label2.Name = "label2";
            label2.Size = new Size(167, 30);
            label2.TabIndex = 1;
            label2.Text = "First Number : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label3.Location = new Point(50, 196);
            label3.Name = "label3";
            label3.Size = new Size(197, 30);
            label3.TabIndex = 2;
            label3.Text = "Second Number : ";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label4.Location = new Point(50, 272);
            label4.Name = "label4";
            label4.Size = new Size(94, 30);
            label4.TabIndex = 3;
            label4.Text = "Result : ";
            label4.Visible = false;
            label4.Click += label4_Click_1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(270, 196);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Enter a number";
            textBox2.Size = new Size(251, 39);
            textBox2.TabIndex = 5;
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(270, 265);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(251, 52);
            textBox3.TabIndex = 6;
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.Visible = false;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkViolet;
            button1.FlatAppearance.BorderColor = Color.DarkViolet;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(564, 99);
            button1.Name = "button1";
            button1.Size = new Size(90, 69);
            button1.TabIndex = 7;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.FlatAppearance.BorderColor = Color.Green;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(674, 99);
            button2.Name = "button2";
            button2.Size = new Size(90, 69);
            button2.TabIndex = 8;
            button2.Text = "Subtract";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.BackColor = Color.Blue;
            button3.FlatAppearance.BorderColor = Color.Blue;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(675, 188);
            button3.Name = "button3";
            button3.Size = new Size(90, 69);
            button3.TabIndex = 10;
            button3.Text = "Divide";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Goldenrod;
            button4.FlatAppearance.BorderColor = Color.Goldenrod;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(565, 188);
            button4.Name = "button4";
            button4.Size = new Size(90, 69);
            button4.TabIndex = 9;
            button4.Text = "Multiply";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Red;
            button5.FlatAppearance.BorderColor = Color.Red;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button5.ForeColor = SystemColors.ButtonFace;
            button5.Location = new Point(565, 277);
            button5.Name = "button5";
            button5.Size = new Size(199, 52);
            button5.TabIndex = 11;
            button5.Text = "Clear";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(270, 118);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter a number";
            textBox1.Size = new Size(251, 39);
            textBox1.TabIndex = 4;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // button7
            // 
            button7.BackColor = Color.DarkGreen;
            button7.FlatAppearance.BorderColor = Color.DarkGreen;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button7.ForeColor = SystemColors.ControlLightLight;
            button7.Location = new Point(129, 465);
            button7.Name = "button7";
            button7.Size = new Size(252, 46);
            button7.TabIndex = 13;
            button7.Text = "Start Timer";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Maroon;
            button6.FlatAppearance.BorderColor = Color.Maroon;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button6.ForeColor = SystemColors.ControlLightLight;
            button6.Location = new Point(448, 465);
            button6.Name = "button6";
            button6.Size = new Size(252, 46);
            button6.TabIndex = 14;
            button6.Text = "Stop Timer";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label5.Location = new Point(293, 359);
            label5.Name = "label5";
            label5.Size = new Size(231, 67);
            label5.TabIndex = 15;
            label5.Text = "00:00:00";
            label5.Click += label5_Click;
            // 
            // calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(800, 550);
            Controls.Add(label5);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "calculator";
            Text = "calculator";
            Load += calculator_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private TextBox textBox1;
        private Button button7;
        private Button button6;
        private System.Windows.Forms.Timer timer1;
        private Label label5;
    }
}