namespace WinFormsApp5
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
            pictureBox1 = new PictureBox();
            button1 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(481, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(247, 360);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += button_image_Click;
            // 
            // button1
            // 
            button1.Location = new Point(121, 367);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "Load";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(157, 49);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(62, 29);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "90 ";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.Click += button90_Click;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(157, 94);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(67, 29);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "180";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            radioButton2.Click += button180_Click;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(157, 139);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(67, 29);
            radioButton3.TabIndex = 4;
            radioButton3.TabStop = true;
            radioButton3.Text = "270";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            radioButton3.Click += button270_Click;
            // 
            // button2
            // 
            button2.Location = new Point(117, 194);
            button2.Name = "button2";
            button2.Size = new Size(179, 34);
            button2.TabIndex = 5;
            button2.Text = "Rotate";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button_rotate_Click;
            // 
            // button3
            // 
            button3.Location = new Point(121, 234);
            button3.Name = "button3";
            button3.Size = new Size(175, 34);
            button3.TabIndex = 6;
            button3.Text = "Invert Colors ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button_invert_Click;
            // 
            // button4
            // 
            button4.Location = new Point(121, 274);
            button4.Name = "button4";
            button4.Size = new Size(175, 34);
            button4.TabIndex = 7;
            button4.Text = "Up side down ";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button_side_Click;
            // 
            // button5
            // 
            button5.Location = new Point(121, 311);
            button5.Name = "button5";
            button5.Size = new Size(175, 34);
            button5.TabIndex = 8;
            button5.Text = "Only green ";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button_green_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}
