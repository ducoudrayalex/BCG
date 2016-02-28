using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BCG
{
    class CopierColler
    {
        /// <summary>
        /// Insère les données du presse papier dans un dictionnaire (clé,valeur)
        /// </summary>
        /// <param name="clipboardValue"></param>
        /// <returns>retourne le dictionnaire rempli des valeurs du presse papier</returns>
        public Dictionary<int, Dictionary<int, string>> ClipBoardValues(string clipboardValue)
        {
            Dictionary<int, Dictionary<int, string>> copyValues = new Dictionary<int, Dictionary<int, string>>();
            String[] lines = clipboardValue.Split('\n');
            for (int i = 0; i <= lines.Length - 1; i++)
            {
                copyValues[i] = new Dictionary<int, string>();
                String[] lineContent = lines[i].Split('\t');

                //if an empty cell value copied, then set the dictionary with an empty string
                //else Set value to dictionary
                if (lineContent.Length == 0)
                    copyValues[i][0] = string.Empty;
                else
                {
                    for (int j = 0; j <= lineContent.Length - 1; j++)
                        copyValues[i][j] = lineContent[j];
                }
            }
            return copyValues;
        }

        /// <summary>
        /// Copy le tableur dans le presse papier
        /// </summary>
        /// <param name="dgvTableur"></param>
        public void CopyToClipboard(DataGridView dgvTableur)
        {
            //Copy to clipboard
            DataObject dataObj = dgvTableur.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        /// <summary>
        /// Colle les valeurs du dictionnaire dans le tableur
        /// </summary>
        /// <param name="dgvTableur"></param>
        public void PasteClipboardValue(DataGridView dgvTableur)
        {
            //Show Error if no cell is selected
            if (dgvTableur.SelectedCells.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner une cellule", "Paste",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Get the starting Cell
            DataGridViewCell startCell = GetStartCell(dgvTableur);
            //Get the clipboard value in a dictionary
            Dictionary<int, Dictionary<int, string>> cbValue = ClipBoardValues(Clipboard.GetText());
            int iRowIndex = startCell.RowIndex;
            foreach (int rowKey in cbValue.Keys)
            {
                int iColIndex = startCell.ColumnIndex;
                foreach (int cellKey in cbValue[rowKey].Keys)
                {
                    //Check if the index is within the limit
                    if (iColIndex <= dgvTableur.Columns.Count - 1 && iRowIndex <= dgvTableur.Rows.Count - 1)
                    {
                        DataGridViewCell cell = dgvTableur[iColIndex, iRowIndex];
                        cell.Value = Convert.ChangeType(cbValue[rowKey][cellKey],cell.ValueType);
                    }
                    iColIndex++;
                }
                iRowIndex++;
            }
        }

        /// <summary>
        /// Calcul la première cellule selectionné
        /// </summary>
        /// <param name="dgView"></param>
        /// <returns></returns>
        public DataGridViewCell GetStartCell(DataGridView dgView)
        {
            //get the smallest row,column index
            if (dgView.SelectedCells.Count == 0)
                return null;

            int rowIndex = dgView.Rows.Count - 1;
            int colIndex = dgView.Columns.Count - 1;

            foreach (DataGridViewCell dgvCell in dgView.SelectedCells)
            {
                if (dgvCell.RowIndex < rowIndex)
                    rowIndex = dgvCell.RowIndex;
                if (dgvCell.ColumnIndex < colIndex)
                    colIndex = dgvCell.ColumnIndex;
            }

            return dgView[colIndex, rowIndex];
        }
    }
}
