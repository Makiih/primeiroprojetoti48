namespace primeiroprojetoti48
{
    partial class Form4
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
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblQtd = new System.Windows.Forms.Label();
            this.lblPrecoU = new System.Windows.Forms.Label();
            this.lblDT = new System.Windows.Forms.Label();
            this.lblIDC = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.lblVT = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.txtPrecoU = new System.Windows.Forms.TextBox();
            this.txtIDCliente = new System.Windows.Forms.TextBox();
            this.txtIDProduto = new System.Windows.Forms.TextBox();
            this.txtProduto = new System.Windows.Forms.ComboBox();
            this.DataCompra = new System.Windows.Forms.DateTimePicker();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnIniciarVendas = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.txtValorTotal = new System.Windows.Forms.RichTextBox();
            this.txtDesconto = new System.Windows.Forms.RichTextBox();
            this.btnVendas = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblProduto.Location = new System.Drawing.Point(230, 6);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(54, 16);
            this.lblProduto.TabIndex = 0;
            this.lblProduto.Text = "Produto";
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtd.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblQtd.Location = new System.Drawing.Point(13, 67);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(77, 16);
            this.lblQtd.TabIndex = 1;
            this.lblQtd.Text = "Quantidade";
            // 
            // lblPrecoU
            // 
            this.lblPrecoU.AutoSize = true;
            this.lblPrecoU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoU.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPrecoU.Location = new System.Drawing.Point(230, 67);
            this.lblPrecoU.Name = "lblPrecoU";
            this.lblPrecoU.Size = new System.Drawing.Size(66, 16);
            this.lblPrecoU.TabIndex = 2;
            this.lblPrecoU.Text = "Preço Uni";
            // 
            // lblDT
            // 
            this.lblDT.AutoSize = true;
            this.lblDT.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDT.Location = new System.Drawing.Point(704, 9);
            this.lblDT.Name = "lblDT";
            this.lblDT.Size = new System.Drawing.Size(84, 13);
            this.lblDT.TabIndex = 3;
            this.lblDT.Text = "Data da Compra";
            // 
            // lblIDC
            // 
            this.lblIDC.AutoSize = true;
            this.lblIDC.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblIDC.Location = new System.Drawing.Point(14, 381);
            this.lblIDC.Name = "lblIDC";
            this.lblIDC.Size = new System.Drawing.Size(53, 13);
            this.lblIDC.TabIndex = 4;
            this.lblIDC.Text = "ID Cliente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(153, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "ID Produto";
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Font = new System.Drawing.Font("MS PGothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesconto.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblDesconto.Location = new System.Drawing.Point(13, 465);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(87, 19);
            this.lblDesconto.TabIndex = 6;
            this.lblDesconto.Text = "Desconto";
            // 
            // lblVT
            // 
            this.lblVT.AutoSize = true;
            this.lblVT.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVT.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.lblVT.Location = new System.Drawing.Point(8, 509);
            this.lblVT.Name = "lblVT";
            this.lblVT.Size = new System.Drawing.Size(126, 25);
            this.lblVT.TabIndex = 7;
            this.lblVT.Text = "Valor Total";
            // 
            // txtQtd
            // 
            this.txtQtd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtQtd.Location = new System.Drawing.Point(101, 66);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(110, 20);
            this.txtQtd.TabIndex = 9;
            // 
            // txtPrecoU
            // 
            this.txtPrecoU.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtPrecoU.Location = new System.Drawing.Point(313, 65);
            this.txtPrecoU.Name = "txtPrecoU";
            this.txtPrecoU.Size = new System.Drawing.Size(119, 20);
            this.txtPrecoU.TabIndex = 10;
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtIDCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDCliente.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDCliente.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtIDCliente.Location = new System.Drawing.Point(73, 381);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.Size = new System.Drawing.Size(69, 15);
            this.txtIDCliente.TabIndex = 11;
            this.txtIDCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIDProduto
            // 
            this.txtIDProduto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtIDProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDProduto.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDProduto.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtIDProduto.Location = new System.Drawing.Point(217, 381);
            this.txtIDProduto.Name = "txtIDProduto";
            this.txtIDProduto.Size = new System.Drawing.Size(79, 15);
            this.txtIDProduto.TabIndex = 12;
            this.txtIDProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtProduto
            // 
            this.txtProduto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtProduto.FormattingEnabled = true;
            this.txtProduto.Location = new System.Drawing.Point(233, 25);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(199, 21);
            this.txtProduto.TabIndex = 15;
            this.txtProduto.SelectedIndexChanged += new System.EventHandler(this.txtProduto_SelectedIndexChanged);
            // 
            // DataCompra
            // 
            this.DataCompra.CalendarMonthBackground = System.Drawing.SystemColors.ButtonFace;
            this.DataCompra.Location = new System.Drawing.Point(542, 29);
            this.DataCompra.Name = "DataCompra";
            this.DataCompra.Size = new System.Drawing.Size(246, 20);
            this.DataCompra.TabIndex = 16;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAdicionar.Location = new System.Drawing.Point(671, 63);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(117, 23);
            this.btnAdicionar.TabIndex = 17;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnIniciarVendas
            // 
            this.btnIniciarVendas.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnIniciarVendas.Location = new System.Drawing.Point(542, 63);
            this.btnIniciarVendas.Name = "btnIniciarVendas";
            this.btnIniciarVendas.Size = new System.Drawing.Size(110, 23);
            this.btnIniciarVendas.TabIndex = 18;
            this.btnIniciarVendas.Text = "Iniciar Vendas";
            this.btnIniciarVendas.UseVisualStyleBackColor = true;
            this.btnIniciarVendas.Click += new System.EventHandler(this.btnIniciarVendas_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnExcluir.Location = new System.Drawing.Point(686, 381);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(102, 23);
            this.btnExcluir.TabIndex = 19;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAlterar.Location = new System.Drawing.Point(580, 381);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(100, 23);
            this.btnAlterar.TabIndex = 20;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.btnFinalizar.Location = new System.Drawing.Point(653, 475);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(135, 58);
            this.btnFinalizar.TabIndex = 21;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // GridView
            // 
            this.GridView.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.GridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.GridColor = System.Drawing.SystemColors.Window;
            this.GridView.Location = new System.Drawing.Point(15, 96);
            this.GridView.Name = "GridView";
            this.GridView.Size = new System.Drawing.Size(773, 274);
            this.GridView.TabIndex = 22;
            this.GridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_CellContentClick);
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtValorTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorTotal.Font = new System.Drawing.Font("Sylfaen", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtValorTotal.Location = new System.Drawing.Point(140, 505);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(292, 34);
            this.txtValorTotal.TabIndex = 23;
            this.txtValorTotal.Text = "";
            // 
            // txtDesconto
            // 
            this.txtDesconto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtDesconto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDesconto.Font = new System.Drawing.Font("MS PGothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesconto.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtDesconto.Location = new System.Drawing.Point(140, 465);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(115, 19);
            this.txtDesconto.TabIndex = 24;
            this.txtDesconto.Text = "";
            this.txtDesconto.TextChanged += new System.EventHandler(this.txtDesconto_TextChanged);
            // 
            // btnVendas
            // 
            this.btnVendas.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnVendas.Location = new System.Drawing.Point(485, 381);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(89, 23);
            this.btnVendas.TabIndex = 25;
            this.btnVendas.Text = "Vendas";
            this.btnVendas.UseVisualStyleBackColor = true;
            this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCliente.Location = new System.Drawing.Point(13, 6);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(48, 16);
            this.lblCliente.TabIndex = 26;
            this.lblCliente.Text = "Cliente";
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtCliente.FormattingEnabled = true;
            this.txtCliente.Location = new System.Drawing.Point(12, 25);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(199, 21);
            this.txtCliente.TabIndex = 27;
            this.txtCliente.SelectedIndexChanged += new System.EventHandler(this.txtCliente_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 466);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "%";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.btnVendas);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnIniciarVendas);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.DataCompra);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.txtIDProduto);
            this.Controls.Add(this.txtIDCliente);
            this.Controls.Add(this.txtPrecoU);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.lblVT);
            this.Controls.Add(this.lblDesconto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblIDC);
            this.Controls.Add(this.lblDT);
            this.Controls.Add(this.lblPrecoU);
            this.Controls.Add(this.lblQtd);
            this.Controls.Add(this.lblProduto);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.Label lblPrecoU;
        private System.Windows.Forms.Label lblDT;
        private System.Windows.Forms.Label lblIDC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.Label lblVT;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.TextBox txtPrecoU;
        private System.Windows.Forms.TextBox txtIDCliente;
        private System.Windows.Forms.TextBox txtIDProduto;
        private System.Windows.Forms.ComboBox txtProduto;
        private System.Windows.Forms.DateTimePicker DataCompra;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnIniciarVendas;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.RichTextBox txtValorTotal;
        private System.Windows.Forms.RichTextBox txtDesconto;
        private System.Windows.Forms.Button btnVendas;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox txtCliente;
        private System.Windows.Forms.Label label1;
    }
}