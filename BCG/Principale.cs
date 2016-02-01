﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Core;
using System.Reflection;
using Microsoft.Win32;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace BCG
{
    public partial class Principale : Form
    {
        BindingList<Matrice> Points = new BindingList<Matrice>();
        BindingSource bindingSource = new BindingSource();
        private string Excel03ConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        private string Excel07ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        public Principale()
        {
            InitializeComponent();
            remplissageTableur(10);
            actualiserTableur(Points);
            chartBCG.ChartAreas[0].AxisX.Crossing = 0;
            for(int i = 0; i < Points.Count; i++)
            {
                
            }
            
        }
        private void remplissageTableur(int taille)
        {
            for (int i = 0; i < taille; i++)
            {
                Points.Add(new Matrice());
            }
        }
        private void actualiserTableur(BindingList<Matrice> Points)
        {
            bindingSource.DataSource = Points;
            dgvTableur.AutoGenerateColumns = true;
            dgvTableur.DataSource = bindingSource;
        }
        
        private void présentationEtModeDemploiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Aide().ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new Apropos().ShowDialog();
        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ofdExcel.Filter = "Excel Worsheets (*.xls, *.xlsx)|*.xls;*.xlsx";
                ofdExcel.ShowDialog();
                string filePath = ofdExcel.FileName;
                string extension = Path.GetExtension(filePath);
                string header = "YES";
                string conStr, sheetName;

                conStr = string.Empty;
                switch (extension)
                {

                    case ".xls": //Excel 97-03
                        conStr = string.Format(Excel03ConString, filePath, header);
                        break;

                    case ".xlsx": //Excel 07
                        conStr = string.Format(Excel07ConString, filePath, header);
                        break;
                }

                using (OleDbConnection con = new OleDbConnection(conStr))
                {
                    using (OleDbCommand cmd = new OleDbCommand())
                    {
                        cmd.Connection = con;
                        con.Open();
                        DataTable dtExcelSchema = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                        sheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();
                        con.Close();
                    }
                }
                using (OleDbConnection con = new OleDbConnection(conStr))
                {
                    using (OleDbCommand cmd = new OleDbCommand())
                    {
                        using (OleDbDataAdapter oda = new OleDbDataAdapter())
                        {
                            DataTable dt = new DataTable();
                            cmd.CommandText = "SELECT * From [" + sheetName + "]";
                            cmd.Connection = con;
                            con.Open();
                            oda.SelectCommand = cmd;
                            oda.Fill(dt);
                            con.Close();
                            dgvTableur.DataSource = dt;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void rAZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Points.Clear();
        }

        private void testerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Points.Count >= 4)
                {
                    Points[0] = new Matrice("A", 25, 20, 18, 10);
                    Points[1] = new Matrice("B", 20, 30, 12, 10);
                    Points[2] = new Matrice("C", 12, 30, 5, 15);
                    Points[3] = new Matrice("D", 59, 12, 7, 40);
                }
                else
                {
                    Points.Add(new Matrice("A", 25, 20, 18, 10));
                    Points.Add(new Matrice("B", 20, 30, 12, 10));
                    Points.Add(new Matrice("C", 12, 30, 5, 15));
                    Points.Add(new Matrice("D", 59, 12, 7, 40));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

}

        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Excel.Application xlApp;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;

                xlApp = new Excel.Application();
                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                int i = 0;
                int j = 0;

                for (i = 0; i <= dgvTableur.RowCount - 1; i++)
                {
                    for (j = 0; j <= dgvTableur.ColumnCount - 1; j++)
                    {
                        DataGridViewCell cell = dgvTableur[j, i];
                        xlWorkSheet.Cells[i + 1, j + 1] = cell.Value;
                    }
                }
                sfdTableur.Filter = "Excel Worsheets (*.xls, *.xlsx)|*.xls;*.xlsx";
                sfdTableur.ShowDialog();
                xlWorkBook.SaveAs(sfdTableur.FileName);
                //xlWorkBook.SaveAs("maMatriceBCG.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlApp);

                MessageBox.Show("Fichier excel créé , vous pouvez trouver le fichier à " + sfdTableur.FileName);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }
        /// <summary>
        /// Fonction de libération des objets
        /// </summary>
        /// <param name="obj"></param>
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

<<<<<<< HEAD
        private void dgvTableur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

=======
        private void btnGenerer_Click(object sender, EventArgs e)
        {
            try
            {
                chartBCG.Visible = true;

                for (int i = 0; i < 4; i++)
                {
                    chartBCG.Series.Add(Points[i].Activite);
                    chartBCG.Series[Points[i].Activite].ChartType = SeriesChartType.Bubble;
                    chartBCG.Series[Points[i].Activite].Points.Add(Math.Log(Points[i].PDMproduit / Points[i].PDMconct), Points[i].TxCroiss, Points[i].PartProduit);
                }
                chartBCG.DataBind();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            try
            {
                Points.Add(new Matrice());
                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            try
            {
                Points[dgvTableur.CurrentRow.Index]=(Matrice)dgvTableur.CurrentRow.DataBoundItem;
                MessageBox.Show(Points[dgvTableur.CurrentRow.Index].toString());
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
>>>>>>> refs/remotes/origin/dev
        }
    }
}
