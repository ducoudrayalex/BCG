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
            this.btnLancer = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnQuitterAccueil = new System.Windows.Forms.Button();
            this.rtbAccueil = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnLancer
            // 
            this.btnLancer.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLancer.Location = new System.Drawing.Point(147, 488);
            this.btnLancer.Name = "btnLancer";
            this.btnLancer.Size = new System.Drawing.Size(110, 40);
            this.btnLancer.TabIndex = 3;
            this.btnLancer.Text = "Lancer";
            this.btnLancer.UseVisualStyleBackColor = true;
            this.btnLancer.Click += new System.EventHandler(this.btnLancer_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.Location = new System.Drawing.Point(348, 488);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(100, 40);
            this.btnQuitter.TabIndex = 4;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnQuitterAccueil
            // 
            this.btnQuitterAccueil.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitterAccueil.Location = new System.Drawing.Point(527, 488);
            this.btnQuitterAccueil.Name = "btnQuitterAccueil";
            this.btnQuitterAccueil.Size = new System.Drawing.Size(110, 40);
            this.btnQuitterAccueil.TabIndex = 5;
            this.btnQuitterAccueil.Text = "Aide";
            this.btnQuitterAccueil.UseVisualStyleBackColor = true;
            this.btnQuitterAccueil.Click += new System.EventHandler(this.btnQuitterAccueil_Click);
            // 
            // rtbAccueil
            // 
            this.rtbAccueil.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.rtbAccueil.Location = new System.Drawing.Point(12, 12);
            this.rtbAccueil.Name = "rtbAccueil";
            this.rtbAccueil.ReadOnly = true;
            this.rtbAccueil.Size = new System.Drawing.Size(760, 470);
            this.rtbAccueil.TabIndex = 6;
            this.rtbAccueil.Text = "";
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.rtbAccueil);
            this.Controls.Add(this.btnQuitterAccueil);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnLancer);
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLancer;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnQuitterAccueil;
        private System.Windows.Forms.RichTextBox rtbAccueil;
    }
}