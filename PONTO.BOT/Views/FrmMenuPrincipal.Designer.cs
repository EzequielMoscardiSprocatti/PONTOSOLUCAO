namespace PONTO.BOT.Views
{
    partial class FrmMenuPrincipal
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
            btnTeste = new Button();
            menuStrip1 = new MenuStrip();
            gestãoBaseToolStripMenuItem = new ToolStripMenuItem();
            importaçãoToolStripMenuItem = new ToolStripMenuItem();
            importaBaseToolStripMenuItem = new ToolStripMenuItem();
            serviçosToolStripMenuItem = new ToolStripMenuItem();
            açãoMassivaToolStripMenuItem = new ToolStripMenuItem();
            BtnEnvioMkt = new ToolStripMenuItem();
            geraçãoTxtToolStripMenuItem = new ToolStripMenuItem();
            arquivosBaseToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnTeste
            // 
            btnTeste.Location = new Point(692, 403);
            btnTeste.Name = "btnTeste";
            btnTeste.Size = new Size(75, 23);
            btnTeste.TabIndex = 0;
            btnTeste.Text = "Teste Db";
            btnTeste.UseVisualStyleBackColor = true;
            btnTeste.Click += btnTeste_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { gestãoBaseToolStripMenuItem, serviçosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(785, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // gestãoBaseToolStripMenuItem
            // 
            gestãoBaseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { importaçãoToolStripMenuItem, geraçãoTxtToolStripMenuItem });
            gestãoBaseToolStripMenuItem.Name = "gestãoBaseToolStripMenuItem";
            gestãoBaseToolStripMenuItem.Size = new Size(82, 20);
            gestãoBaseToolStripMenuItem.Text = "Gestão Base";
            // 
            // importaçãoToolStripMenuItem
            // 
            importaçãoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { importaBaseToolStripMenuItem });
            importaçãoToolStripMenuItem.Name = "importaçãoToolStripMenuItem";
            importaçãoToolStripMenuItem.Size = new Size(180, 22);
            importaçãoToolStripMenuItem.Text = "Importação";
            // 
            // importaBaseToolStripMenuItem
            // 
            importaBaseToolStripMenuItem.Name = "importaBaseToolStripMenuItem";
            importaBaseToolStripMenuItem.Size = new Size(143, 22);
            importaBaseToolStripMenuItem.Text = "Importa Base";
            importaBaseToolStripMenuItem.Click += importaBaseToolStripMenuItem_Click;
            // 
            // serviçosToolStripMenuItem
            // 
            serviçosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { açãoMassivaToolStripMenuItem });
            serviçosToolStripMenuItem.Name = "serviçosToolStripMenuItem";
            serviçosToolStripMenuItem.Size = new Size(62, 20);
            serviçosToolStripMenuItem.Text = "Serviços";
            // 
            // açãoMassivaToolStripMenuItem
            // 
            açãoMassivaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { BtnEnvioMkt });
            açãoMassivaToolStripMenuItem.Name = "açãoMassivaToolStripMenuItem";
            açãoMassivaToolStripMenuItem.Size = new Size(146, 22);
            açãoMassivaToolStripMenuItem.Text = "Ação Massiva";
            // 
            // BtnEnvioMkt
            // 
            BtnEnvioMkt.Name = "BtnEnvioMkt";
            BtnEnvioMkt.Size = new Size(119, 22);
            BtnEnvioMkt.Text = "Disparos";
            BtnEnvioMkt.Click += BtnEnvioMkt_Click;
            // 
            // geraçãoTxtToolStripMenuItem
            // 
            geraçãoTxtToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { arquivosBaseToolStripMenuItem });
            geraçãoTxtToolStripMenuItem.Name = "geraçãoTxtToolStripMenuItem";
            geraçãoTxtToolStripMenuItem.Size = new Size(180, 22);
            geraçãoTxtToolStripMenuItem.Text = "Geração Txt";
            // 
            // arquivosBaseToolStripMenuItem
            // 
            arquivosBaseToolStripMenuItem.Name = "arquivosBaseToolStripMenuItem";
            arquivosBaseToolStripMenuItem.Size = new Size(180, 22);
            arquivosBaseToolStripMenuItem.Text = "Arquivos Base";
            arquivosBaseToolStripMenuItem.Click += arquivosBaseToolStripMenuItem_Click;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 436);
            Controls.Add(btnTeste);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmMenuPrincipal";
            Text = "FrmMenuPrincipal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTeste;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem gestãoBaseToolStripMenuItem;
        private ToolStripMenuItem importaçãoToolStripMenuItem;
        private ToolStripMenuItem importaBaseToolStripMenuItem;
        private ToolStripMenuItem serviçosToolStripMenuItem;
        private ToolStripMenuItem açãoMassivaToolStripMenuItem;
        private ToolStripMenuItem BtnEnvioMkt;
        private ToolStripMenuItem geraçãoTxtToolStripMenuItem;
        private ToolStripMenuItem arquivosBaseToolStripMenuItem;
    }
}