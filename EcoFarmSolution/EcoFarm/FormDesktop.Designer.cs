﻿namespace EcoFarm
{
    partial class FormDesktop
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
            panelDesktop = new Panel();
            button1 = new Button();
            SuspendLayout();
            // 
            // panelDesktop
            // 
            panelDesktop.Location = new Point(326, 3);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(812, 659);
            panelDesktop.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(90, 84);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormDesktop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 659);
            Controls.Add(button1);
            Controls.Add(panelDesktop);
            Name = "FormDesktop";
            Text = "EcoFarm";
            ResumeLayout(false);
        }

        #endregion

        private Panel panelDesktop;
        private Button button1;
    }
}
