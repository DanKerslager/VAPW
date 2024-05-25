namespace VAPW
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            StartButton = new Button();
            progressBar1 = new ProgressBar();
            panel1 = new Panel();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            Ticker = new System.Windows.Forms.Timer(components);
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // StartButton
            // 
            StartButton.Location = new Point(24, 30);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(75, 23);
            StartButton.TabIndex = 0;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += button1_Click;
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.Brown;
            progressBar1.ForeColor = SystemColors.Desktop;
            progressBar1.Location = new Point(247, 114);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(246, 33);
            progressBar1.Step = 1;
            progressBar1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Location = new Point(132, 92);
            panel1.Name = "panel1";
            panel1.Size = new Size(74, 55);
            panel1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(596, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(142, 23);
            textBox1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlDark;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 538);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(497, 277);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(571, 230);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(302, 162);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 458);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Controls.Add(progressBar1);
            Controls.Add(StartButton);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartButton;
        private ProgressBar progressBar1;
        private Panel panel1;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer Ticker;
        private PictureBox pictureBox2;
    }
}
