namespace BCG
{
    partial class Principale
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(8D, "30,0");
            this.menuPrincipale = new System.Windows.Forms.MenuStrip();
            this.tsmiFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.rAZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affichageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agrandirMatriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.présentationEtModeDemploiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvTableur = new System.Windows.Forms.DataGridView();
            this.activiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDMproduitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDMconctDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txCroissDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partProduitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matriceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ofdExcel = new System.Windows.Forms.OpenFileDialog();
            this.sfdTableur = new System.Windows.Forms.SaveFileDialog();
            this.btnGenerer = new System.Windows.Forms.Button();
            this.btnAjout = new System.Windows.Forms.Button();
            this.BtnValider = new System.Windows.Forms.Button();
            this.chartBCG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuPrincipale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matriceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBCG)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPrincipale
            // 
            this.menuPrincipale.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFichier,
            this.affichageToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuPrincipale.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipale.Name = "menuPrincipale";
            this.menuPrincipale.Size = new System.Drawing.Size(784, 24);
            this.menuPrincipale.TabIndex = 0;
            this.menuPrincipale.Text = "menuPrincipale";
            // 
            // tsmiFichier
            // 
            this.tsmiFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rAZToolStripMenuItem,
            this.testerToolStripMenuItem,
            this.ouvrirToolStripMenuItem,
            this.enregistrerToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.tsmiFichier.Name = "tsmiFichier";
            this.tsmiFichier.Size = new System.Drawing.Size(54, 20);
            this.tsmiFichier.Text = "Fichier";
            // 
            // rAZToolStripMenuItem
            // 
            this.rAZToolStripMenuItem.Name = "rAZToolStripMenuItem";
            this.rAZToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.rAZToolStripMenuItem.Text = "RAZ";
            this.rAZToolStripMenuItem.Click += new System.EventHandler(this.rAZToolStripMenuItem_Click);
            // 
            // testerToolStripMenuItem
            // 
            this.testerToolStripMenuItem.Name = "testerToolStripMenuItem";
            this.testerToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.testerToolStripMenuItem.Text = "Tester";
            this.testerToolStripMenuItem.Click += new System.EventHandler(this.testerToolStripMenuItem_Click);
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.ouvrirToolStripMenuItem.Text = "Ouvrir";
            this.ouvrirToolStripMenuItem.Click += new System.EventHandler(this.ouvrirToolStripMenuItem_Click);
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.enregistrerToolStripMenuItem.Text = "Enregistrer sous";
            this.enregistrerToolStripMenuItem.Click += new System.EventHandler(this.enregistrerToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // affichageToolStripMenuItem
            // 
            this.affichageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agrToolStripMenuItem,
            this.agrandirMatriceToolStripMenuItem});
            this.affichageToolStripMenuItem.Name = "affichageToolStripMenuItem";
            this.affichageToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.affichageToolStripMenuItem.Text = "Affichage";
            // 
            // agrToolStripMenuItem
            // 
            this.agrToolStripMenuItem.Name = "agrToolStripMenuItem";
            this.agrToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.agrToolStripMenuItem.Text = "Agrandir tableur";
            // 
            // agrandirMatriceToolStripMenuItem
            // 
            this.agrandirMatriceToolStripMenuItem.Name = "agrandirMatriceToolStripMenuItem";
            this.agrandirMatriceToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.agrandirMatriceToolStripMenuItem.Text = "Agrandir matrice";
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.présentationEtModeDemploiToolStripMenuItem,
            this.toolStripMenuItem2});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // présentationEtModeDemploiToolStripMenuItem
            // 
            this.présentationEtModeDemploiToolStripMenuItem.Name = "présentationEtModeDemploiToolStripMenuItem";
            this.présentationEtModeDemploiToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.présentationEtModeDemploiToolStripMenuItem.Text = "Présentation et mode d\'emploi";
            this.présentationEtModeDemploiToolStripMenuItem.Click += new System.EventHandler(this.présentationEtModeDemploiToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(237, 22);
            this.toolStripMenuItem2.Text = "?";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // dgvTableur
            // 
            this.dgvTableur.AllowUserToOrderColumns = true;
            this.dgvTableur.AutoGenerateColumns = false;
            this.dgvTableur.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTableur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.activiteDataGridViewTextBoxColumn,
            this.pDMproduitDataGridViewTextBoxColumn,
            this.pDMconctDataGridViewTextBoxColumn,
            this.txCroissDataGridViewTextBoxColumn,
            this.partProduitDataGridViewTextBoxColumn});
            this.dgvTableur.DataSource = this.matriceBindingSource;
            this.dgvTableur.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvTableur.Location = new System.Drawing.Point(12, 27);
            this.dgvTableur.Name = "dgvTableur";
            this.dgvTableur.Size = new System.Drawing.Size(343, 314);
            this.dgvTableur.TabIndex = 1;
            // 
            // activiteDataGridViewTextBoxColumn
            // 
            this.activiteDataGridViewTextBoxColumn.DataPropertyName = "Activite";
            this.activiteDataGridViewTextBoxColumn.HeaderText = "Activite";
            this.activiteDataGridViewTextBoxColumn.Name = "activiteDataGridViewTextBoxColumn";
            // 
            // pDMproduitDataGridViewTextBoxColumn
            // 
            this.pDMproduitDataGridViewTextBoxColumn.DataPropertyName = "PDMproduit";
            this.pDMproduitDataGridViewTextBoxColumn.HeaderText = "PDMproduit";
            this.pDMproduitDataGridViewTextBoxColumn.Name = "pDMproduitDataGridViewTextBoxColumn";
            // 
            // pDMconctDataGridViewTextBoxColumn
            // 
            this.pDMconctDataGridViewTextBoxColumn.DataPropertyName = "PDMconct";
            this.pDMconctDataGridViewTextBoxColumn.HeaderText = "PDMconct";
            this.pDMconctDataGridViewTextBoxColumn.Name = "pDMconctDataGridViewTextBoxColumn";
            // 
            // txCroissDataGridViewTextBoxColumn
            // 
            this.txCroissDataGridViewTextBoxColumn.DataPropertyName = "TxCroiss";
            this.txCroissDataGridViewTextBoxColumn.HeaderText = "TxCroiss";
            this.txCroissDataGridViewTextBoxColumn.Name = "txCroissDataGridViewTextBoxColumn";
            // 
            // partProduitDataGridViewTextBoxColumn
            // 
            this.partProduitDataGridViewTextBoxColumn.DataPropertyName = "PartProduit";
            this.partProduitDataGridViewTextBoxColumn.HeaderText = "PartProduit";
            this.partProduitDataGridViewTextBoxColumn.Name = "partProduitDataGridViewTextBoxColumn";
            // 
            // matriceBindingSource
            // 
            this.matriceBindingSource.DataSource = typeof(BCG.Matrice);
            // 
            // ofdExcel
            // 
            this.ofdExcel.Title = "Importer des données Excel";
            // 
            // sfdTableur
            // 
            this.sfdTableur.FileName = "maMatriceBCG.xlsx";
            this.sfdTableur.Title = "Enregistrer le fichier sous";
            // 
            // btnGenerer
            // 
            this.btnGenerer.Location = new System.Drawing.Point(361, 233);
            this.btnGenerer.Name = "btnGenerer";
            this.btnGenerer.Size = new System.Drawing.Size(75, 31);
            this.btnGenerer.TabIndex = 2;
            this.btnGenerer.Text = "Générer";
            this.btnGenerer.UseVisualStyleBackColor = true;
            this.btnGenerer.Click += new System.EventHandler(this.btnGenerer_Click);
            // 
            // btnAjout
            // 
            this.btnAjout.Location = new System.Drawing.Point(361, 186);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(75, 41);
            this.btnAjout.TabIndex = 4;
            this.btnAjout.Text = "Ajouter une ligne";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // BtnValider
            // 
            this.BtnValider.Location = new System.Drawing.Point(361, 146);
            this.BtnValider.Name = "BtnValider";
            this.BtnValider.Size = new System.Drawing.Size(75, 34);
            this.BtnValider.TabIndex = 5;
            this.BtnValider.Text = "Valider la ligne";
            this.BtnValider.UseVisualStyleBackColor = true;
            this.BtnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // chartBCG
            // 
            chartArea1.AxisX.Crossing = 0.01D;
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisX.IsLogarithmic = true;
            chartArea1.AxisX.IsReversed = true;
            chartArea1.AxisX.IsStartedFromZero = false;
            chartArea1.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorGrid.Interval = 0D;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisX.MajorTickMark.Interval = 0D;
            chartArea1.AxisX.MajorTickMark.Size = 2F;
            chartArea1.AxisX.Maximum = 10D;
            chartArea1.AxisX.Minimum = 0.1D;
            chartArea1.AxisX.MinorTickMark.Interval = 1D;
            chartArea1.AxisX.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis;
            chartArea1.AxisX.Title = "x";
            chartArea1.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisX2.IsStartedFromZero = false;
            chartArea1.AxisX2.MajorGrid.Enabled = false;
            chartArea1.AxisX2.MajorTickMark.Enabled = false;
            chartArea1.AxisY.Crossing = 15D;
            chartArea1.AxisY.Interval = 6D;
            chartArea1.AxisY.LabelStyle.Format = "#\"%\"";
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorTickMark.Enabled = false;
            chartArea1.AxisY.Maximum = 30D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY.MinorTickMark.Interval = 4D;
            chartArea1.AxisY.Title = "y";
            chartArea1.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.Name = "ChartArea1";
            this.chartBCG.ChartAreas.Add(chartArea1);
            this.chartBCG.Cursor = System.Windows.Forms.Cursors.Default;
            this.chartBCG.DataBindings.Add(new System.Windows.Forms.Binding("Visible", global::BCG.Properties.Settings.Default, "Visible", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chartBCG.DataSource = this.matriceBindingSource;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartBCG.Legends.Add(legend1);
            this.chartBCG.Location = new System.Drawing.Point(442, 27);
            this.chartBCG.Name = "chartBCG";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Series1";
            dataPoint1.Color = System.Drawing.Color.White;
            series1.Points.Add(dataPoint1);
            series1.YValuesPerPoint = 2;
            this.chartBCG.Series.Add(series1);
            this.chartBCG.Size = new System.Drawing.Size(324, 314);
            this.chartBCG.TabIndex = 3;
            this.chartBCG.Text = "Repere";
            this.chartBCG.Visible = global::BCG.Properties.Settings.Default.Visible;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(442, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "x = log (PDM produit / PDM concurrent principal)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(442, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "y = Taux de croissance du marché";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(442, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "rayon = Part produit dans chiffre d\'affaires";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(442, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Vaches à lait";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(710, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Poids Morts";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(442, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Vedettes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(714, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Dilemmes";
            // 
            // Principale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnValider);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.chartBCG);
            this.Controls.Add(this.btnGenerer);
            this.Controls.Add(this.dgvTableur);
            this.Controls.Add(this.menuPrincipale);
            this.MainMenuStrip = this.menuPrincipale;
            this.Name = "Principale";
            this.Text = "Principale";
            this.Load += new System.EventHandler(this.Principale_Load);
            this.menuPrincipale.ResumeLayout(false);
            this.menuPrincipale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matriceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBCG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipale;
        private System.Windows.Forms.ToolStripMenuItem tsmiFichier;
        private System.Windows.Forms.ToolStripMenuItem rAZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affichageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agrandirMatriceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem présentationEtModeDemploiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.DataGridView dgvTableur;
        private System.Windows.Forms.BindingSource matriceBindingSource;
        private System.Windows.Forms.OpenFileDialog ofdExcel;
        private System.Windows.Forms.SaveFileDialog sfdTableur;
        private System.Windows.Forms.Button btnGenerer;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBCG;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.DataGridViewTextBoxColumn activiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDMproduitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDMconctDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txCroissDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partProduitDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BtnValider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

