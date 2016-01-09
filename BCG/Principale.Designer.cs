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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFichier,
            this.affichageToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            this.rAZToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rAZToolStripMenuItem.Text = "RAZ";
            // 
            // testerToolStripMenuItem
            // 
            this.testerToolStripMenuItem.Name = "testerToolStripMenuItem";
            this.testerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.testerToolStripMenuItem.Text = "Tester";
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ouvrirToolStripMenuItem.Text = "Ouvrir";
            this.ouvrirToolStripMenuItem.Click += new System.EventHandler(this.ouvrirToolStripMenuItem_Click);
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.enregistrerToolStripMenuItem.Text = "Enregistrer";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
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
            // Principale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principale";
            this.Text = "Principale";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
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
    }
}

