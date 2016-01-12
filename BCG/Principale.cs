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

namespace BCG
{
    public partial class Principale : Form
    {
        private List<Matrice> Points = new List<Matrice>();
        BindingSource bindingSource = new BindingSource();
        public Principale()
        {
            InitializeComponent();
   

            Points.Add(new Matrice("A", 25, 20, 18, 10));
            Points.Add(new Matrice("B", 20, 30, 12, 10));
            Points.Add(new Matrice("C", 12, 30, 5, 15));
            Points.Add(new Matrice("D", 59, 12, 7, 40));

            bindingSource.DataSource = Points;
            dgvTableur.AutoGenerateColumns = true;
            dgvTableur.DataSource = bindingSource;

            //DataGridViewColumn col1 = new DataGridViewTextBoxColumn();
            //col1.DataPropertyName = "Activite";
            //col1.HeaderText = "Activité";
            //dgvTableur.Columns.Add(col1);

            //DataGridViewColumn col2 = new DataGridViewTextBoxColumn();
            //col2.DataPropertyName = "PDMproduit";
            //col2.HeaderText = "PDM produit";
            //dgvTableur.Columns.Add(col2);

            //DataGridViewColumn col3 = new DataGridViewTextBoxColumn();
            //col3.DataPropertyName = "PDMConct";
            //col3.HeaderText = "PDM Conct";
            //dgvTableur.Columns.Add(col3);

            //DataGridViewColumn col4 = new DataGridViewTextBoxColumn();
            //col4.DataPropertyName = "TxCroiss";
            //col4.HeaderText = "Tx croiss";
            //dgvTableur.Columns.Add(col4);

            //DataGridViewColumn col5 = new DataGridViewTextBoxColumn();
            //col4.DataPropertyName = "PartProduit";
            //col4.HeaderText = "Part produit";
            //dgvTableur.Columns.Add(col5);
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvTableur.Rows[e.RowIndex].DataBoundItem != null &&
                dgvTableur.Columns[e.ColumnIndex].DataPropertyName.Contains("."))
            {
                e.Value = BindProperty(dgvTableur.Rows[e.RowIndex].DataBoundItem,
                    dgvTableur.Columns[e.ColumnIndex].DataPropertyName);
            }
        }
        private string BindProperty(object property, string propertyName)
        {
            string retValue = "";

            if (propertyName.Contains("."))
            {
                PropertyInfo[] arrayProperties;
                string leftPropertyName;

                leftPropertyName = propertyName.Substring(0, propertyName.IndexOf("."));
                arrayProperties = property.GetType().GetProperties();

                foreach (PropertyInfo propertyInfo in arrayProperties)
                {
                    if (propertyInfo.Name == leftPropertyName)
                    {
                        retValue = BindProperty(propertyInfo.GetValue(property, null),
                        propertyName.Substring(propertyName.IndexOf(".") + 1));
                        break;
                    }
                }
            }
            else
            {
                Type propertyType;
                PropertyInfo propertyInfo;

                propertyType = property.GetType();
                propertyInfo = propertyType.GetProperty(propertyName);
                retValue = propertyInfo.GetValue(property, null).ToString();
            }

            return retValue;
        }
        private void présentationEtModeDemploiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Aide().ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new Apropos().ShowDialog();
        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvTableur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvTableur_Click(object sender, EventArgs e)
        {

        }

        private void dgvTableur_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void rAZToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void testerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
