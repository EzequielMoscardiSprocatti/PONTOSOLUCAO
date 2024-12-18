﻿using PONTO.BOT.Views.AcaoMassiva;
using PONTO.BOT.Views.ImportacaoBase;
using PONTO.DAO;
using PONTO.DOMAIN.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PONTO.BOT.Views
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            var db = new appDbContext();

            Cliente cliente = new Cliente
            {
                Aposentado = "não",
                CPF = "35959808838",
                DataCadastro = DateTime.Now,
                DataNascimento = DateTime.Parse("10/08/1988"),
                LocalNasc = "São Paulo capital",
                Nome = "Ezequiel Moscardi Sprocatti",
                NomeMae = "Maria",
                NomePai = "Aguinaldo",
                RG = "42587736",
                StatusCad = "Ativo"
            };

            db.Clientes.Add(cliente);
            db.SaveChanges();

        }

        private void importaBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmImportacaoBase importacaoBase = new FrmImportacaoBase();
            importacaoBase.Show();
        }

        private void BtnEnvioMkt_Click(object sender, EventArgs e)
        {
            FrmDisparosAcao frmDisparos = new FrmDisparosAcao();
            frmDisparos.Show();
        }

        private void arquivosBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCapturaDadosPlanilhas frmCaptura = new FrmCapturaDadosPlanilhas(); 
            frmCaptura.Show();
        }
    }
}
