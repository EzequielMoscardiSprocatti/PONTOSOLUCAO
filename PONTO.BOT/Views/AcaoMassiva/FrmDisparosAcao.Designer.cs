namespace PONTO.BOT.Views.AcaoMassiva
{
    partial class FrmDisparosAcao
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
            cbxTemplate = new ComboBox();
            BtnCarregarLayout = new Button();
            BtnImportaBase = new Button();
            btnDispararAcao = new Button();
            DgvImportBase = new DataGridView();
            progressBar1 = new ProgressBar();
            lblLayout = new Label();
            label4 = new Label();
            lblTotalFeito = new Label();
            label2 = new Label();
            lblTotal = new Label();
            label1 = new Label();
            txtCorpoMsg = new TextBox();
            BtnPausarAcao = new Button();
            BtnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvImportBase).BeginInit();
            SuspendLayout();
            // 
            // cbxTemplate
            // 
            cbxTemplate.FormattingEnabled = true;
            cbxTemplate.Items.AddRange(new object[] { "EMAIL", "SMS" });
            cbxTemplate.Location = new Point(12, 21);
            cbxTemplate.Name = "cbxTemplate";
            cbxTemplate.Size = new Size(143, 23);
            cbxTemplate.TabIndex = 0;
            cbxTemplate.Text = "Tipo de Envio";
            // 
            // BtnCarregarLayout
            // 
            BtnCarregarLayout.Location = new Point(173, 21);
            BtnCarregarLayout.Name = "BtnCarregarLayout";
            BtnCarregarLayout.Size = new Size(119, 23);
            BtnCarregarLayout.TabIndex = 1;
            BtnCarregarLayout.Text = "Carregar Layout";
            BtnCarregarLayout.UseVisualStyleBackColor = true;
            BtnCarregarLayout.Click += BtnCarregarLayout_Click;
            // 
            // BtnImportaBase
            // 
            BtnImportaBase.Location = new Point(298, 21);
            BtnImportaBase.Name = "BtnImportaBase";
            BtnImportaBase.Size = new Size(107, 23);
            BtnImportaBase.TabIndex = 2;
            BtnImportaBase.Text = "Importa Base";
            BtnImportaBase.UseVisualStyleBackColor = true;
            BtnImportaBase.Click += BtnImportaBase_Click;
            // 
            // btnDispararAcao
            // 
            btnDispararAcao.Location = new Point(411, 21);
            btnDispararAcao.Name = "btnDispararAcao";
            btnDispararAcao.Size = new Size(114, 23);
            btnDispararAcao.TabIndex = 3;
            btnDispararAcao.Text = "Disparar Ação";
            btnDispararAcao.UseVisualStyleBackColor = true;
            btnDispararAcao.Click += btnDispararAcao_Click;
            // 
            // DgvImportBase
            // 
            DgvImportBase.BackgroundColor = Color.White;
            DgvImportBase.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvImportBase.Location = new Point(-1, 103);
            DgvImportBase.Name = "DgvImportBase";
            DgvImportBase.Size = new Size(594, 335);
            DgvImportBase.TabIndex = 4;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(-1, 437);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(804, 10);
            progressBar1.TabIndex = 5;
            // 
            // lblLayout
            // 
            lblLayout.AutoSize = true;
            lblLayout.Location = new Point(512, 67);
            lblLayout.Name = "lblLayout";
            lblLayout.Size = new Size(76, 15);
            lblLayout.TabIndex = 17;
            lblLayout.Text = "SEM LAYOUT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(386, 67);
            label4.Name = "label4";
            label4.Size = new Size(120, 15);
            label4.TabIndex = 16;
            label4.Text = "LAYOUT ESCOLHIDO:";
            // 
            // lblTotalFeito
            // 
            lblTotalFeito.AutoSize = true;
            lblTotalFeito.Location = new Point(298, 67);
            lblTotalFeito.Name = "lblTotalFeito";
            lblTotalFeito.Size = new Size(13, 15);
            lblTotalFeito.TabIndex = 15;
            lblTotalFeito.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(173, 67);
            label2.Name = "label2";
            label2.Size = new Size(119, 15);
            label2.TabIndex = 14;
            label2.Text = "TOTAL PROCESSADO:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(128, 67);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(13, 15);
            lblTotal.TabIndex = 13;
            lblTotal.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 67);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 12;
            label1.Text = "TOTAL CARREGADO:";
            // 
            // txtCorpoMsg
            // 
            txtCorpoMsg.Location = new Point(592, 103);
            txtCorpoMsg.Multiline = true;
            txtCorpoMsg.Name = "txtCorpoMsg";
            txtCorpoMsg.Size = new Size(211, 335);
            txtCorpoMsg.TabIndex = 18;
            // 
            // BtnPausarAcao
            // 
            BtnPausarAcao.Location = new Point(531, 21);
            BtnPausarAcao.Name = "BtnPausarAcao";
            BtnPausarAcao.Size = new Size(96, 23);
            BtnPausarAcao.TabIndex = 19;
            BtnPausarAcao.Text = "Pausar Ação";
            BtnPausarAcao.UseVisualStyleBackColor = true;
            BtnPausarAcao.Click += BtnPausarAcao_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(633, 21);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(96, 23);
            BtnCancelar.TabIndex = 20;
            BtnCancelar.Text = "Cancelar Ação";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // FrmDisparosAcao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 487);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnPausarAcao);
            Controls.Add(txtCorpoMsg);
            Controls.Add(lblLayout);
            Controls.Add(label4);
            Controls.Add(lblTotalFeito);
            Controls.Add(label2);
            Controls.Add(lblTotal);
            Controls.Add(label1);
            Controls.Add(DgvImportBase);
            Controls.Add(progressBar1);
            Controls.Add(btnDispararAcao);
            Controls.Add(BtnImportaBase);
            Controls.Add(BtnCarregarLayout);
            Controls.Add(cbxTemplate);
            Name = "FrmDisparosAcao";
            Text = "Disparos de Ação Mtk";
            Load += FrmDisparosAcao_Load;
            ((System.ComponentModel.ISupportInitialize)DgvImportBase).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbxTemplate;
        private Button BtnCarregarLayout;
        private Button BtnImportaBase;
        private Button btnDispararAcao;
        private DataGridView DgvImportBase;
        private ProgressBar progressBar1;
        private Label lblLayout;
        private Label label4;
        private Label lblTotalFeito;
        private Label label2;
        private Label lblTotal;
        private Label label1;
        private TextBox txtCorpoMsg;
        private Button BtnPausarAcao;
        private Button BtnCancelar;
    }
}