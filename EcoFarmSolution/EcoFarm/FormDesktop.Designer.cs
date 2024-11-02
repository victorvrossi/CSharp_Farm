namespace EcoFarm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDesktop));
            panelDesktop = new Panel();
            button1 = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            button1.BackColor = Color.Goldenrod;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(71, 9);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(230, 52);
            button1.TabIndex = 1;
            button1.Text = "Produto";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LemonChiffon;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(1, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(319, 80);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._8890229;
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(11, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // FormDesktop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 659);
            Controls.Add(panel1);
            Controls.Add(panelDesktop);
            Name = "FormDesktop";
            Text = "EcoFarm";
            Load += FormDesktop_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelDesktop;
        private Button button1;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}
