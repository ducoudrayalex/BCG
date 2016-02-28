using System;
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
using System.Text.RegularExpressions;

namespace BCG
{
    public partial class Principale : Form
    {
        ///<summary>La liste de matrice représentant les lignes du tableur</summary> 
        BindingList<Matrice> Points = new BindingList<Matrice>();
        /// <summary>
        /// Instance de la classe BindingSource servant à lier les objets Matrice au tableur
        /// </summary>
        BindingSource bindingSource = new BindingSource();
        /// <summary>
        /// Instance de la classe CopierColler contenant les méthodes pour couper,copier et coller les données du presse papier depuis excel vers le tableur
        /// </summary>
        CopierColler cc = new CopierColler();
        /// <summary>
        /// Variables nécessaires à l'ouverture d'un fichier excel dans le tableur (version etc...)
        /// </summary>
        private string Excel03ConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        private string Excel07ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        /// <summary>
        /// Constructeur de la forme Principale
        /// </summary>
        public Principale()
        {
            InitializeComponent();
            remplissageTableur(10);
            actualiserTableur(Points);
        }
        /// <summary>
        /// Remplit le tableur d'objet matrice initialisé à 0
        /// </summary>
        /// <param name="nbLigne">Nombre de ligne à insérer dans le tableur</param>
        private void remplissageTableur(int nbLigne)
        {
            for (int i = 0; i < nbLigne; i++)
            {
                Points.Add(new Matrice());
            }
        }
        /// <summary>
        /// Lie la liste de matrice au tableur en définissant la propriété datasource du tableur avec une Bindinglist
        /// </summary>
        /// <param name="Points"></param>
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
        /// <summary>
        /// Ouvre une boite de dialogue pour chercher un fichier excel à insérer dans le tableur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            catch (Exception ex)
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
        /// <summary>
        /// Crée des objets matrice avec des valeurs de test
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    Points.Add(new Matrice("D", 59, 12, 7, 20));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// Enregistre le tableur dans un fichier excel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            catch (Exception ex)
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

        private void btnGenerer_Click(object sender, EventArgs e)
        {
 
        }
        /// <summary>
        /// Ajoute une ligne au tableur en ajoutant un objet matrice vide
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjout_Click(object sender, EventArgs e)
        {
            try
            {
                Points.Add(new Matrice());

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// Insère les données saisies dans le tableur dans des objets matrice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValider_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dgvTableur.RowCount - 1; i++) {
                    if (Points[i] != null)
                    {
                        Points[i] = (Matrice)dgvTableur.Rows[i].DataBoundItem;
                    }
                    else Points.Add((Matrice)dgvTableur.Rows[i].DataBoundItem);

                }
                BtnValider.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur bouton valider : " + ex.Message);
            }
        }

        /// <summary>
        /// Ajoute l'évenement keydown control+v pour coller le presse papier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvTableur_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                cc.PasteClipboardValue(dgvTableur);
            }
        }
        /// <summary>
        /// Gère les erreurs DataError provenant des cellules du tableur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvTableur_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("DataError : " + e.Context.ToString());

            if (e.Context == DataGridViewDataErrorContexts.Commit)
            {
                MessageBox.Show("Validation impossible");
            }
            if (e.Context == DataGridViewDataErrorContexts.CurrentCellChange)
            {
                MessageBox.Show("Vous avez changé de cellule alors que la précédente contenait une erreur");
            }
            if (e.Context == DataGridViewDataErrorContexts.Parsing)
            {
                MessageBox.Show("Erreur lors de l'analyse des données(problème de conversion de type ?)");
            }
            if (e.Context == DataGridViewDataErrorContexts.LeaveControl)
            {
                MessageBox.Show("Erreur lorsque le controle a perdu le focus");
            }

            if ((e.Exception) is ConstraintException)
            {
                //DataGridView view = (DataGridView)sender;
                dgvTableur.Rows[e.RowIndex].ErrorText = "Erreur";
                dgvTableur.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "Erreur";

                e.ThrowException = false;
            }
        }

        private void Couper_Click(object sender, EventArgs e)
        {
            //Copy to clipboard
            cc.CopyToClipboard(dgvTableur);

            //Clear selected cells
            foreach (DataGridViewCell dgvCell in dgvTableur.SelectedCells)
                dgvCell.Value = 0;
        }

        private void Copier_Click(object sender, EventArgs e)
        {
            cc.CopyToClipboard(dgvTableur);
        }

        private void Coller_Click(object sender, EventArgs e)
        {
            cc.PasteClipboardValue(dgvTableur);
        }

        private void dgvTableur_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvTableur.SelectedCells.Count > 0)
                dgvTableur.ContextMenuStrip = cmsPaste;
        }

        private void dgvTableur_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            BtnValider.Enabled = true;
        }
    }
}
