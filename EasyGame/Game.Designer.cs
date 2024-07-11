namespace EasyGame
{
    partial class Game
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
            button1 = new Button();
            label1 = new Label();
            Number = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(298, 121);
            button1.Name = "button1";
            button1.Size = new Size(128, 61);
            button1.TabIndex = 0;
            button1.Text = "Click Me";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(755, 9);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 1;
            label1.Text = "בס\"ד";
            // 
            // Number
            // 
            Number.AutoSize = true;
            Number.Font = new Font("Segoe UI", 23F);
            Number.Location = new Point(544, 144);
            Number.Name = "Number";
            Number.Size = new Size(31, 42);
            Number.TabIndex = 2;
            Number.Text = "_";
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Number);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Game";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label Number;
    }
}
