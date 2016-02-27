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
            this.ofdExcel = new System.Windows.Forms.OpenFileDialog();
            this.sfdTableur = new System.Windows.Forms.SaveFileDialog();
            this.btnGenerer = new System.Windows.Forms.Button();
            this.chartBCG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnAjout = new System.Windows.Forms.Button();
            this.BtnValider = new System.Windows.Forms.Button();
            this.cmsPaste = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Copier = new System.Windows.Forms.ToolStripMenuItem();
            this.Coller = new System.Windows.Forms.ToolStripMenuItem();
            this.Couper = new System.Windows.Forms.ToolStripMenuItem();
            this.activiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDMproduitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDMconctDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txCroissDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partProduitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matriceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuPrincipale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBCG)).BeginInit();
            this.cmsPaste.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matriceBindingSource)).BeginInit();
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
            this.dgvTableur.AllowDrop = true;
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
            this.dgvTableur.Size = new System.Drawing.Size(367, 364);
            this.dgvTableur.TabIndex = 1;
            this.dgvTableur.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTableur_CellMouseClick);
            this.dgvTableur.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvTableur_DataError);
            this.dgvTableur.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvTableur_KeyDown);
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
            this.btnGenerer.Location = new System.Drawing.Point(385, 233);
            this.btnGenerer.Name = "btnGenerer";
            this.btnGenerer.Size = new System.Drawing.Size(75, 31);
            this.btnGenerer.TabIndex = 2;
            this.btnGenerer.Text = "Générer";
            this.btnGenerer.UseVisualStyleBackColor = true;
            this.btnGenerer.Click += new System.EventHandler(this.btnGenerer_Click);
            // 
            // chartBCG
            // 
            chartArea1.AxisX.Crossing = 5D;
            chartArea1.AxisX.Interval = 2D;
            chartArea1.AxisX.Maximum = 10D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.Title = "x";
            chartArea1.AxisY.Crossing = 25D;
            chartArea1.AxisY.Interval = 6D;
            chartArea1.AxisY.Maximum = 50D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.chartBCG.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartBCG.Legends.Add(legend1);
            this.chartBCG.Location = new System.Drawing.Point(466, 27);
            this.chartBCG.Name = "chartBCG";
            this.chartBCG.Size = new System.Drawing.Size(300, 300);
            this.chartBCG.TabIndex = 3;
            this.chartBCG.Text = "Repere";
            this.chartBCG.Visible = false;
            // 
            // btnAjout
            // 
            this.btnAjout.Location = new System.Drawing.Point(385, 186);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(75, 41);
            this.btnAjout.TabIndex = 4;
            this.btnAjout.Text = "Ajouter une ligne";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // BtnValider
            // 
            this.BtnValider.Location = new System.Drawing.Point(386, 146);
            this.BtnValider.Name = "BtnValider";
            this.BtnValider.Size = new System.Drawing.Size(75, 34);
            this.BtnValider.TabIndex = 5;
            this.BtnValider.Text = "Valider la ligne";
            this.BtnValider.UseVisualStyleBackColor = true;
            this.BtnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // cmsPaste
            // 
            this.cmsPaste.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Couper,
            this.Copier,
            this.Coller});
            this.cmsPaste.Name = "cmsPaste";
            this.cmsPaste.Size = new System.Drawing.Size(114, 70);
            // 
            // Copier
            // 
            this.Copier.Name = "Copier";
            this.Copier.Size = new System.Drawing.Size(113, 22);
            this.Copier.Text = "Copier";
            this.Copier.Click += new System.EventHandler(this.Copier_Click);
            // 
            // Coller
            // 
            this.Coller.Name = "Coller";
            this.Coller.Size = new System.Drawing.Size(113, 22);
            this.Coller.Text = "Coller";
            this.Coller.Click += new System.EventHandler(this.Coller_Click);
            // 
            // Couper
            // 
            this.Couper.Name = "Couper";
            this.Couper.Size = new System.Drawing.Size(113, 22);
            this.Couper.Text = "Couper";
            this.Couper.Click += new System.EventHandler(this.Couper_Click);
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
            // Principale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.BtnValider);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.chartBCG);
            this.Controls.Add(this.btnGenerer);
            this.Controls.Add(this.dgvTableur);
            this.Controls.Add(this.menuPrincipale);
            this.MainMenuStrip = this.menuPrincipale;
            this.Name = "Principale";
            this.Text = "Principale";
            this.menuPrincipale.ResumeLayout(false);
            this.menuPrincipale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBCG)).EndInit();
            this.cmsPaste.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.matriceBindingSource)).EndInit();
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
        private System.Windows.Forms.ContextMenuStrip cmsPaste;
        private System.Windows.Forms.ToolStripMenuItem Couper;
        private System.Windows.Forms.ToolStripMenuItem Copier;
        private System.Windows.Forms.ToolStripMenuItem Coller;
    }
}

