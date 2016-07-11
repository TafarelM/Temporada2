namespace Apresentacao_GUI
{
    partial class FrmMenu
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
            this.barraStatusPrincipal = new System.Windows.Forms.StatusStrip();
            this.labelVersao = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.menuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFilial = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPessoaFisica = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPessoaJuridica = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPedido = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.barraStatusPrincipal.SuspendLayout();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // barraStatusPrincipal
            // 
            this.barraStatusPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelVersao});
            this.barraStatusPrincipal.Location = new System.Drawing.Point(0, 402);
            this.barraStatusPrincipal.Name = "barraStatusPrincipal";
            this.barraStatusPrincipal.Size = new System.Drawing.Size(720, 22);
            this.barraStatusPrincipal.TabIndex = 1;
            this.barraStatusPrincipal.Text = "statusStrip1";
            // 
            // labelVersao
            // 
            this.labelVersao.Name = "labelVersao";
            this.labelVersao.Size = new System.Drawing.Size(59, 17);
            this.labelVersao.Text = "Versão 1.0";
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastro,
            this.menuVenda,
            this.menuSair});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(720, 24);
            this.menuPrincipal.TabIndex = 2;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // menuCadastro
            // 
            this.menuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCliente,
            this.menuFilial,
            this.menuFornecedor,
            this.menuPessoaFisica,
            this.menuPessoaJuridica,
            this.menuProduto});
            this.menuCadastro.Name = "menuCadastro";
            this.menuCadastro.Size = new System.Drawing.Size(66, 20);
            this.menuCadastro.Text = "Cadastro";
            // 
            // menuCliente
            // 
            this.menuCliente.Name = "menuCliente";
            this.menuCliente.Size = new System.Drawing.Size(153, 22);
            this.menuCliente.Text = "Cliente";
            // 
            // menuFilial
            // 
            this.menuFilial.Name = "menuFilial";
            this.menuFilial.Size = new System.Drawing.Size(153, 22);
            this.menuFilial.Text = "Filial";
            // 
            // menuFornecedor
            // 
            this.menuFornecedor.Name = "menuFornecedor";
            this.menuFornecedor.Size = new System.Drawing.Size(153, 22);
            this.menuFornecedor.Text = "Fornecedor";
            // 
            // menuPessoaFisica
            // 
            this.menuPessoaFisica.Name = "menuPessoaFisica";
            this.menuPessoaFisica.Size = new System.Drawing.Size(153, 22);
            this.menuPessoaFisica.Text = "Pessoa Física";
            // 
            // menuPessoaJuridica
            // 
            this.menuPessoaJuridica.Name = "menuPessoaJuridica";
            this.menuPessoaJuridica.Size = new System.Drawing.Size(153, 22);
            this.menuPessoaJuridica.Text = "Pessoa Jurídica";
            // 
            // menuProduto
            // 
            this.menuProduto.Name = "menuProduto";
            this.menuProduto.Size = new System.Drawing.Size(153, 22);
            this.menuProduto.Text = "Produto";
            // 
            // menuVenda
            // 
            this.menuVenda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPedido});
            this.menuVenda.Name = "menuVenda";
            this.menuVenda.Size = new System.Drawing.Size(51, 20);
            this.menuVenda.Text = "Venda";
            // 
            // menuPedido
            // 
            this.menuPedido.Name = "menuPedido";
            this.menuPedido.Size = new System.Drawing.Size(152, 22);
            this.menuPedido.Text = "Pedido";
            this.menuPedido.Click += new System.EventHandler(this.menuPedido_Click);
            // 
            // menuSair
            // 
            this.menuSair.Name = "menuSair";
            this.menuSair.Size = new System.Drawing.Size(38, 20);
            this.menuSair.Text = "Sair";
            this.menuSair.Click += new System.EventHandler(this.menuSair_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 424);
            this.Controls.Add(this.barraStatusPrincipal);
            this.Controls.Add(this.menuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.barraStatusPrincipal.ResumeLayout(false);
            this.barraStatusPrincipal.PerformLayout();
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip barraStatusPrincipal;
        private System.Windows.Forms.ToolStripStatusLabel labelVersao;
        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem menuCadastro;
        private System.Windows.Forms.ToolStripMenuItem menuCliente;
        private System.Windows.Forms.ToolStripMenuItem menuFilial;
        private System.Windows.Forms.ToolStripMenuItem menuFornecedor;
        private System.Windows.Forms.ToolStripMenuItem menuPessoaFisica;
        private System.Windows.Forms.ToolStripMenuItem menuPessoaJuridica;
        private System.Windows.Forms.ToolStripMenuItem menuProduto;
        private System.Windows.Forms.ToolStripMenuItem menuVenda;
        private System.Windows.Forms.ToolStripMenuItem menuSair;
        private System.Windows.Forms.ToolStripMenuItem menuPedido;
    }
}