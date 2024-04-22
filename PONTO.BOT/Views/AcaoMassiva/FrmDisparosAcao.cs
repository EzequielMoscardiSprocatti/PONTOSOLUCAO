using PONTO.BOT.Funcoes;
using PONTO.DAO.Funcao;
using PONTO.DOMAIN.Entidades;
using PONTO.SERVICOS.API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PONTO.BOT.Views.AcaoMassiva
{
    public partial class FrmDisparosAcao : Form
    {
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
                DgvImportBase.Columns.Add("CPF", "CPF");
                DgvImportBase.Columns.Add("Email", "Email");
                DgvImportBase.Columns.Add("Assunto", "Assunto");
                DgvImportBase.Columns.Add("Mensagem", "Mensagem");
                DgvImportBase.Columns.Add("Assinatura", "Assinatura");
                DgvImportBase.Columns.Add("StatusEnvio", "StatusEnvio");
                DgvImportBase.Columns.Add("DataEnvio", "DataEnvio");

                txtCorpoMsg.Text = "Cole o HTML aqui  Você pode utilizar a tag @nome no HTML para que no momento do envio o mesmo seja trocado pelo nome do cliente carregado ao lado";
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

        private void btnDispararAcao_Click(object sender, EventArgs e)
        {
            AcaoEnvioEmail AcaoEmailMkt = new AcaoEnvioEmail();

            if (cbxTemplate.Text == "EMAIL")
            {
                for(int i = 0; i < DgvImportBase.Rows.Count; i++)
                {
                    try
                    {
                        DisparosAcaoMkt envioAcao = new DisparosAcaoMkt
                        {
                            CanalEnvio = "EMAIL",
                            CPF = DgvImportBase.Rows[i].Cells["CPF"].Value.ToString(),
                            DataEnvio = DateTime.Now,
                            Email = DgvImportBase.Rows[i].Cells["Email"].Value.ToString(),
                            NomeCliente = DgvImportBase.Rows[i].Cells["NomeCliente"].Value.ToString()
                        };

                        var result = AcaoEmailMkt.EnvioViaSSMTP(envioAcao, "", 
                            DgvImportBase.Rows[i].Cells["Assunto"].Value.ToString(), 
                            txtCorpoMsg.Text, 
                            DgvImportBase.Rows[i].Cells["Assinatura"].Value.ToString());


                    }
                    catch (Exception)
                    {

                    }
            
                }
            }
        }
    }
}
