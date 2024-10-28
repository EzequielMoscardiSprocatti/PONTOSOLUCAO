using PONTO.BOT.Funcoes;
using PONTO.DOMAIN.Entidades;
using PONTO.SERVICOS.API;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PONTO.BOT.Views.AcaoMassiva
{
    public partial class FrmDisparosAcao : Form
    {
        private bool PausarAcao = false;
        private bool ProcessoEnvio = false;
        public FrmDisparosAcao()
        {
            InitializeComponent();
        }

        private void BtnCarregarLayout_Click(object sender, EventArgs e)
        {
            if (cbxTemplate.Text == "EMAIL")
            {
                DgvImportBase.Rows.Clear();
                DgvImportBase.Columns.Clear();

                DgvImportBase.Columns.Add("NomeCliente", "NomeCliente");
                DgvImportBase.Columns.Add("CPF", "CPF");//0
                DgvImportBase.Columns.Add("Email", "Email");//1
                DgvImportBase.Columns.Add("Assunto", "Assunto");//2
                DgvImportBase.Columns.Add("Mensagem", "Mensagem");//3
                DgvImportBase.Columns.Add("Assinatura", "Assinatura");//4
                DgvImportBase.Columns.Add("StatusEnvio", "StatusEnvio");//5
                DgvImportBase.Columns.Add("DataEnvio", "DataEnvio");//6
                DgvImportBase.Columns.Add("InfoAdicional", "InfoAdicional");//7

                txtCorpoMsg.Text = "Cole o HTML aqui  Você pode utilizar a tag @nome e @infAdd no HTML para que no momento do envio o mesmo seja trocado pelo nome do cliente, ou seja adicioanado algum dado no carregamento ao lado";
            }

            if (cbxTemplate.Text == "SMS")
            {
                DgvImportBase.Rows.Clear();
                DgvImportBase.Columns.Clear();
                DgvImportBase.Columns.Add("NomeCliente", "NomeCliente");
                DgvImportBase.Columns.Add("CPF", "CPF");
                DgvImportBase.Columns.Add("Telefone", "Telefone");
                DgvImportBase.Columns.Add("StatusEnvio", "StatusEnvio");
                DgvImportBase.Columns.Add("DataEnvio", "DataEnvio");

                txtCorpoMsg.Text = "Cole aqui a mensagem que deseja enviar para o cliente, user a @nome para inserir o nome do cliente no momento do envio";

            }

            lblLayout.Text = cbxTemplate.Text;


        }

        private void FrmDisparosAcao_Load(object sender, EventArgs e)
        {

        }

        private void BtnImportaBase_Click(object sender, EventArgs e)
        {
            ImportExport import = new ImportExport();
            import.ImportCSV(DgvImportBase);

            lblTotal.Text = DgvImportBase.Rows.Count.ToString();

        }

        private async void btnDispararAcao_Click(object sender, EventArgs e)
        {
            AcaoEnvioEmail AcaoEmailMkt = new AcaoEnvioEmail();
            progressBar1.Minimum = 0;

            PausarAcao = false;
            ProcessoEnvio = false;

            progressBar1.Maximum = DgvImportBase.Rows.Count;

            if (cbxTemplate.Text == "EMAIL")
            {

                await Task.Run(() => EnvioEmail()); 

            }
        }


        private async Task EnvioEmail()
        {
            AcaoEnvioEmail AcaoEmailMkt = new AcaoEnvioEmail();

            for (int i = 0; i < DgvImportBase.Rows.Count; i++)
            {               

                try
                {
                    DisparosAcaoMkt envioAcao = new DisparosAcaoMkt
                    {
                        CanalEnvio = "EMAIL",
                        CPF = DgvImportBase.Rows[i].Cells["CPF"].Value.ToString(),
                        DataEnvio = DateTime.Now,
                        Email = DgvImportBase.Rows[i].Cells["Email"].Value.ToString(),
                        NomeCliente = DgvImportBase.Rows[i].Cells["NomeCliente"].Value?.ToString() ?? string.Empty,
                        InfoAdicional = DgvImportBase.Rows[i].Cells["InfoAdicional"].Value?.ToString() ?? string.Empty

                    };

                    try
                    {
                        if(DgvImportBase.Rows[i].Cells["Assinatura"].Value == null || DgvImportBase.Rows[i].Cells["Assinatura"].Value == "")
                        {
                            DgvImportBase.Rows[i].Cells["Assinatura"].Value = "-";
                        }
                    }
                    catch (Exception)
                    {
                        DgvImportBase.Rows[i].Cells["Assinatura"].Value = "-";
                    }

                    var result = await AcaoEmailMkt.EnvioViaSSMTPAsync(envioAcao, "",
                        DgvImportBase.Rows[i].Cells["Assunto"].Value.ToString(),
                        txtCorpoMsg.Text.Replace("@nome", envioAcao.NomeCliente).Replace("@Nome", envioAcao.NomeCliente).Replace("@NOME", envioAcao.NomeCliente).Replace("@infAdd", envioAcao.NomeCliente).Replace("@INFADD", envioAcao.NomeCliente),
                        DgvImportBase.Rows[i].Cells["Assinatura"].Value.ToString());

                  

                    try
                    {
                        DgvImportBase.Rows[i].Cells["StatusEnvio"].Value = result;
                        DgvImportBase.Rows[i].Cells["DataEnvio"].Value = DateTime.Now.ToString();
                    }
                    catch (Exception)
                    {

                    }
                }
                catch (Exception)
                {
                }

                UpdateProgressBar(progressBar1, i);
                UpdateLblTotalFeito(lblTotalFeito, i);

                while (PausarAcao)
                {
                    System.Threading.Thread.Sleep(1000);
                }

                while (ProcessoEnvio)
                {
                    break;
                }

            }
        }

        private void UpdateProgressBar(System.Windows.Forms.ProgressBar progressBar, int value)
        {
            if (progressBar.InvokeRequired)
            {
                progressBar.Invoke(new Action(() => progressBar.Value = value));
            }
            else
            {
                progressBar.Value = value;
            }
        }

        private void UpdateLblTotalFeito(Label lblFeito, int value)
        {
            if (lblFeito.InvokeRequired)
            {
                lblFeito.Invoke(new Action(() => lblFeito.Text = value.ToString()));
            }
            else
            {
                lblFeito.Text = value.ToString();
            }
        }

        private void BtnPausarAcao_Click(object sender, EventArgs e)
        {
            if (PausarAcao == false)
            {
                BtnPausarAcao.Text = "Continuar";
                PausarAcao = true;
                return;
            }

            if (PausarAcao)
            {
                BtnPausarAcao.Text = "Pausar";
                PausarAcao = false;
                return;
            }


        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {

            ProcessoEnvio = true;

        }
    }
}
