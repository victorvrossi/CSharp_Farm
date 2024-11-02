namespace EcoFarm
{
    partial class FormGerenciarProduto
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
            label1 = new Label();
            tabProdutos = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            button1 = new Button();
            panel1.SuspendLayout();
            tabProdutos.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaShell;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(896, 60);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(33, 9);
            label1.Name = "label1";
            label1.Size = new Size(293, 45);
            label1.TabIndex = 0;
            label1.Text = "Gerenciar Produtos";
            // 
            // tabProdutos
            // 
            tabProdutos.Controls.Add(tabPage1);
            tabProdutos.Controls.Add(tabPage2);
            tabProdutos.Location = new Point(0, 66);
            tabProdutos.Name = "tabProdutos";
            tabProdutos.SelectedIndex = 0;
            tabProdutos.Size = new Size(896, 483);
            tabProdutos.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(888, 455);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Lista de Produtos";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(888, 455);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Cadastro de produto";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(282, 184);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormGerenciarProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 548);
            Controls.Add(tabProdutos);
            Controls.Add(panel1);
            Name = "FormGerenciarProduto";
            Text = "FormGerenciarProduto";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabProdutos.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TabControl tabProdutos;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button1;
    }
}