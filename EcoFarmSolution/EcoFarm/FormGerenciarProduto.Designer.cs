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
            tableProdutoLista = new TableLayoutPanel();
            tabPage2 = new TabPage();
            panel2 = new Panel();
            txValor = new TextBox();
            txDescricao = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txNome = new TextBox();
            label2 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            tabProdutos.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel2.SuspendLayout();
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
            tabProdutos.Location = new Point(0, 93);
            tabProdutos.Name = "tabProdutos";
            tabProdutos.SelectedIndex = 0;
            tabProdutos.Size = new Size(970, 484); 
            tabProdutos.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.AutoScroll = true;
            tabPage1.AutoScrollMargin = new Size(50, 50);
            tabPage1.Controls.Add(tableProdutoLista);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(895, 456);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Lista de Produtos";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableProdutoLista
            // 
            tableProdutoLista.AutoSize = true;
            tableProdutoLista.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableProdutoLista.Location = new Point(1, 6);
            tableProdutoLista.Name = "tableProdutoLista";
            tableProdutoLista.Size = new Size(903, 100);
            tableProdutoLista.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel2);
            tabPage2.Controls.Add(button1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(895, 456);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Cadastro de produto";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(txValor);
            panel2.Controls.Add(txDescricao);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txNome);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(19, 28);
            panel2.Name = "panel2";
            panel2.Size = new Size(841, 333);
            panel2.TabIndex = 1;
            // 
            // txValor
            // 
            txValor.Location = new Point(150, 173);
            txValor.Name = "txValor";
            txValor.Size = new Size(362, 23);
            txValor.TabIndex = 5;
            // 
            // txDescricao
            // 
            txDescricao.Location = new Point(150, 106);
            txDescricao.Name = "txDescricao";
            txDescricao.Size = new Size(362, 23);
            txDescricao.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 176);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 3;
            label4.Text = "Valor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 106);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 2;
            label3.Text = "Descrição";
            // 
            // txNome
            // 
            txNome.Location = new Point(150, 33);
            txNome.Name = "txNome";
            txNome.Size = new Size(362, 23);
            txNome.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 41);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 0;
            label2.Text = "Nome";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(29, 378);
            button1.Name = "button1";
            button1.Size = new Size(138, 50);
            button1.TabIndex = 0;
            button1.Text = "Confirmar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormGerenciarProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(954, 680);
            Controls.Add(tabProdutos);
            Controls.Add(panel1);
            Name = "FormGerenciarProduto";
            Text = "FormGerenciarProduto";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabProdutos.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TabControl tabProdutos;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button1;
        private TableLayoutPanel tableProdutoLista;
        private Panel panel2;
        private TextBox txNome;
        private Label label2;
        private TextBox txValor;
        private TextBox txDescricao;
        private Label label4;
        private Label label3;
    }

    
}