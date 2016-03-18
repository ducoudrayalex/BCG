using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using System.Reflection;

namespace BCG
{
    public partial class Principale : Form
    {
        ///<summary>La liste de matrice représentant les lignes du tableur</summary> 
        BindingList<Matrice> Points;
        
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
            //remplissageTableur(10);
            Points = new BindingList<Matrice>();
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
            try
            {
                Points.Clear();
                bindingSource.DataSource = Points;
                dgvTableur.AutoGenerateColumns = true;
                dgvTableur.DataSource = bindingSource;
                btnAjout.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }          
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
                btnAjout.Enabled = false;
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
            actualiserTableur(Points);
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
                if (dgvTableur.DataSource != Points)
                {
                    actualiserTableur(Points);
                }
                
                if (Points.Count >=4)
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
                MessageBox.Show("Erreur lors de la libération de l'objet : " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void dgvTableur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnGenerer_Click(object sender, EventArgs e)
        {

            chartBCG.Series.Clear();
            //chartBCG.Visible = true;
            try
            {
                for (int i = 0; i < 4; i++)
                {
                    chartBCG.Series.Add(Points[i].Activite);
                    chartBCG.Series[Points[i].Activite].ChartType = SeriesChartType.Bubble;
                    chartBCG.Series[Points[i].Activite].MarkerStyle = MarkerStyle.Circle;
                    chartBCG.Series[Points[i].Activite]["BubbleMaxSize"] = "25";
                    chartBCG.Series[Points[i].Activite]["BubbleMinSize"] = "10";
                    // chartBCG.Series[Points[i].Activite]["BubbleScaleMax"] = "auto";


                    // chartBCG.Series[Points[i].Activite].Points.Add(x, y, z);

                    chartBCG.Series[Points[i].Activite].Points.AddXY((Points[i].PDMproduit / Points[i].PDMconct), Points[i].TxCroiss, Points[i].PartProduit);
                    chartBCG.Series[Points[i].Activite].Label = "Prod." + Points[i].Activite;
                }
                //chartBCG.DataBind();

            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(ex.Message);
            }
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
            }catch (Exception ex)
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
                if (dgvTableur.DataSource == bindingSource)
                {
                    if (Points.Count > 0)
                    {
                        for (int i = 0; i < dgvTableur.Rows.Count - 2; i++)
                        {
                            Points[i] = (Matrice)dgvTableur.Rows[i].DataBoundItem;
                        }
                    }
                    else {
                        for (int i = 0; i < dgvTableur.Rows.Count - 2; i++)
                        {
                            Points.Add((Matrice)dgvTableur.Rows[i].DataBoundItem);
                        }
                    }
                }
                else
                {
                    if (Points.Count > 0)
                    {
                        for (int i = 0; i < dgvTableur.Rows.Count - 2; i++)
                        {

                            Points[i].Activite = dgvTableur.Rows[i].Cells[0].Value.ToString();
                            Points[i].PDMproduit = (float)Convert.ChangeType(dgvTableur.Rows[i].Cells[1].Value, typeof(float));
                            Points[i].PDMconct = (float)Convert.ChangeType(dgvTableur.Rows[i].Cells[2].Value, typeof(float));
                            Points[i].TxCroiss = (float)Convert.ChangeType(dgvTableur.Rows[i].Cells[3].Value, typeof(float));
                            Points[i].PartProduit = (float)Convert.ChangeType(dgvTableur.Rows[i].Cells[4].Value, typeof(float));
                        }
                    }
                    else {
                        for (int i = 0; i < dgvTableur.Rows.Count - 2; i++)
                        {

                            Points.Add(new Matrice(dgvTableur.Rows[i].Cells[0].Value.ToString(),
                            (float)Convert.ChangeType(dgvTableur.Rows[i].Cells[1].Value, typeof(float)),
                            (float)Convert.ChangeType(dgvTableur.Rows[i].Cells[2].Value, typeof(float)),
                            (float)Convert.ChangeType(dgvTableur.Rows[i].Cells[3].Value, typeof(float)),
                            (float)Convert.ChangeType(dgvTableur.Rows[i].Cells[4].Value, typeof(float))));

                        }
                    }                 
                }
                BtnValider.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            //Copie dans le presse papier
            cc.CopyToClipboard(dgvTableur);

            //vide les cellules selectionnées
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

        private void dgvTableur_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            BtnValider.Enabled = true;
        }

//============================================================================================================//

        private void chartBCG_MouseClick(object sender, MouseEventArgs e)
         {
            if ( (e.Button ==  MouseButtons.Left) && (e.X >= 442 && e.X <= 602) && (e.Y >= 27 && e.Y <= 184) )
                MessageBox.Show("VEDETTES !!!!!");
         }
//============================================================================================================//

        private void Principale_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void agrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agrandir agr=new Agrandir();
            
            DataGridView dgvAgr = new DataGridView();
            bindingSource.DataSource = Points;
            dgvAgr.AutoGenerateColumns = true;
            dgvAgr.DataSource = bindingSource;
            dgvAgr.Size=agr.Size;
            dgvAgr.DataError += dgvTableur_DataError;
            dgvAgr.DefaultCellStyle.Font = new System.Drawing.Font("Georgia", 14);
            dgvAgr.ColumnHeadersDefaultCellStyle.Font=new System.Drawing.Font("Georgia",15);
            dgvAgr.ColumnHeadersHeight = 30;
            dgvAgr.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvAgr.Enabled = true;
            dgvAgr.MultiSelect = true;
            dgvAgr.ReadOnly = false;
            dgvAgr.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvAgr.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            agr.Controls.Add(dgvAgr);
            agr.Show();
        }
        public DataGridViewRow CloneWithValues(DataGridViewRow row)
        {
            DataGridViewRow clonedRow = (DataGridViewRow)row.Clone();
            for (Int32 index = 0; index < row.Cells.Count; index++)
            {
                clonedRow.Cells[index].Value = row.Cells[index].Value;
            }
            return clonedRow;
        }

        private void agrandirMatriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agrandir agr = new Agrandir();

        }
    }
}
