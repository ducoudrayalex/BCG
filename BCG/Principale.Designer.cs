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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principale));
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
            this.btnAjout = new System.Windows.Forms.Button();
            this.chartBCG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblRayon = new System.Windows.Forms.Label();
            this.lblVacheALait = new System.Windows.Forms.Label();
            this.lblPoidsMort = new System.Windows.Forms.Label();
            this.lblVedette = new System.Windows.Forms.Label();
            this.lblDilemme = new System.Windows.Forms.Label();
            this.cmsPaste = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Couper = new System.Windows.Forms.ToolStripMenuItem();
            this.Copier = new System.Windows.Forms.ToolStripMenuItem();
            this.Coller = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerLaLigneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlChartLbl = new System.Windows.Forms.Panel();
            this.pnlLegend = new System.Windows.Forms.Panel();
            this.tlpBouton = new System.Windows.Forms.TableLayoutPanel();
            this.cmsCouleurBulle = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCouleur = new System.Windows.Forms.ToolStripMenuItem();
            this.bleu = new System.Windows.Forms.ToolStripMenuItem();
            this.rouge = new System.Windows.Forms.ToolStripMenuItem();
            this.vert = new System.Windows.Forms.ToolStripMenuItem();
            this.jaune = new System.Windows.Forms.ToolStripMenuItem();
            this.violet = new System.Windows.Forms.ToolStripMenuItem();
            this.noir = new System.Windows.Forms.ToolStripMenuItem();
            this.activiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDMproduitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDMconcuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txCroissDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partProduitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matriceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuPrincipale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBCG)).BeginInit();
            this.cmsPaste.SuspendLayout();
            this.pnlChartLbl.SuspendLayout();
            this.pnlLegend.SuspendLayout();
            this.tlpBouton.SuspendLayout();
            this.cmsCouleurBulle.SuspendLayout();
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
            this.menuPrincipale.Size = new System.Drawing.Size(841, 24);
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
            this.agrToolStripMenuItem.Click += new System.EventHandler(this.agrToolStripMenuItem_Click);
            // 
            // agrandirMatriceToolStripMenuItem
            // 
            this.agrandirMatriceToolStripMenuItem.Name = "agrandirMatriceToolStripMenuItem";
            this.agrandirMatriceToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.agrandirMatriceToolStripMenuItem.Text = "Agrandir matrice";
            this.agrandirMatriceToolStripMenuItem.Click += new System.EventHandler(this.agrandirMatriceToolStripMenuItem_Click);
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
            this.dgvTableur.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(84)))), ((int)(((byte)(59)))));
            this.dgvTableur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTableur.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "null";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTableur.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTableur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.activiteDataGridViewTextBoxColumn,
            this.pDMproduitDataGridViewTextBoxColumn,
            this.pDMconcuDataGridViewTextBoxColumn,
            this.txCroissDataGridViewTextBoxColumn,
            this.partProduitDataGridViewTextBoxColumn});
            this.dgvTableur.DataSource = this.matriceBindingSource;
            this.dgvTableur.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvTableur.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvTableur.Location = new System.Drawing.Point(12, 41);
            this.dgvTableur.Name = "dgvTableur";
            this.dgvTableur.Size = new System.Drawing.Size(412, 300);
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
            this.btnGenerer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGenerer.BackColor = System.Drawing.Color.White;
            this.btnGenerer.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerer.Location = new System.Drawing.Point(261, 5);
            this.btnGenerer.Name = "btnGenerer";
            this.btnGenerer.Size = new System.Drawing.Size(108, 26);
            this.btnGenerer.TabIndex = 2;
            this.btnGenerer.Text = "Générer";
            this.btnGenerer.UseVisualStyleBackColor = false;
            this.btnGenerer.Click += new System.EventHandler(this.btnGenerer_Click);
            // 
            // btnAjout
            // 
            this.btnAjout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAjout.BackColor = System.Drawing.Color.White;
            this.btnAjout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjout.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjout.Location = new System.Drawing.Point(55, 5);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(108, 26);
            this.btnAjout.TabIndex = 4;
            this.btnAjout.Text = "Ajouter une ligne";
            this.btnAjout.UseVisualStyleBackColor = false;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // chartBCG
            // 
            this.chartBCG.Cursor = System.Windows.Forms.Cursors.Default;
            this.chartBCG.DataBindings.Add(new System.Windows.Forms.Binding("Visible", global::BCG.Properties.Settings.Default, "Visible", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chartBCG.DataSource = this.matriceBindingSource;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartBCG.Legends.Add(legend1);
            this.chartBCG.Location = new System.Drawing.Point(3, 3);
            this.chartBCG.Name = "chartBCG";
            this.chartBCG.Size = new System.Drawing.Size(308, 308);
            this.chartBCG.TabIndex = 3;
            this.chartBCG.Text = "Repere";
            this.chartBCG.Visible = global::BCG.Properties.Settings.Default.Visible;
            this.chartBCG.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chartBCG_MouseClick);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.ForeColor = System.Drawing.Color.White;
            this.lblX.Location = new System.Drawing.Point(12, 6);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(237, 13);
            this.lblX.TabIndex = 6;
            this.lblX.Text = "x = log (PDM produit / PDM concurrent principal)";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.ForeColor = System.Drawing.Color.White;
            this.lblY.Location = new System.Drawing.Point(12, 23);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(170, 13);
            this.lblY.TabIndex = 7;
            this.lblY.Text = "y = Taux de croissance du marché";
            // 
            // lblRayon
            // 
            this.lblRayon.AutoSize = true;
            this.lblRayon.ForeColor = System.Drawing.Color.White;
            this.lblRayon.Location = new System.Drawing.Point(12, 36);
            this.lblRayon.Name = "lblRayon";
            this.lblRayon.Size = new System.Drawing.Size(202, 13);
            this.lblRayon.TabIndex = 8;
            this.lblRayon.Text = "rayon = Part produit dans chiffre d\'affaires";
            // 
            // lblVacheALait
            // 
            this.lblVacheALait.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVacheALait.AutoSize = true;
            this.lblVacheALait.BackColor = System.Drawing.Color.White;
            this.lblVacheALait.Location = new System.Drawing.Point(3, 298);
            this.lblVacheALait.Name = "lblVacheALait";
            this.lblVacheALait.Size = new System.Drawing.Size(68, 13);
            this.lblVacheALait.TabIndex = 9;
            this.lblVacheALait.Text = "Vaches à lait";
            // 
            // lblPoidsMort
            // 
            this.lblPoidsMort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPoidsMort.AutoSize = true;
            this.lblPoidsMort.BackColor = System.Drawing.Color.White;
            this.lblPoidsMort.Location = new System.Drawing.Point(249, 298);
            this.lblPoidsMort.Name = "lblPoidsMort";
            this.lblPoidsMort.Size = new System.Drawing.Size(62, 13);
            this.lblPoidsMort.TabIndex = 10;
            this.lblPoidsMort.Text = "Poids Morts";
            // 
            // lblVedette
            // 
            this.lblVedette.AutoSize = true;
            this.lblVedette.BackColor = System.Drawing.Color.White;
            this.lblVedette.Location = new System.Drawing.Point(3, 3);
            this.lblVedette.Name = "lblVedette";
            this.lblVedette.Size = new System.Drawing.Size(26, 13);
            this.lblVedette.TabIndex = 11;
            this.lblVedette.Text = "Star";
            // 
            // lblDilemme
            // 
            this.lblDilemme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDilemme.AutoSize = true;
            this.lblDilemme.BackColor = System.Drawing.Color.White;
            this.lblDilemme.Location = new System.Drawing.Point(259, 3);
            this.lblDilemme.Name = "lblDilemme";
            this.lblDilemme.Size = new System.Drawing.Size(52, 13);
            this.lblDilemme.TabIndex = 12;
            this.lblDilemme.Text = "Dilemmes";
            // 
            // cmsPaste
            // 
            this.cmsPaste.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Couper,
            this.Copier,
            this.Coller,
            this.supprimerLaLigneToolStripMenuItem});
            this.cmsPaste.Name = "cmsPaste";
            this.cmsPaste.Size = new System.Drawing.Size(171, 92);
            // 
            // Couper
            // 
            this.Couper.Name = "Couper";
            this.Couper.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.Couper.Size = new System.Drawing.Size(170, 22);
            this.Couper.Text = "Couper";
            this.Couper.Click += new System.EventHandler(this.Couper_Click);
            // 
            // Copier
            // 
            this.Copier.Name = "Copier";
            this.Copier.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.Copier.Size = new System.Drawing.Size(170, 22);
            this.Copier.Text = "Copier";
            this.Copier.Click += new System.EventHandler(this.Copier_Click);
            // 
            // Coller
            // 
            this.Coller.Name = "Coller";
            this.Coller.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.Coller.Size = new System.Drawing.Size(170, 22);
            this.Coller.Text = "Coller";
            this.Coller.Click += new System.EventHandler(this.Coller_Click);
            // 
            // supprimerLaLigneToolStripMenuItem
            // 
            this.supprimerLaLigneToolStripMenuItem.Name = "supprimerLaLigneToolStripMenuItem";
            this.supprimerLaLigneToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.supprimerLaLigneToolStripMenuItem.Text = "Supprimer la ligne";
            this.supprimerLaLigneToolStripMenuItem.Click += new System.EventHandler(this.supprimerLaLigneToolStripMenuItem_Click);
            // 
            // pnlChartLbl
            // 
            this.pnlChartLbl.Controls.Add(this.lblVedette);
            this.pnlChartLbl.Controls.Add(this.lblPoidsMort);
            this.pnlChartLbl.Controls.Add(this.lblDilemme);
            this.pnlChartLbl.Controls.Add(this.lblVacheALait);
            this.pnlChartLbl.Controls.Add(this.chartBCG);
            this.pnlChartLbl.Location = new System.Drawing.Point(445, 41);
            this.pnlChartLbl.Name = "pnlChartLbl";
            this.pnlChartLbl.Size = new System.Drawing.Size(316, 314);
            this.pnlChartLbl.TabIndex = 13;
            // 
            // pnlLegend
            // 
            this.pnlLegend.Controls.Add(this.lblX);
            this.pnlLegend.Controls.Add(this.lblY);
            this.pnlLegend.Controls.Add(this.lblRayon);
            this.pnlLegend.Location = new System.Drawing.Point(448, 361);
            this.pnlLegend.Name = "pnlLegend";
            this.pnlLegend.Size = new System.Drawing.Size(316, 60);
            this.pnlLegend.TabIndex = 14;
            // 
            // tlpBouton
            // 
            this.tlpBouton.ColumnCount = 2;
            this.tlpBouton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.25203F));
            this.tlpBouton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.74797F));
            this.tlpBouton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 177F));
            this.tlpBouton.Controls.Add(this.btnAjout, 0, 0);
            this.tlpBouton.Controls.Add(this.btnGenerer, 2, 0);
            this.tlpBouton.Location = new System.Drawing.Point(12, 361);
            this.tlpBouton.Name = "tlpBouton";
            this.tlpBouton.RowCount = 1;
            this.tlpBouton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBouton.Size = new System.Drawing.Size(412, 36);
            this.tlpBouton.TabIndex = 15;
            // 
            // cmsCouleurBulle
            // 
            this.cmsCouleurBulle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCouleur});
            this.cmsCouleurBulle.Name = "cmsCouleurBulle";
            this.cmsCouleurBulle.Size = new System.Drawing.Size(122, 26);
            // 
            // tsmiCouleur
            // 
            this.tsmiCouleur.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bleu,
            this.rouge,
            this.vert,
            this.jaune,
            this.violet,
            this.noir});
            this.tsmiCouleur.Name = "tsmiCouleur";
            this.tsmiCouleur.Size = new System.Drawing.Size(121, 22);
            this.tsmiCouleur.Text = "Couleurs";
            // 
            // bleu
            // 
            this.bleu.Name = "bleu";
            this.bleu.Size = new System.Drawing.Size(105, 22);
            this.bleu.Text = "bleu";
            // 
            // rouge
            // 
            this.rouge.Name = "rouge";
            this.rouge.Size = new System.Drawing.Size(105, 22);
            this.rouge.Text = "rouge";
            // 
            // vert
            // 
            this.vert.Name = "vert";
            this.vert.Size = new System.Drawing.Size(105, 22);
            this.vert.Text = "vert";
            // 
            // jaune
            // 
            this.jaune.Name = "jaune";
            this.jaune.Size = new System.Drawing.Size(105, 22);
            this.jaune.Text = "jaune";
            // 
            // violet
            // 
            this.violet.Name = "violet";
            this.violet.Size = new System.Drawing.Size(105, 22);
            this.violet.Text = "violet";
            // 
            // noir
            // 
            this.noir.Name = "noir";
            this.noir.Size = new System.Drawing.Size(105, 22);
            this.noir.Text = "noir";
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
            // pDMconcuDataGridViewTextBoxColumn
            // 
            this.pDMconcuDataGridViewTextBoxColumn.DataPropertyName = "PDMconcu";
            this.pDMconcuDataGridViewTextBoxColumn.HeaderText = "PDMconcu";
            this.pDMconcuDataGridViewTextBoxColumn.Name = "pDMconcuDataGridViewTextBoxColumn";
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
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(84)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(841, 561);
            this.Controls.Add(this.tlpBouton);
            this.Controls.Add(this.pnlLegend);
            this.Controls.Add(this.dgvTableur);
            this.Controls.Add(this.menuPrincipale);
            this.Controls.Add(this.pnlChartLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuPrincipale;
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "Principale";
            this.Text = "BCG - Application";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Principale_FormClosed);
            this.Load += new System.EventHandler(this.Principale_Load);
            this.SizeChanged += new System.EventHandler(this.Principale_SizeChanged);
            this.menuPrincipale.ResumeLayout(false);
            this.menuPrincipale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBCG)).EndInit();
            this.cmsPaste.ResumeLayout(false);
            this.pnlChartLbl.ResumeLayout(false);
            this.pnlChartLbl.PerformLayout();
            this.pnlLegend.ResumeLayout(false);
            this.pnlLegend.PerformLayout();
            this.tlpBouton.ResumeLayout(false);
            this.cmsCouleurBulle.ResumeLayout(false);
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

        // LEGENDE
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblRayon;
        private System.Windows.Forms.Label lblVacheALait;
        private System.Windows.Forms.Label lblPoidsMort;
        private System.Windows.Forms.Label lblVedette;
        private System.Windows.Forms.Label lblDilemme;

        private System.Windows.Forms.ContextMenuStrip cmsPaste;
        private System.Windows.Forms.ToolStripMenuItem Couper;
        private System.Windows.Forms.ToolStripMenuItem Copier;
        private System.Windows.Forms.ToolStripMenuItem Coller;
        private System.Windows.Forms.Panel pnlChartLbl;
        private System.Windows.Forms.Panel pnlLegend;
        private System.Windows.Forms.TableLayoutPanel tlpBouton;
        private System.Windows.Forms.ContextMenuStrip cmsCouleurBulle;
        private System.Windows.Forms.ToolStripMenuItem tsmiCouleur;
        private System.Windows.Forms.ToolStripMenuItem bleu;
        private System.Windows.Forms.ToolStripMenuItem rouge;
        private System.Windows.Forms.ToolStripMenuItem vert;
        private System.Windows.Forms.ToolStripMenuItem jaune;
        private System.Windows.Forms.ToolStripMenuItem violet;
        private System.Windows.Forms.ToolStripMenuItem noir;
        private System.Windows.Forms.ToolStripMenuItem supprimerLaLigneToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn activiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDMproduitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDMconcuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txCroissDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partProduitDataGridViewTextBoxColumn;
    }
}

