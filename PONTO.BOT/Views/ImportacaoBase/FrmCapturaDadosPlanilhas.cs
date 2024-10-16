using OfficeOpenXml;
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
    public partial class FrmCapturaDadosPlanilhas : Form
    {
        public FrmCapturaDadosPlanilhas()
        {
            InitializeComponent();
        }

        private void btnpastaplanilha_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    txtPlanilhas.Text = folderDialog.SelectedPath;
                }
            }
        }

        private void btntxtsaidaArquivos_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    txtSaida.Text = folderDialog.SelectedPath;
                }
            }
        }

        // Função auxiliar para obter o valor de uma célula, substituindo por "-" se estiver vazio
        private string GetCellValue(ExcelWorksheet worksheet, int linha, string coluna)
        {
            for (int col = 1; col <= worksheet.Dimension.End.Column; col++)
            {
                if (worksheet.Cells[1, col].Text == coluna)
                {
                    string valor = worksheet.Cells[linha, col].Text;
                    return string.IsNullOrEmpty(valor) ? "-" : valor;
                }
            }
            return "-"; // Se a coluna não for encontrada
        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            string[] colunas = txtColunas.Text.Split(',').Select(c => c.Trim()).ToArray();
            string pastaPlanilhas = txtPlanilhas.Text;
            string pastaSaida = txtSaida.Text;

            if (Directory.Exists(pastaPlanilhas) && Directory.Exists(pastaSaida))
            {
                string[] arquivosExcel = Directory.GetFiles(pastaPlanilhas, "*.xlsx");

                foreach (string arquivo in arquivosExcel)
                {
                    using (var package = new ExcelPackage(new FileInfo(arquivo)))
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                        int ultimaLinha = worksheet.Dimension.End.Row;

                        // Limpa o DataGridView antes de preencher
                        dataGridView.Rows.Clear();
                        dataGridView.Columns.Clear();

                        // Adiciona as colunas ao DataGridView
                        foreach (string coluna in colunas)
                        {
                            dataGridView.Columns.Add(coluna, coluna);
                        }

                        // Preenche o DataGridView com os dados da planilha
                        for (int linha = 2; linha <= ultimaLinha; linha++) // assume que a linha 1 é cabeçalho
                        {
                            var valores = new object[colunas.Length];
                            for (int i = 0; i < colunas.Length; i++)
                            {
                                valores[i] = GetCellValue(worksheet, linha, colunas[i]);
                            }
                            dataGridView.Rows.Add(valores);
                        }

                        // Gerar arquivo .txt com o nome da planilha
                        string nomeArquivoTxt = Path.Combine(pastaSaida, Path.GetFileNameWithoutExtension(arquivo) + ".txt");
                        using (StreamWriter writer = new StreamWriter(nomeArquivoTxt))
                        {
                            foreach (DataGridViewRow row in dataGridView.Rows)
                            {
                                if (!row.IsNewRow)
                                {
                                    string linhaTxt = string.Join(", ", row.Cells.Cast<DataGridViewCell>().Select(c => c.Value?.ToString() ?? "-"));
                                    writer.WriteLine(linhaTxt);
                                }
                            }
                        }
                    }
                }

                MessageBox.Show("Processamento concluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Selecione pastas válidas!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
