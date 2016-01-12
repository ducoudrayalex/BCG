namespace BCG
{
    partial class Accueil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAide = new System.Windows.Forms.Button();
            this.btnPrincipale = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAide
            // 
            this.btnAide.Location = new System.Drawing.Point(173, 274);
            this.btnAide.Name = "btnAide";
            this.btnAide.Size = new System.Drawing.Size(157, 23);
            this.btnAide.TabIndex = 0;
            this.btnAide.Text = "Présentation et mode d\'emploi";
            this.btnAide.UseVisualStyleBackColor = true;
            this.btnAide.Click += new System.EventHandler(this.btnAide_Click);
            // 
            // btnPrincipale
            // 
            this.btnPrincipale.Location = new System.Drawing.Point(436, 274);
            this.btnPrincipale.Name = "btnPrincipale";
            this.btnPrincipale.Size = new System.Drawing.Size(75, 23);
            this.btnPrincipale.TabIndex = 1;
            this.btnPrincipale.Text = "L\'application";
            this.btnPrincipale.UseVisualStyleBackColor = true;
            this.btnPrincipale.Click += new System.EventHandler(this.btnPrincipale_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnPrincipale);
            this.Controls.Add(this.btnAide);
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAide;
        private System.Windows.Forms.Button btnPrincipale;
    }
}