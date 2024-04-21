using PONTO.BOT.Funcoes;
using PONTO.DAO;
using PONTO.DOMAIN.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PONTO.BOT.Views.ImportacaoBase
{
    public partial class FrmImportacaoBase : Form
    {
        public FrmImportacaoBase()
        {
            InitializeComponent();
        }

        private void BtnCarregarTemplate_Click(object sender, EventArgs e)
        {
            if (cbxTemplate.Text == "CLIENTE")
            {
                DgvImportBase.Rows.Clear();
                DgvImportBase.Columns.Clear();
                DgvImportBase.Columns.Add("Nome", "Nome");
                DgvImportBase.Columns.Add("CPF", "CPF");
                DgvImportBase.Columns.Add("RG", "RG");
                DgvImportBase.Columns.Add("DataNascimento", "DataNascimento");
                DgvImportBase.Columns.Add("Aposentado", "Aposentado");
                DgvImportBase.Columns.Add("NomeMae", "NomeMae");
                DgvImportBase.Columns.Add("NomePai", "NomePai");
                DgvImportBase.Columns.Add("LocalNasc", "LocalNasc");
                DgvImportBase.Columns.Add("StatusCad", "StatusCad");

            }

            if (cbxTemplate.Text == "BENEFÍCIOS")
            {
                DgvImportBase.Rows.Clear();
                DgvImportBase.Columns.Clear();
                DgvImportBase.Columns.Add("Tipo", "Tipo");
                DgvImportBase.Columns.Add("CPF", "CPF");
                DgvImportBase.Columns.Add("Matricula", "Matricula");
                DgvImportBase.Columns.Add("ConvenioOrgao", "ConvenioOrgao");
                DgvImportBase.Columns.Add("Consignatorio", "Consignatorio");
                DgvImportBase.Columns.Add("ValorBeneficio", "ValorBeneficio");
                DgvImportBase.Columns.Add("RegistroFuncional", "RegistroFuncional");
                DgvImportBase.Columns.Add("TempoRegistro", "TempoRegistro");
                DgvImportBase.Columns.Add("StatusBenef", "StatusBenef");

            }


            if (cbxTemplate.Text == "EMPRÉSTIMOS")
            {
                DgvImportBase.Rows.Clear();
                DgvImportBase.Columns.Clear();
                DgvImportBase.Columns.Add("Contrato", "Contrato");
                DgvImportBase.Columns.Add("Tipo", "Tipo");
                DgvImportBase.Columns.Add("CPF", "CPF");
                DgvImportBase.Columns.Add("Matricula", "Matricula");
                DgvImportBase.Columns.Add("Orgao", "Orgao");
                DgvImportBase.Columns.Add("ValorParcela", "ValorParcela");
                DgvImportBase.Columns.Add("DataContracao", "DataContracao");
                DgvImportBase.Columns.Add("QtdParcelas", "QtdParcelas");
                DgvImportBase.Columns.Add("ParcelasPagas", "ParcelasPagas");
                DgvImportBase.Columns.Add("Empregador", "Empregador");

            }

            if (cbxTemplate.Text == "CONTRATAÇÃO")
            {
                DgvImportBase.Rows.Clear();
                DgvImportBase.Columns.Clear();
                DgvImportBase.Columns.Add("Nome", "Nome");
                DgvImportBase.Columns.Add("CPF", "CPF");
                DgvImportBase.Columns.Add("Rg", "Rg");
                DgvImportBase.Columns.Add("Contrato", "Contrato");
                DgvImportBase.Columns.Add("Funcionario", "Funcionario");
                DgvImportBase.Columns.Add("ValorContratado", "ValorContratado");
                DgvImportBase.Columns.Add("ValorParcela", "ValorParcela");
                DgvImportBase.Columns.Add("QtdParcela", "QtdParcela");
                DgvImportBase.Columns.Add("DataContratacao", "DataContratacao");
                DgvImportBase.Columns.Add("OrgaoPagador", "OrgaoPagador");
                DgvImportBase.Columns.Add("TipoContratacao", "TipoContratacao");
                DgvImportBase.Columns.Add("Matricula", "Matricula");

            }

            if (cbxTemplate.Text == "TELEFONE")
            {
                DgvImportBase.Rows.Clear();
                DgvImportBase.Columns.Clear();
                DgvImportBase.Columns.Add("CPF", "CPF");
                DgvImportBase.Columns.Add("TipoTelefone", "TipoTelefone");
                DgvImportBase.Columns.Add("DD", "DD");
                DgvImportBase.Columns.Add("NumTelefone", "NumTelefone");
                DgvImportBase.Columns.Add("ScoreInterno", "ScoreInterno");
                DgvImportBase.Columns.Add("StatusTelefone", "StatusTelefone");

            }

            if (cbxTemplate.Text == "EMAIL")
            {
                DgvImportBase.Rows.Clear();
                DgvImportBase.Columns.Clear();
                DgvImportBase.Columns.Add("CPF", "CPF");
                DgvImportBase.Columns.Add("EmailCliente", "EmailCliente");
                DgvImportBase.Columns.Add("StatusEmail", "StatusEmail");
                DgvImportBase.Columns.Add("ScoreInterno", "ScoreInterno");

            }

            if (cbxTemplate.Text == "BASE ROBÔ")
            {
                DgvImportBase.Rows.Clear();
                DgvImportBase.Columns.Clear();
                DgvImportBase.Columns.Add("CPF", "CPF");
                DgvImportBase.Columns.Add("NOME", "NOME");
                DgvImportBase.Columns.Add("ORGAO", "ORGAO");
                DgvImportBase.Columns.Add("TPVINCULO", "TPVINCULO");
                DgvImportBase.Columns.Add("MBCONSIFACULTA", "MBCONSIFACULTA");
                DgvImportBase.Columns.Add("MBCARTAOCREDITO", "MBCARTAOCREDITO");
                DgvImportBase.Columns.Add("MBCARTAOBENEF", "MBCARTAOBENEF");
                DgvImportBase.Columns.Add("MDCONSIFACULTA", "MDCONSIFACULTA");
                DgvImportBase.Columns.Add("MDCARTAOCREDITO", "MDCARTAOCREDITO");
                DgvImportBase.Columns.Add("MDCARTAOBENEF", "MDCARTAOBENEF");
                DgvImportBase.Columns.Add("NUM_MATRICULA", "NUM_MATRICULA");
                DgvImportBase.Columns.Add("QTD_NUM_MAT", "QTD_NUM_MAT");
                DgvImportBase.Columns.Add("MARGEM_5", "MARGEM_5");
                DgvImportBase.Columns.Add("RESULTADO", "RESULTADO");
                DgvImportBase.Columns.Add("MENSAGEM_CONSIGNADO", "MENSAGEM_CONSIGNADO");
                DgvImportBase.Columns.Add("MENSAGEM_CARTAO_CREDITO", "MENSAGEM_CARTAO_CREDITO");

            }

            /*                        
            HISTÓRICO            
             */
        }

        private void BtnImportaBase_Click(object sender, EventArgs e)
        {
            ImportExport importExport = new ImportExport();

            importExport.ImportTxt_ponto_virgular(DgvImportBase);

            lblTotal.Text = DgvImportBase.RowCount.ToString();
        }

        private void ProcessarBase_Click(object sender, EventArgs e)
        {
            var db = new appDbContext();

            progressBar.Maximum = DgvImportBase.Rows.Count;

            for (int i = 0; i < DgvImportBase.Rows.Count-1; i++)
            {

                if (cbxTemplate.Text == "CLIENTE")
                {
                    Cliente cliente = new Cliente
                    {
                        Aposentado = DgvImportBase.Rows[i].Cells["Aposentado"].Value.ToString(),
                        CPF = DgvImportBase.Rows[i].Cells["CPF"].Value.ToString(),
                        DataCadastro = DateTime.Now,
                        DataNascimento = DateTime.Parse(DgvImportBase.Rows[i].Cells["DataNascimento"].Value.ToString()),
                        LocalNasc = DgvImportBase.Rows[i].Cells["LocalNasc"].Value.ToString(),
                        Nome = DgvImportBase.Rows[i].Cells["Nome"].Value.ToString(),
                        NomeMae = DgvImportBase.Rows[i].Cells["NomeMae"].Value.ToString(),
                        NomePai = DgvImportBase.Rows[i].Cells["NomePai"].Value.ToString(),
                        RG = DgvImportBase.Rows[i].Cells["RG"].Value.ToString(),
                        StatusCad = DgvImportBase.Rows[i].Cells["StatusCad"].Value.ToString(),                        
                        
                    };


                    var excl = db.Clientes.Where(a => a.CPF == cliente.CPF).FirstOrDefault();

                    if (excl == null)
                    {

                        db.Clientes.Add(cliente);
                        db.SaveChanges();
                    }
                }

                if (cbxTemplate.Text == "BENEFÍCIOS")
                {
                    Beneficios beneficios = new Beneficios
                    {
                        Tipo = DgvImportBase[0, i].Value.ToString(),
                        CPF = DgvImportBase[1, i].Value.ToString(),
                        Matricula = DgvImportBase[2, i].Value.ToString(),
                        ConvenioOrgao = DgvImportBase[3, i].Value.ToString(),
                        Consignatorio = DgvImportBase[4, i].Value.ToString(),
                        ValorBeneficio = DgvImportBase[5, i].Value.ToString(),
                        RegistroFuncional = DgvImportBase[6, i].Value.ToString(),
                        TempoRegistro = DgvImportBase[7, i].Value.ToString(),
                        StatusBenef = DgvImportBase[8, i].Value.ToString(),
                        DataCadastro = DateTime.Now
                    };

                    db.Beneficios.Add(beneficios);
                    db.SaveChanges();
                }

                if (cbxTemplate.Text == "EMPRÉSTIMOS")
                {
                    Emprestimo emprestimo = new Emprestimo
                    {
                        Contrato = DgvImportBase[0, i].Value.ToString(),
                        Tipo = DgvImportBase[1, i].Value.ToString(),
                        CPF = DgvImportBase[2, i].Value.ToString(),
                        Matricula  = DgvImportBase[3, i].Value.ToString(),
                        Orgao = DgvImportBase[4, i].Value.ToString(),
                        ValorParcela = DgvImportBase[5, i].Value.ToString(),
                        DataContracao = DateTime.Parse(DgvImportBase[6, i].Value.ToString()),
                        QtdParcelas = int.Parse(DgvImportBase[7, i].Value.ToString()),
                        ParcelasPagas = int.Parse(DgvImportBase[8, i].Value.ToString()),
                        Empregador = DgvImportBase[9, i].Value.ToString(),
                        DataCadastro = DateTime.Now

                    };

                    db.Emprestimos.Add(emprestimo);
                    db.SaveChanges();
                }


                if (cbxTemplate.Text == "CONTRATAÇÃO")
                {
                    Contratacao contratacao = new Contratacao
                    {
                     
                        Nome = DgvImportBase.Rows[i].Cells["Nome"].Value.ToString(),
                        CPF = DgvImportBase.Rows[i].Cells["CPF"].Value.ToString(),
                        Rg = DgvImportBase.Rows[i].Cells["Rg"].Value.ToString(),
                        Contrato = DgvImportBase.Rows[i].Cells["Contrato"].Value.ToString(),
                        Funcionario = DgvImportBase.Rows[i].Cells["Funcionario"].Value.ToString(),
                        ValorContratado = DgvImportBase.Rows[i].Cells["ValorContratado"].Value.ToString(),
                        ValorParcela = DgvImportBase.Rows[i].Cells["ValorParcela"].Value.ToString(),
                        QtdParcela = DgvImportBase.Rows[i].Cells["QtdParcela"].Value.ToString(),
                        DataContratacao = DateTime.Parse(DgvImportBase.Rows[i].Cells["DataContratacao"].Value.ToString()),
                        OrgaoPagador = DgvImportBase.Rows[i].Cells["OrgaoPagador"].Value.ToString(),
                        TipoContratacao = DgvImportBase.Rows[i].Cells["TipoContratacao"].Value.ToString(),
                        Matricula = DgvImportBase.Rows[i].Cells["Matricula"].Value.ToString(),
                        DataCadastro = DateTime.Now
                    };

                    db.Contratacaos.Add(contratacao);
                    db.SaveChanges();
                }


                if (cbxTemplate.Text == "TELEFONE")
                {
                    Telefone telefone = new Telefone
                    {
                        CPF = DgvImportBase.Rows[i].Cells["CPF"].Value.ToString(),
                        TipoTelefone = DgvImportBase.Rows[i].Cells["TipoTelefone"].Value.ToString(),
                        DD = DgvImportBase.Rows[i].Cells["DD"].Value.ToString(),
                        NumTelefone = DgvImportBase.Rows[i].Cells["NumTelefone"].Value.ToString(),
                        ScoreInterno = int.Parse(DgvImportBase.Rows[i].Cells["ScoreInterno"].Value.ToString()),
                        StatusTelefone = DgvImportBase.Rows[i].Cells["StatusTelefone"].Value.ToString(),
                        DataCadastro = DateTime.Now
                    };

                    var tel = db.Telefones.Where(a => a.NumTelefone == telefone.NumTelefone).FirstOrDefault();

                    if (tel == null)
                    {
                        db.Telefones.Add(telefone);
                        db.SaveChanges();
                    }
                }


                if (cbxTemplate.Text == "EMAIL")
                {
                    Email email = new Email
                    {
                       
                        CPF = DgvImportBase.Rows[i].Cells["CPF"].Value.ToString(),
                        EmailCliente = DgvImportBase.Rows[i].Cells["EmailCliente"].Value.ToString(),
                        StatusEmail = DgvImportBase.Rows[i].Cells["StatusEmail"].Value.ToString(),
                        ScoreInterno = int.Parse(DgvImportBase.Rows[i].Cells["ScoreInterno"].Value.ToString()),
                        DataCadastro = DateTime.Now
                    };

                    var cadEmail = db.Emails.Where(a => a.EmailCliente == email.EmailCliente).FirstOrDefault();

                    if (cadEmail == null)
                    {
                        db.Emails.Add(email);
                        db.SaveChanges();
                    }
                }

                this.Refresh();

                // Atualiza o valor da barra de progresso
                progressBar.Value = i + 1;
                lblTotalFeito.Text = i.ToString();
                lblLayout.Text = cbxTemplate.Text;

            }




        }
    }
}
