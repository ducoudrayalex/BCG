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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnQuitterAccueil = new System.Windows.Forms.Button();
            this.rtbAccueil = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLancer = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.White;
            this.btnQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitter.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnQuitter.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.Location = new System.Drawing.Point(657, 497);
            this.btnQuitter.MinimumSize = new System.Drawing.Size(100, 37);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(100, 37);
            this.btnQuitter.TabIndex = 4;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnQuitterAccueil
            // 
            this.btnQuitterAccueil.BackColor = System.Drawing.Color.White;
            this.btnQuitterAccueil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitterAccueil.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnQuitterAccueil.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitterAccueil.Location = new System.Drawing.Point(3, 497);
            this.btnQuitterAccueil.MinimumSize = new System.Drawing.Size(100, 37);
            this.btnQuitterAccueil.Name = "btnQuitterAccueil";
            this.btnQuitterAccueil.Size = new System.Drawing.Size(110, 37);
            this.btnQuitterAccueil.TabIndex = 5;
            this.btnQuitterAccueil.Text = "Aide";
            this.btnQuitterAccueil.UseVisualStyleBackColor = false;
            this.btnQuitterAccueil.Click += new System.EventHandler(this.btnQuitterAccueil_Click);
            // 
            // rtbAccueil
            // 
            this.rtbAccueil.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbAccueil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(84)))), ((int)(((byte)(59)))));
            this.rtbAccueil.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.rtbAccueil, 3);
            this.rtbAccueil.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rtbAccueil.Location = new System.Drawing.Point(3, 3);
            this.rtbAccueil.Name = "rtbAccueil";
            this.rtbAccueil.ReadOnly = true;
            this.rtbAccueil.Size = new System.Drawing.Size(754, 488);
            this.rtbAccueil.TabIndex = 6;
            this.rtbAccueil.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.btnQuitter, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnLancer, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnQuitterAccueil, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.rtbAccueil, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(760, 537);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // btnLancer
            // 
            this.btnLancer.BackColor = System.Drawing.Color.White;
            this.btnLancer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLancer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLancer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLancer.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLancer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLancer.Location = new System.Drawing.Point(256, 497);
            this.btnLancer.MinimumSize = new System.Drawing.Size(0, 37);
            this.btnLancer.Name = "btnLancer";
            this.btnLancer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLancer.Size = new System.Drawing.Size(247, 37);
            this.btnLancer.TabIndex = 3;
            this.btnLancer.Text = "Lancer";
            this.btnLancer.UseVisualStyleBackColor = false;
            this.btnLancer.Click += new System.EventHandler(this.btnLancer_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(84)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 550);
            this.Name = "Accueil";
            this.Text = "BCG - Accueil";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLancer;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnQuitterAccueil;
        private System.Windows.Forms.RichTextBox rtbAccueil;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}