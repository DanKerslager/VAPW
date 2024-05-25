namespace VAPW
{
    partial class Form2
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
            Timer = new RadioButton();
            Events = new RadioButton();
            button1 = new Button();
            SuspendLayout();
            // 
            // Timer
            // 
            Timer.AutoSize = true;
            Timer.Location = new Point(23, 45);
            Timer.Name = "Timer";
            Timer.Size = new Size(55, 19);
            Timer.TabIndex = 0;
            Timer.Text = "Timer";
            Timer.UseVisualStyleBackColor = true;
            // 
            // Events
            // 
            Events.AutoSize = true;
            Events.Checked = true;
            Events.Location = new Point(23, 12);
            Events.Name = "Events";
            Events.Size = new Size(59, 19);
            Events.TabIndex = 1;
            Events.TabStop = true;
            Events.Text = "Events";
            Events.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(112, 43);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Ok";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(243, 78);
            Controls.Add(button1);
            Controls.Add(Events);
            Controls.Add(Timer);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton Timer;
        private RadioButton Events;
        private Button button1;
    }
}