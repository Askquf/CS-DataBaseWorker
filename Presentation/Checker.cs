using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Presentation
{
    public static class Checker
    {
       public static bool CheckRows(DataGridView dataGridView)
       {
            bool res = true;
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Choose rows!");
                res = false;
            }
            else
                for (int i = 0; i < dataGridView.SelectedRows.Count; i++)
                {
                    if (dataGridView.SelectedRows[i] == dataGridView.Rows[dataGridView.Rows.Count - 1])
                    {
                        MessageBox.Show("Choose unnulled row!");
                        res = false;
                    }
                }
            return res;
       }

        public static bool IntCheck(string toCheck)
        {
            bool res = true;
            if (toCheck != "")
                for (int i = 0; i < toCheck.Length; i++)
                    if (!Char.IsNumber(toCheck[i]))
                        res = false;
            return res;
        }
    }
}
