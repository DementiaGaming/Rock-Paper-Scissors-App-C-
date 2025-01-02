namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            progressBar1 = new ProgressBar();
            label5 = new Label();
            progressBar2 = new ProgressBar();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(500, 100);
            label1.Name = "label1";
            label1.Size = new Size(167, 25);
            label1.TabIndex = 0;
            label1.Text = "Rock Paper Scissors";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(184, 248);
            button1.Name = "button1";
            button1.Size = new Size(265, 233);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(455, 248);
            button2.Name = "button2";
            button2.Size = new Size(265, 233);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(726, 248);
            button3.Name = "button3";
            button3.Size = new Size(265, 233);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(500, 138);
            label2.Name = "label2";
            label2.Size = new Size(65, 25);
            label2.TabIndex = 4;
            label2.Text = "Score: ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(500, 174);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 5;
            label3.Text = "AI Score: ";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Coral;
            label4.Location = new Point(500, 208);
            label4.Name = "label4";
            label4.Size = new Size(77, 25);
            label4.TabIndex = 6;
            label4.Text = "Winner: ";
            label4.Click += label4_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(184, 558);
            progressBar1.Maximum = 10;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(807, 34);
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 7;
            progressBar1.Click += progressBar1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(536, 530);
            label5.Name = "label5";
            label5.Size = new Size(112, 25);
            label5.TabIndex = 8;
            label5.Text = "Player Score:";
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(184, 658);
            progressBar2.Maximum = 10;
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(807, 34);
            progressBar2.Style = ProgressBarStyle.Continuous;
            progressBar2.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(554, 630);
            label6.Name = "label6";
            label6.Size = new Size(82, 25);
            label6.TabIndex = 10;
            label6.Text = "AI Score:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1178, 744);
            Controls.Add(label6);
            Controls.Add(progressBar2);
            Controls.Add(label5);
            Controls.Add(progressBar1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Rock Paper Scissors";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label2;
        private Label label3;
        private Label label4;
        private ProgressBar progressBar1;
        private Label label5;
        private ProgressBar progressBar2;
        private Label label6;
    }
}
