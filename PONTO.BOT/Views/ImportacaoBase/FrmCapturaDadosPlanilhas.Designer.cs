namespace PONTO.BOT.Views.ImportacaoBase
{
    partial class FrmCapturaDadosPlanilhas
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
            btnpastaplanilha = new Button();
            txtPlanilhas = new TextBox();
            txtSaida = new TextBox();
            btntxtsaidaArquivos = new Button();
            txtColunas = new TextBox();
            btnProcessar = new Button();
            dataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // btnpastaplanilha
            // 
            btnpastaplanilha.Location = new Point(12, 41);
            btnpastaplanilha.Name = "btnpastaplanilha";
            btnpastaplanilha.Size = new Size(184, 38);
            btnpastaplanilha.TabIndex = 0;
            btnpastaplanilha.Text = "Abrir Pasta da Planilhas";
            btnpastaplanilha.UseVisualStyleBackColor = true;
            btnpastaplanilha.Click += btnpastaplanilha_Click;
            // 
            // txtPlanilhas
            // 
            txtPlanilhas.Location = new Point(202, 50);
            txtPlanilhas.Name = "txtPlanilhas";
            txtPlanilhas.Size = new Size(203, 23);
            txtPlanilhas.TabIndex = 1;
            // 
            // txtSaida
            // 
            txtSaida.Location = new Point(202, 94);
            txtSaida.Name = "txtSaida";
            txtSaida.Size = new Size(203, 23);
            txtSaida.TabIndex = 3;
            // 
            // btntxtsaidaArquivos
            // 
            btntxtsaidaArquivos.Location = new Point(12, 85);
            btntxtsaidaArquivos.Name = "btntxtsaidaArquivos";
            btntxtsaidaArquivos.Size = new Size(184, 38);
            btntxtsaidaArquivos.TabIndex = 2;
            btntxtsaidaArquivos.Text = "Local arquivos TXT";
            btntxtsaidaArquivos.UseVisualStyleBackColor = true;
            btntxtsaidaArquivos.Click += btntxtsaidaArquivos_Click;
            // 
            // txtColunas
            // 
            txtColunas.Location = new Point(12, 12);
            txtColunas.Name = "txtColunas";
            txtColunas.Size = new Size(393, 23);
            txtColunas.TabIndex = 4;
            // 
            // btnProcessar
            // 
            btnProcessar.Location = new Point(12, 129);
            btnProcessar.Name = "btnProcessar";
            btnProcessar.Size = new Size(184, 38);
            btnProcessar.TabIndex = 5;
            btnProcessar.Text = "Processar";
            btnProcessar.UseVisualStyleBackColor = true;
            btnProcessar.Click += btnProcessar_Click;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(-1, 203);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(805, 420);
            dataGridView.TabIndex = 6;
            // 
            // FrmCapturaDadosPlanilhas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 623);
            Controls.Add(dataGridView);
            Controls.Add(btnProcessar);
            Controls.Add(txtColunas);
            Controls.Add(txtSaida);
            Controls.Add(btntxtsaidaArquivos);
            Controls.Add(txtPlanilhas);
            Controls.Add(btnpastaplanilha);
            Name = "FrmCapturaDadosPlanilhas";
            Text = "FrmCapturaDadosPlanilhas";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnpastaplanilha;
        private TextBox txtPlanilhas;
        private TextBox txtSaida;
        private Button btntxtsaidaArquivos;
        private TextBox txtColunas;
        private Button btnProcessar;
        private DataGridView dataGridView;
    }
}