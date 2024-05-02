namespace PONTO.BOT.Views.ImportacaoBase
{
    partial class FrmImportacaoBase
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
            DgvImportBase = new DataGridView();
            cbxTemplate = new ComboBox();
            BtnCarregarTemplate = new Button();
            BtnImportaBase = new Button();
            ProcessarBase = new Button();
            progressBar = new ProgressBar();
            label1 = new Label();
            lblTotal = new Label();
            label2 = new Label();
            lblTotalFeito = new Label();
            label4 = new Label();
            lblLayout = new Label();
            BtnBulk = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvImportBase).BeginInit();
            SuspendLayout();
            // 
            // DgvImportBase
            // 
            DgvImportBase.BackgroundColor = Color.White;
            DgvImportBase.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvImportBase.Location = new Point(0, 91);
            DgvImportBase.Name = "DgvImportBase";
            DgvImportBase.Size = new Size(800, 337);
            DgvImportBase.TabIndex = 0;
            // 
            // cbxTemplate
            // 
            cbxTemplate.FormattingEnabled = true;
            cbxTemplate.Items.AddRange(new object[] { "CLIENTE", "BENEFÍCIOS", "EMPRÉSTIMOS", "CONTRATAÇÃO", "TELEFONE", "EMAIL", "HISTÓRICO", "BASE ROBÔ" });
            cbxTemplate.Location = new Point(6, 22);
            cbxTemplate.Name = "cbxTemplate";
            cbxTemplate.Size = new Size(216, 23);
            cbxTemplate.TabIndex = 1;
            cbxTemplate.Text = "SELECIONE UM TEMPLATE";
            // 
            // BtnCarregarTemplate
            // 
            BtnCarregarTemplate.Location = new Point(228, 22);
            BtnCarregarTemplate.Name = "BtnCarregarTemplate";
            BtnCarregarTemplate.Size = new Size(150, 23);
            BtnCarregarTemplate.TabIndex = 2;
            BtnCarregarTemplate.Text = "Carregar Template";
            BtnCarregarTemplate.UseVisualStyleBackColor = true;
            BtnCarregarTemplate.Click += BtnCarregarTemplate_Click;
            // 
            // BtnImportaBase
            // 
            BtnImportaBase.Location = new Point(384, 22);
            BtnImportaBase.Name = "BtnImportaBase";
            BtnImportaBase.Size = new Size(105, 23);
            BtnImportaBase.TabIndex = 3;
            BtnImportaBase.Text = "Importa Base";
            BtnImportaBase.UseVisualStyleBackColor = true;
            BtnImportaBase.Click += BtnImportaBase_Click;
            // 
            // ProcessarBase
            // 
            ProcessarBase.Location = new Point(495, 22);
            ProcessarBase.Name = "ProcessarBase";
            ProcessarBase.Size = new Size(124, 23);
            ProcessarBase.TabIndex = 4;
            ProcessarBase.Text = "Iniciar Processo";
            ProcessarBase.UseVisualStyleBackColor = true;
            ProcessarBase.Click += ProcessarBase_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(0, 428);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(800, 10);
            progressBar.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 63);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 6;
            label1.Text = "TOTAL CARREGADO:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(126, 63);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(13, 15);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(213, 63);
            label2.Name = "label2";
            label2.Size = new Size(119, 15);
            label2.TabIndex = 8;
            label2.Text = "TOTAL PROCESSADO:";
            // 
            // lblTotalFeito
            // 
            lblTotalFeito.AutoSize = true;
            lblTotalFeito.Location = new Point(338, 63);
            lblTotalFeito.Name = "lblTotalFeito";
            lblTotalFeito.Size = new Size(13, 15);
            lblTotalFeito.TabIndex = 9;
            lblTotalFeito.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(413, 63);
            label4.Name = "label4";
            label4.Size = new Size(120, 15);
            label4.TabIndex = 10;
            label4.Text = "LAYOUT ESCOLHIDO:";
            // 
            // lblLayout
            // 
            lblLayout.AutoSize = true;
            lblLayout.Location = new Point(539, 63);
            lblLayout.Name = "lblLayout";
            lblLayout.Size = new Size(76, 15);
            lblLayout.TabIndex = 11;
            lblLayout.Text = "SEM LAYOUT";
            // 
            // BtnBulk
            // 
            BtnBulk.Location = new Point(625, 22);
            BtnBulk.Name = "BtnBulk";
            BtnBulk.Size = new Size(102, 23);
            BtnBulk.TabIndex = 12;
            BtnBulk.Text = "Processo Bulk";
            BtnBulk.UseVisualStyleBackColor = true;
            BtnBulk.Click += BtnBulk_Click;
            // 
            // FrmImportacaoBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 457);
            Controls.Add(BtnBulk);
            Controls.Add(lblLayout);
            Controls.Add(label4);
            Controls.Add(lblTotalFeito);
            Controls.Add(label2);
            Controls.Add(lblTotal);
            Controls.Add(label1);
            Controls.Add(progressBar);
            Controls.Add(ProcessarBase);
            Controls.Add(BtnImportaBase);
            Controls.Add(BtnCarregarTemplate);
            Controls.Add(cbxTemplate);
            Controls.Add(DgvImportBase);
            Name = "FrmImportacaoBase";
            Text = "FrmImportacaoBase";
            ((System.ComponentModel.ISupportInitialize)DgvImportBase).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvImportBase;
        private ComboBox cbxTemplate;
        private Button BtnCarregarTemplate;
        private Button BtnImportaBase;
        private Button ProcessarBase;
        private ProgressBar progressBar;
        private Label label1;
        private Label lblTotal;
        private Label label2;
        private Label lblTotalFeito;
        private Label label4;
        private Label lblLayout;
        private Button BtnBulk;
    }
}