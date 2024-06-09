using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PONTO.BOT.Funcoes
{
    public class ImportExport
    {
        OleDbConnection conn;
        OleDbDataAdapter MyDataAdapter;
        DataTable dt;

        public void ImportarExcel(DataGridView datagridview)
        {
            string Nome_Arquivo = "Plan1";
            string rota = "";
            try
            {
                OpenFileDialog openfile1 = new OpenFileDialog();
                openfile1.Filter = "Excel Files | *.xlsx";
                openfile1.Title = "Selecione o arquivo Excel base";
                if (openfile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openfile1.FileName.Equals("") == false)
                    {
                        rota = openfile1.FileName;
                    }
                }

                System.Threading.Thread.Sleep(3000);

                conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source=" + rota + ";Extended Properties='Excel 12.0 Xml;HDR=Yes'");
                MyDataAdapter = new OleDbDataAdapter("Select * from [" + Nome_Arquivo + "$]", conn);
                dt = new DataTable();
                MyDataAdapter.Fill(dt);

                // string stop = "";
                //datagridview.DataSource = dt;

                foreach (DataRow dados in dt.Rows)
                {

                    datagridview.Rows.Add(dados.ItemArray);
                }

                System.Threading.Thread.Sleep(3000);
            }

            catch (Exception e)
            {
                Nome_Arquivo = "Planilha1";

                try
                {

                    System.Threading.Thread.Sleep(3000);
                    conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source=" + rota + ";Extended Properties='Excel 12.0 Xml;HDR=Yes'");
                    MyDataAdapter = new OleDbDataAdapter("Select * from [" + Nome_Arquivo + "$]", conn);
                    dt = new DataTable();
                    MyDataAdapter.Fill(dt);

                    // string stop = "";
                    //datagridview.DataSource = dt;

                    foreach (DataRow dados in dt.Rows)
                    {

                        datagridview.Rows.Add(dados.ItemArray);
                    }

                    System.Threading.Thread.Sleep(3000);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Subir Arquivo Excel ", "Erro de Importação");
                }
            }

        }

        public void ExportaExcel(DataGridView datagridview)
        {
            int Colunas = 0;
            int Linhas = 0;

            Colunas = datagridview.Columns.Count;
            Linhas = datagridview.Rows.Count;

            for (int i = 0; i < Linhas; i++)
            {
                {
                    for (int ii = 0; ii < Colunas; ii++)
                        if (datagridview[ii, i].Value == null)
                        {
                            try
                            {
                                datagridview[ii, i].Value = "-";

                            }
                            catch (FormatException)
                            {

                            }
                        }
                }
            }

            {
                try
                {
                    Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();


                    if (datagridview.Rows.Count > 0)
                    {
                        try
                        {
                            XcelApp.Application.Workbooks.Add(Type.Missing);

                            //Adiona o titulo da planilha
                            for (int i = 1; i < datagridview.Columns.Count + 1; i++)
                            {
                                XcelApp.Cells[1, i] = datagridview.Columns[i - 1].HeaderText;
                            }

                            for (int i = 0; i < datagridview.Rows.Count - 1; i++)
                            {
                                for (int j = 0; j < datagridview.Columns.Count; j++)
                                {
                                    XcelApp.Cells[i + 2, j + 1] = datagridview.Rows[i].Cells[j].Value.ToString();

                                }
                            }



                            XcelApp.Columns.AutoFit();
                            XcelApp.Visible = true;
                        }

                        catch (Exception)
                        {
                            //MessageBox.Show("Erro ao exporta : " + ex.Message);
                            XcelApp.Quit();
                        }

                    }
                }
                catch (System.Runtime.InteropServices.COMException)
                {

                }

            }

            MessageBox.Show("Relatório Exportado", "Sistema - Robo");
        }

        public void ImportTxt_ponto_virgular(DataGridView dataGridView)
        {
            string rota = "";
            string line;

            OpenFileDialog openfile1 = new OpenFileDialog();
            if (openfile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (openfile1.FileName.Equals("") == false)
                {
                    rota = openfile1.FileName;
                }
            }
            else
            {
                return;
            }

            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(rota, Encoding.GetEncoding("iso-8859-1"));
            while ((line = file.ReadLine()) != null)
            {

                try
                {
                    string[] dados = line.Split(';');

                    if (dados.Count() == 1)
                    {
                        dataGridView.Rows.Add(dados[0]);
                    }
                    if (dados.Count() == 2)
                    {
                        dataGridView.Rows.Add(dados[0], dados[1]);
                    }
                    if (dados.Count() == 3)
                    {
                        dataGridView.Rows.Add(dados[0], dados[1], dados[2]);
                    }
                    if (dados.Count() == 4)
                    {
                        dataGridView.Rows.Add(dados[0], dados[1], dados[2], dados[3]);
                    }
                    if (dados.Count() == 5)
                    {
                        dataGridView.Rows.Add(dados[0], dados[1], dados[2], dados[3], dados[4]);
                    }
                    if (dados.Count() == 6)
                    {
                        dataGridView.Rows.Add(dados[0], dados[1], dados[2], dados[3], dados[4], dados[5]);
                    }
                    if (dados.Count() == 7)
                    {
                        dataGridView.Rows.Add(dados[0], dados[1], dados[2], dados[3], dados[4], dados[5], dados[6]);
                    }
                    if (dados.Count() == 8)
                    {
                        dataGridView.Rows.Add(dados[0], dados[1], dados[2], dados[3], dados[4], dados[5], dados[6], dados[7]);
                    }
                    if (dados.Count() == 9)
                    {
                        dataGridView.Rows.Add(dados[0], dados[1], dados[2], dados[3], dados[4], dados[5], dados[6], dados[7], dados[8]);
                    }
                    if (dados.Count() == 10)
                    {
                        dataGridView.Rows.Add(dados[0], dados[1], dados[2], dados[3], dados[4], dados[5], dados[6], dados[7], dados[8], dados[9]);
                    }
                    if (dados.Count() == 11)
                    {
                        dataGridView.Rows.Add(dados[0], dados[1], dados[2], dados[3], dados[4], dados[5], dados[6], dados[7], dados[8], dados[9], dados[10]);
                    }
                    if (dados.Count() == 12)
                    {
                        dataGridView.Rows.Add(dados[0], dados[1], dados[2], dados[3], dados[4], dados[5], dados[6], dados[7], dados[8], dados[9], dados[10], dados[11]);
                    }
                    if (dados.Count() == 13)
                    {
                        dataGridView.Rows.Add(dados[0], dados[1], dados[2], dados[3], dados[4], dados[5], dados[6], dados[7], dados[8], dados[9], dados[10], dados[11], dados[12]);
                    }
                    if (dados.Count() == 14)
                    {
                        dataGridView.Rows.Add(dados[0], dados[1], dados[2], dados[3], dados[4], dados[5], dados[6], dados[7], dados[8], dados[9], dados[10], dados[11], dados[12], dados[13]);
                    }
                    if (dados.Count() == 15)
                    {
                        dataGridView.Rows.Add(dados[0], dados[1], dados[2], dados[3], dados[4], dados[5], dados[6], dados[7], dados[8], dados[9], dados[10], dados[11], dados[12], dados[13], dados[14]);
                    }
                    if (dados.Count() == 16)
                    {
                        dataGridView.Rows.Add(dados[0], dados[1], dados[2], dados[3], dados[4], dados[5], dados[6], dados[7], dados[8], dados[9], dados[10], dados[11], dados[12], dados[13], dados[14], dados[15]);
                    }
                    if (dados.Count() == 17)
                    {
                        dataGridView.Rows.Add(dados[0], dados[1], dados[2], dados[3], dados[4], dados[5], dados[6], dados[7], dados[8], dados[9], dados[10], dados[11], dados[12], dados[13], dados[14], dados[15], dados[16]);
                    }
                    if (dados.Count() == 18)
                    {
                        dataGridView.Rows.Add(dados[0], dados[1], dados[2], dados[3], dados[4], dados[5], dados[6], dados[7], dados[8], dados[9], dados[10], dados[11], dados[12], dados[13], dados[14], dados[15], dados[16], dados[17]);
                    }

                }
                catch (Exception ex)
                {
                    string erro = ex.ToString();
                }


            }
        }

        public void ImportTxt_virgular(DataGridView dataGridView)
        {
            string rota = "";
            string line;

            OpenFileDialog openfile1 = new OpenFileDialog();
            if (openfile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (openfile1.FileName.Equals("") == false)
                {
                    rota = openfile1.FileName;
                }
            }
            else
            {
                return;
            }

            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(rota, Encoding.GetEncoding("iso-8859-1"));
            while ((line = file.ReadLine()) != null)
            {

                try
                {
                    string[] dados = line.Split(',');

                    if (dados.Count() == 1)
                    {
                        dataGridView.Rows.Add(dados[0]);
                    }
                    if (dados.Count() == 2)
                    {
                        dataGridView.Rows.Add(dados[0], dados[1]);
                    }
                    if (dados.Count() == 3)
                    {
                        dataGridView.Rows.Add(dados[0], dados[1], dados[2]);
                    }
                    if (dados.Count() == 4)
                    {
                        dataGridView.Rows.Add(dados[0], dados[1], dados[2], dados[3]);
                    }
                    if (dados.Count() == 5)
                    {
                        dataGridView.Rows.Add(dados[0], dados[1], dados[2], dados[3], dados[4]);
                    }
                    if (dados.Count() == 6)
                    {
                        dataGridView.Rows.Add(dados[0], dados[1], dados[2], dados[3], dados[4], dados[5]);
                    }
                    if (dados.Count() == 7)
                    {
                        dataGridView.Rows.Add(dados[0], dados[1], dados[2], dados[3], dados[4], dados[5], dados[6]);
                    }
                    if (dados.Count() == 8)
                    {
                        dataGridView.Rows.Add(dados[0], dados[1], dados[2], dados[3], dados[4], dados[5], dados[6], dados[7]);
                    }
                    if (dados.Count() == 9)
                    {
                        dataGridView.Rows.Add(dados[0], dados[1], dados[2], dados[3], dados[4], dados[5], dados[6], dados[7], dados[8]);
                    }
                    if (dados.Count() == 10)
                    {
                        dataGridView.Rows.Add(dados[0], dados[1], dados[2], dados[3], dados[4], dados[5], dados[6], dados[7], dados[8], dados[9]);
                    }
                    if (dados.Count() == 11)
                    {
                        dataGridView.Rows.Add(dados[0], dados[1], dados[2], dados[3], dados[4], dados[5], dados[6], dados[7], dados[8], dados[9], dados[10]);
                    }
                    if (dados.Count() == 12)
                    {
                        dataGridView.Rows.Add(dados[0], dados[1], dados[2], dados[3], dados[4], dados[5], dados[6], dados[7], dados[8], dados[9], dados[10], dados[11]);
                    }
                    if (dados.Count() == 13)
                    {
                        dataGridView.Rows.Add(dados[0], dados[1], dados[2], dados[3], dados[4], dados[5], dados[6], dados[7], dados[8], dados[9], dados[10], dados[11], dados[12]);
                    }
                    if (dados.Count() == 14)
                    {
                        dataGridView.Rows.Add(dados[0], dados[1], dados[2], dados[3], dados[4], dados[5], dados[6], dados[7], dados[8], dados[9], dados[10], dados[11], dados[12], dados[13]);
                    }
                    if (dados.Count() == 15)
                    {
                        dataGridView.Rows.Add(dados[0], dados[1], dados[2], dados[3], dados[4], dados[5], dados[6], dados[7], dados[8], dados[9], dados[10], dados[11], dados[12], dados[13], dados[14]);
                    }
                    if (dados.Count() == 16)
                    {
                        dataGridView.Rows.Add(dados[0], dados[1], dados[2], dados[3], dados[4], dados[5], dados[6], dados[7], dados[8], dados[9], dados[10], dados[11], dados[12], dados[13], dados[14], dados[15]);
                    }
                    if (dados.Count() == 17)
                    {
                        dataGridView.Rows.Add(dados[0], dados[1], dados[2], dados[3], dados[4], dados[5], dados[6], dados[7], dados[8], dados[9], dados[10], dados[11], dados[12], dados[13], dados[14], dados[15], dados[16]);
                    }
                    if (dados.Count() == 18)
                    {
                        dataGridView.Rows.Add(dados[0], dados[1], dados[2], dados[3], dados[4], dados[5], dados[6], dados[7], dados[8], dados[9], dados[10], dados[11], dados[12], dados[13], dados[14], dados[15], dados[16], dados[17]);
                    }

                }
                catch (Exception ex)
                {
                    string erro = ex.ToString();
                }


            }
        }

        public void ImportarExcel_2(DataGridView datagridview, String Nome_Arquivo)
        {
            string rota = "";
            try
            {
                OpenFileDialog openfile1 = new OpenFileDialog();
                openfile1.Filter = "Excel Files | *.xlsx";
                openfile1.Title = "Selecione o arquivo Excel base";
                if (openfile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openfile1.FileName.Equals("") == false)
                    {
                        rota = openfile1.FileName;
                    }
                }

                System.Threading.Thread.Sleep(3000);

                conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source=" + rota + ";Extended Properties='Excel 12.0 Xml;HDR=Yes'");
                MyDataAdapter = new OleDbDataAdapter("Select * from [" + Nome_Arquivo + "$]", conn);
                dt = new DataTable();
                MyDataAdapter.Fill(dt);


                //datagridview.DataSource = dt;

                foreach (DataRow dados in dt.Rows)
                {
                    datagridview.Rows.Add(dados.ItemArray);
                }

                System.Threading.Thread.Sleep(3000);
            }

            catch (Exception e)
            {
                MessageBox.Show("Erro ao Subir Arquivo Excel " + e.ToString(), "Erro de Importação");
            }

        }

        public async Task ImportCSV(DataGridView dataGridView)
        {
            int linha = 0;
            string rota = "";
            string line;

            OpenFileDialog openfile1 = new OpenFileDialog();
            if (openfile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (openfile1.FileName.Equals("") == false)
                {
                    rota = openfile1.FileName;
                }
            }
            else
            {
                return;
            }

            // Read the file and display it line by line.  
            System.IO.StreamReader file = new System.IO.StreamReader(rota);
            while ((line = file.ReadLine()) != null)
            {
                if (linha != 0)
                {

                    try
                    {
                        string[] dados = line.Split(';');

                        if (dados.Count() == 1)
                        {
                            dataGridView.Rows.Add(dados[0]);
                        }
                        if (dados.Count() == 2)
                        {
                            dataGridView.Rows.Add(dados[0], dados[1]);
                        }
                        if (dados.Count() == 3)
                        {
                            dataGridView.Rows.Add(dados[0], dados[1], dados[2]);
                        }
                        if (dados.Count() == 4)
                        {
                            dataGridView.Rows.Add(dados[0], dados[1], dados[2], dados[3]);
                        }
                        if (dados.Count() == 5)
                        {
                            dataGridView.Rows.Add(dados[0], dados[1], dados[2], dados[3], dados[4]);
                        }
                        if (dados.Count() == 6)
                        {
                            dataGridView.Rows.Add(dados[0], dados[1], dados[2], dados[3], dados[4], dados[5]);
                        }
                        if (dados.Count() == 7)
                        {
                            dataGridView.Rows.Add(dados[0], dados[1], dados[2], dados[3], dados[4], dados[5], dados[6]);
                        }
                        if (dados.Count() == 8)
                        {
                            dataGridView.Rows.Add(dados[0], dados[1], dados[2], dados[3], dados[4], dados[5], dados[6], dados[7]);
                        }
                        if (dados.Count() == 9)
                        {
                            dataGridView.Rows.Add(dados[0], dados[1], dados[2], dados[3], dados[4], dados[5], dados[6], dados[7], dados[8]);
                        }
                        if (dados.Count() == 10)
                        {
                            dataGridView.Rows.Add(dados[0], dados[1], dados[2], dados[3], dados[4], dados[5], dados[6], dados[7], dados[8], dados[9]);
                        }
                        if (dados.Count() == 11)
                        {
                            dataGridView.Rows.Add(dados[0], dados[1], dados[2], dados[3], dados[4], dados[5], dados[6], dados[7], dados[8], dados[9], dados[10]);
                        }
                        if (dados.Count() == 12)
                        {
                            dataGridView.Rows.Add(dados[0], dados[1], dados[2], dados[3], dados[4], dados[5], dados[6], dados[7], dados[8], dados[9], dados[10], dados[11]);
                        }
                        if (dados.Count() == 13)
                        {
                            dataGridView.Rows.Add(dados[0], dados[1], dados[2], dados[3], dados[4], dados[5], dados[6], dados[7], dados[8], dados[9], dados[10], dados[11], dados[12]);
                        }
                        if (dados.Count() == 14)
                        {
                            dataGridView.Rows.Add(dados[0], dados[1], dados[2], dados[3], dados[4], dados[5], dados[6], dados[7], dados[8], dados[9], dados[10], dados[11], dados[12], dados[13]);
                        }
                        if (dados.Count() == 15)
                        {
                            dataGridView.Rows.Add(dados[0], dados[1], dados[2], dados[3], dados[4], dados[5], dados[6], dados[7], dados[8], dados[9], dados[10], dados[11], dados[12], dados[13], dados[14]);
                        }
                        if (dados.Count() == 16)
                        {
                            dataGridView.Rows.Add(dados[0], dados[1], dados[2], dados[3], dados[4], dados[5], dados[6], dados[7], dados[8], dados[9], dados[10], dados[11], dados[12], dados[13], dados[14], dados[15]);
                        }
                        if (dados.Count() == 17)
                        {
                            dataGridView.Rows.Add(dados[0], dados[1], dados[2], dados[3], dados[4], dados[5], dados[6], dados[7], dados[8], dados[9], dados[10], dados[11], dados[12], dados[13], dados[14], dados[15], dados[16]);
                        }
                        if (dados.Count() == 18)
                        {
                            dataGridView.Rows.Add(dados[0], dados[1], dados[2], dados[3], dados[4], dados[5], dados[6], dados[7], dados[8], dados[9], dados[10], dados[11], dados[12], dados[13], dados[14], dados[15], dados[16], dados[17]);
                        }
                    }
                    catch (Exception ex)
                    {
                        string erro = ex.ToString();
                    }

                }

                linha += 1;

            }


        }

    }
}
