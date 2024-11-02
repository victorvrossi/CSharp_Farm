using EcoFarm.@class.produto;

namespace EcoFarm
{
    public partial class FormProdutoItemLista
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
            panel1 = new Panel();
            panel2 = new Panel();
            lbNome = new Label();
            lbDescricao = new Label();
            lbValor = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(759, 149);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(lbValor);
            panel2.Controls.Add(lbDescricao);
            panel2.Controls.Add(lbNome);
            panel2.Location = new Point(19, 22);
            panel2.Name = "panel2";
            panel2.Size = new Size(727, 100);
            panel2.TabIndex = 0;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNome.Location = new Point(24, 30);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(78, 32);
            lbNome.TabIndex = 0;
            lbNome.Text = "label1";
            // 
            // lbDescricao
            // 
            lbDescricao.AutoSize = true;
            lbDescricao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDescricao.Location = new Point(243, 39);
            lbDescricao.Name = "lbDescricao";
            lbDescricao.Size = new Size(52, 21);
            lbDescricao.TabIndex = 1;
            lbDescricao.Text = "label2";
            // 
            // lbValor
            // 
            lbValor.AutoSize = true;
            lbValor.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbValor.Location = new Point(523, 30);
            lbValor.Name = "lbValor";
            lbValor.Size = new Size(78, 32);
            lbValor.TabIndex = 2;
            lbValor.Text = "label3";
            // 
            // FormProdutoItemLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 150);
            Controls.Add(panel1);
            Name = "FormProdutoItemLista";
            Text = "FormProdutoItemLista";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lbValor;
        private Label lbDescricao;
        private Label lbNome;
    }
}