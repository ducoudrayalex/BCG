using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using System.Reflection;
using System.Drawing;
using System.Collections.Generic;
using System.Collections;

namespace BCG
{
    public partial class Principale : Form
    {
        ///<summary>La liste de matrice représentant les lignes du tableur</summary> 
        BindingList<Matrice> Points;

        double min;
        double max;

        /// <summary>
        /// Variable propres à la définition du graphique
        /// </summary>
        Series series1;
        DataPoint dataPoint1;
        ChartArea chartArea1;

        /// <summary>
        /// Instance de la classe BindingSource servant à lier les objets Matrice au tableur
        /// </summary>
        BindingSource bindingSource;

        /// <summary>
        /// Colonne de combobox pour la sélection des couleurs
        /// </summary>
        DataGridViewComboBoxColumn couleur;
        /// <summary>
        /// Instance de la classe CopierColler contenant les méthodes pour couper,copier et coller les données du presse papier depuis excel vers le tableur
        /// </summary>
        CopierColler cc;

        private int rowIndex = 0;

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
            try
            {
                InitializeComponent();
                this.Size = new Size(Screen.PrimaryScreen.Bounds.Width*75/100, Screen.PrimaryScreen.Bounds.Height*75/100);
                this.CenterToScreen();
                responsiveDesign();
                Points = new BindingList<Matrice>();
                cc = new CopierColler();
                couleur = new DataGridViewComboBoxColumn();
                bindingSource = new BindingSource();
                chartArea1 = new ChartArea();
                dataPoint1 = new DataPoint(10, 10);
                series1 = new Series();
                pnlChartLbl.Controls.Add(lblDilemme);
                pnlChartLbl.Controls.Add(lblPoidsMort);
                pnlChartLbl.Controls.Add(lblVacheALait);
                pnlChartLbl.Controls.Add(lblVedette);
                chartBCG.SendToBack();
                lblDilemme.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                lblPoidsMort.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
                lblVedette.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                lblVacheALait.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
                ArrayList listecouleur = new ArrayList() { "Bleu", "Rouge", "Vert", "Noir","Marron", "Jaune","Orange","Rose","Gris","Violet"};
                couleur.DataSource = listecouleur;
                couleur.HeaderText = "Couleur";
                couleur.Name = "Couleur";
                couleur.DataPropertyName = "Couleur";
                actualiserTableur(Points);
                dgvTableur.Columns[0].ToolTipText = "Produit";
                dgvTableur.Columns[1].ToolTipText = "Chiffre d'affaire";
                dgvTableur.Columns[2].ToolTipText = "Chiffre d'affaire concurrence";
                dgvTableur.Columns[3].ToolTipText = "Taux de croissance du produit";
                dgvTableur.Columns[4].ToolTipText = "Part du produit sur le marché";
                dgvTableur.Columns["couleur"].ToolTipText = "Choix de la couleur";
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }          
        }

        /// <summary>
        /// Définit les propiètés en fonction de la taille de la form
        /// </summary>
        public void responsiveDesign()
        {
            try
            {
                dgvTableur.Size = new Size(this.Size.Width * 45 / 100, this.Size.Height * 70 / 100);
                pnlChartLbl.Size = new Size(this.Size.Width * 45 / 100, this.Size.Height * 70 / 100);
                pnlChartLbl.Location = new Point(dgvTableur.Size.Width + 30, pnlChartLbl.Location.Y);
                tlpBouton.Location = new Point(tlpBouton.Location.X, dgvTableur.Size.Height + 50);
                pnlLegend.Location = new Point(pnlChartLbl.Location.X, pnlChartLbl.Size.Height + 45);
                dgvTableur.MinimumSize = tlpBouton.Size;
                pnlChartLbl.MinimumSize = new Size(300, 300);
                chartBCG.Size = pnlChartLbl.Size;
                tlpBouton.Size = new Size(pnlChartLbl.Size.Width, tlpBouton.Size.Height);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
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
                if(dgvTableur.Columns.Contains(couleur))
                    dgvTableur.Columns.Remove(couleur);
                bindingSource.DataSource = Points;
                dgvTableur.DataSource = bindingSource;
                dgvTableur.AutoGenerateColumns = true;
                btnAjout.Enabled = true;
                if(!dgvTableur.Columns.Contains(couleur))
                    dgvTableur.Columns.Add(couleur);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }          
        }

        /// <summary>
        /// affiche la fenetre d'Aide et de presentation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void présentationEtModeDemploiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Aide().ShowDialog();
        }

        /// <summary>
        /// Affiche la fenetre a propos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new AboutBox().Show();
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
                Points.Clear();
                dgvTableur.Columns.Remove(couleur);
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

                dgvTableur.Columns.Add(couleur);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// quitte l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Vide le tableur et redéfini la datasourcede points
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rAZToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
                actualiserTableur(Points);
                               
                if (Points.Count >=5)
                {
                    Points[0] = new Matrice("iPhone", 30, 5, 60, 40);
                    Points[1] = new Matrice("iTunes", 20, 2.2F, 25, 15);
                    Points[2] = new Matrice("iPad", 9, 3, 5, 15);
                    Points[3] = new Matrice("iPod", 18, 3, -20, 10);
                    Points[4] = new Matrice("Mac", 10, 20, 3, 25);                
                }
                else
                {
                    Points.Add(new Matrice("iPhone", 30, 5, 60, 40));
                    Points.Add(new Matrice("iTunes", 20, 2.2F, 25, 15));
                    Points.Add(new Matrice("iPad", 9, 3, 5, 15));
                    Points.Add(new Matrice("iPod", 18, 3, -20, 10));
                    Points.Add(new Matrice("Mac", 10, 20, 3, 25));
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
                if (sfdTableur.ShowDialog() == DialogResult.OK)
                {
                    xlWorkBook.SaveAs(sfdTableur.FileName);
                    //xlWorkBook.SaveAs("maMatriceBCG.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                    xlWorkBook.Close(true, misValue, misValue);
                    xlApp.Quit();

                    releaseObject(xlWorkSheet);
                    releaseObject(xlWorkBook);
                    releaseObject(xlApp);
                }else
                {

                }           
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

        /// <summary>
        /// Calcul la valeur minimum de la colonne taux de croissance(txcroiss)
        /// </summary>
        /// <returns>retourn la valeur minimum min de type double</returns>
        private double min_axisY()
        {
            min = Points[0].TxCroiss;
            for (int i = 1; i < Points.Count-1; i++)
            {                
                if (min > Points[i].TxCroiss)
                    min = Points[i].TxCroiss;
                              
            }
            return min-4;
        }

        /// <summary>
        /// Calcul la valeur maximum de la colonne taux de croissance(txcroiss)
        /// </summary>
        /// <returns>retourn la valeur max de type double</returns>
        private double max_axisY()
        {
            max = Points[0].TxCroiss;
            for (int i = 1; i < Points.Count-1; i++)
            {                
                if (max < Points[i].TxCroiss)
                    max = Points[i].TxCroiss;               
            }
            return max+10;
        }

        /// <summary>
        /// Génération des axes du graphique et insertion des bulles représentant les activités et le résultat des données du tableur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenerer_Click(object sender, EventArgs e)
        {
            try
            {
                series1.Points.Clear();
                chartBCG.Series.Clear();
                chartBCG.ChartAreas.Clear();
                validationTableur();              
                chartArea1.AxisX.Crossing = 0.01;
                chartArea1.AxisX.IsLogarithmic = true;
                chartArea1.AxisX.IsReversed = true;
                chartArea1.AxisX.IsStartedFromZero = false;
                chartArea1.AxisX.Maximum = 10;
                chartArea1.AxisX.Minimum = 0.1;
                chartArea1.AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
                chartArea1.AxisX.Title = "X";
                chartArea1.AxisX.TitleAlignment = StringAlignment.Far;
                chartArea1.Name = "chartArea1";
                chartArea1.AxisY.Maximum = max_axisY();
                chartArea1.AxisY.Minimum = min_axisY();
                chartArea1.AxisY.Crossing = max / 2;
                chartArea1.AxisY.Interval = (max - min) / 5;
                chartArea1.AxisY.LabelStyle.Format = "#'%'";
                chartArea1.AxisY.Title = "Y";
                chartArea1.AxisY.TitleAlignment = StringAlignment.Far;
                series1.ChartArea = "chartArea1";
                series1.ChartType = SeriesChartType.Bubble;
                series1.IsVisibleInLegend = false;
                series1.Legend = "Legend1";
                series1.MarkerStyle = MarkerStyle.Circle;
                series1.Name = "Series1";
                dataPoint1.Color = Color.White;
                series1.Points.Add(dataPoint1);
                series1.YValuesPerPoint = 2;
                this.chartBCG.Series.Add(series1);
                chartBCG.ChartAreas.Add(chartArea1);
                chartArea1.AxisX.MajorGrid.Enabled = false;
                chartArea1.AxisY.MajorGrid.Enabled = false;
                chartArea1.AxisY.MajorTickMark.Enabled = false;
                for (int i = 0; i < Points.Count; i++)
                {
                    if (Points[i].Activite != "" && Points[i].PDMproduit!=0 && Points[i].PDMconcu!=0 && Points[i].PartProduit!=0 && Points[i].TxCroiss!=0)
                    {
                        chartBCG.Series.Add(Points[i].Activite);
                        chartBCG.Series[Points[i].Activite].ChartType = SeriesChartType.Bubble;
                        chartBCG.Series[Points[i].Activite].MarkerStyle = MarkerStyle.Circle;
                        chartBCG.Series[Points[i].Activite]["BubbleMaxSize"] = "25";
                        chartBCG.Series[Points[i].Activite]["BubbleMinSize"] = "1";
                        chartBCG.Series[Points[i].Activite].Points.AddXY((Points[i].PDMproduit / Points[i].PDMconcu), Points[i].TxCroiss, Points[i].PartProduit);
                        chartBCG.Series[Points[i].Activite].Label = Points[i].Activite;
                        string SelectedText = Convert.ToString(dgvTableur.Rows[i].Cells["Couleur"].FormattedValue.ToString());
                        changeCouleur(SelectedText, i);
                    }
                    else {
                        
                    }                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Change la couleur des points sur le graphique en fonction de la valeur de la combobox
        /// </summary>
        /// <param name="selectCouleur">Valeur de la cellule contenant la combobox</param>
        /// <param name="i">index de la ligne de la combobox</param>
        private void changeCouleur(string selectCouleur,int i)
        {
            switch (selectCouleur)
            {
                case "Bleu":
                    chartBCG.Series[Points[i].Activite].Color = Color.Blue;
                    break;
                case "Rouge":
                    chartBCG.Series[Points[i].Activite].Color = Color.Red;
                    break;
                case "Vert":
                    chartBCG.Series[Points[i].Activite].Color = Color.Green;
                    break;
                case "Noir":
                    chartBCG.Series[Points[i].Activite].Color = Color.Black;
                    break;
                case "Rose":
                    chartBCG.Series[Points[i].Activite].Color = Color.Pink;
                    break;
                case "Jaune":
                    chartBCG.Series[Points[i].Activite].Color = Color.Yellow;
                    break;
                case "Violet":
                    chartBCG.Series[Points[i].Activite].Color = Color.Purple;
                    break;
                case "Marron":
                    chartBCG.Series[Points[i].Activite].Color = Color.Brown;
                    break;
                case "Gris":
                    chartBCG.Series[Points[i].Activite].Color = Color.Silver;
                    break;
                case "Orange":
                    chartBCG.Series[Points[i].Activite].Color = Color.Orange;
                    break;
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
        /// Fill les données du tableur dans la bindinglist de matrice Points en fonction du datasource du tableur
        /// </summary>
        private void validationTableur()
        {
            try
            {
                if (dgvTableur.DataSource == bindingSource)
                {
                    if (Points.Count > 0)
                    {
                        for (int i = 0; i < dgvTableur.Rows.Count-1; i++)
                        {
                            Points[i] = (Matrice)dgvTableur.Rows[i].DataBoundItem;
                        }
                    }
                    else {
                        for (int i = 0; i < dgvTableur.Rows.Count-1; i++)
                        {
                            Points.Add((Matrice)dgvTableur.Rows[i].DataBoundItem);
                        }
                    }
                }
                else
                {
                    if (Points.Count > 0)
                    {
                        for (int i = 0; i < dgvTableur.Rows.Count-1; i++)
                        {

                            Points[i].Activite = dgvTableur.Rows[i].Cells[0].Value.ToString();
                            Points[i].PDMproduit = (float)Convert.ChangeType(dgvTableur.Rows[i].Cells[1].Value, typeof(float));
                            Points[i].PDMconcu = (float)Convert.ChangeType(dgvTableur.Rows[i].Cells[2].Value, typeof(float));
                            Points[i].TxCroiss = (float)Convert.ChangeType(dgvTableur.Rows[i].Cells[3].Value, typeof(float));
                            Points[i].PartProduit = (float)Convert.ChangeType(dgvTableur.Rows[i].Cells[4].Value, typeof(float));
                        }
                    }
                    else {
                        for (int i = 0; i < dgvTableur.Rows.Count-1; i++)
                        {

                            Points.Add(new Matrice(dgvTableur.Rows[i].Cells[0].Value.ToString(),
                            (float)Convert.ChangeType(dgvTableur.Rows[i].Cells[1].Value, typeof(float)),
                            (float)Convert.ChangeType(dgvTableur.Rows[i].Cells[2].Value, typeof(float)),
                            (float)Convert.ChangeType(dgvTableur.Rows[i].Cells[3].Value, typeof(float)),
                            (float)Convert.ChangeType(dgvTableur.Rows[i].Cells[4].Value, typeof(float))));

                        }
                    }
                }
            }
            catch (Exception ex)
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

        /// <summary>
        /// Coupe les valeurs selectionner du tableur et les copient dans le presse papier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Couper_Click(object sender, EventArgs e)
        {
            //Copie dans le presse papier
            cc.CopyToClipboard(dgvTableur);

            //vide les cellules selectionnées
            foreach (DataGridViewCell dgvCell in dgvTableur.SelectedCells)
                dgvCell.Value = 0;
        }

        /// <summary>
        /// Copie les valeurs dans le presse papier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Copier_Click(object sender, EventArgs e)
        {
            cc.CopyToClipboard(dgvTableur);
        }

        /// <summary>
        /// Colle les valeurs du presse papier dans le tableur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Coller_Click(object sender, EventArgs e)
        {
            cc.PasteClipboardValue(dgvTableur);
        }

        private void dgvTableur_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
                if (dgvTableur.SelectedCells.Count > 0) { 
                    dgvTableur.ContextMenuStrip = cmsPaste;
                    //this.dgvTableur.Rows[e.RowIndex].Selected = true;
                    
                    //this.dgvTableur.CurrentCell = this.dgvTableur.Rows[e.RowIndex].Cells[1];
                }
            this.rowIndex = e.RowIndex;
        }

        /// <summary>
        /// Affiche, suivant où l'on clique sur le graphique un message explicatif de la zone 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chartBCG_MouseClick(object sender, MouseEventArgs e)
        {
            Chart c = (Chart)sender;
            int X = c.Location.X;
            int Y = c.Location.Y;
            int mX = e.Location.X;
            int mY = e.Location.Y;

            if( (e.Button == MouseButtons.Left) && ((mX >= 0 && mX <= chartBCG.Size.Width/2) && (mY >= 0 && mY <= chartBCG.Size.Height / 4)))
                MessageBox.Show("STARS :\n\nPart de marché relative élevée sur un marché en forte croissance. Fort besoin de liquidité pour continuer la croissance (ex : les smartphones pour Samsung).");

            if ((e.Button == MouseButtons.Left) && ((mX > chartBCG.Size.Width / 2 && mX < chartBCG.Size.Width) && (mY >= 0 && mY <= chartBCG.Size.Height/4)))
                MessageBox.Show("DILEMMES :\n\nPart de marché relative faible sur un marché en croissance élevée. Peu rentable, voire déficitaire en termes de flux financiers, nécessite des investissements importants pour l'acquisition d'une bonne part de marché relative afin de ne pas devenir des poids morts (ex : Free mobile dans le portefeuille d'activités d'Iliad).");

            if ((e.Button == MouseButtons.Left) && ((mX > chartBCG.Size.Width / 2 && mX < chartBCG.Size.Width) && (mY >= chartBCG.Size.Height*3 / 4 && mY <= chartBCG.Size.Height)))
                MessageBox.Show("POIDS MORTS: \n\nPart de marché relative faible sur un marché en faible croissance. Faible potentiel de développement, peu consommateur de capitaux, ne dégage pas de flux financiers stables, faible rentabilité voire nulle ou négative (ex : Ma ligne Visio, offre visiophonie dans le portefeuille d'activités de France Telecom).");

            if ((e.Button == MouseButtons.Left) && ((mX > 0 && mX < chartBCG.Size.Width / 2) && ( mY >= chartBCG.Size.Height * 3 / 4 && mY <= chartBCG.Size.Height)))
                MessageBox.Show("VACHE A LAIT: \n\nPart de marché relative élevée sur un marché en faible croissance, en phase de maturité ou en déclin. Exigeant peu d'investissements nouveaux et dégageant des flux financiers importants qui devront être réinvesti intelligemment sur les vedettes et les dilemmes (ex : la Freebox dans le portefeuille d'activités d'Iliad).");

        }

        private void Principale_FormClosed(object sender, FormClosedEventArgs e)
        {
            string message = "Voulez-vous sauvegarder votre travail ?";
            string caption = "Quitter l'application";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message,caption, buttons);

            if (result == DialogResult.Yes)
            {
                enregistrerToolStripMenuItem_Click(sender,e);
                Application.Exit();
            }
            else
            {
                Application.Exit();
            }
            
        }

        /// <summary>
        /// Agrandissement du tableur dans une fentre 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private void Principale_Load(object sender, EventArgs e)
        {

        }

        private void Principale_SizeChanged(object sender, EventArgs e)
        {
            responsiveDesign();
        }

        /// <summary>
        /// Supprime la ligne sélectionnée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void supprimerLaLigneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.dgvTableur.Rows[this.rowIndex].IsNewRow)
            {

                this.dgvTableur.Rows.RemoveAt(this.rowIndex);
                validationTableur();
            }
        }

        private void sfdTableur_FileOk(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Fichier excel créé , vous pouvez trouver le fichier à " + sfdTableur.FileName);
        }
    }

}
