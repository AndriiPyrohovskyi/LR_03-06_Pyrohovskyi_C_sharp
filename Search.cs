using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛР_03_03_Пироговський
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox[] doubleFields = { textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9, textBox10, textBox19, textBox20 };
            TextBox[] intFields = { textBox14, textBox15, textBox16, textBox17, textBox23, textBox24 };

            foreach (var field in doubleFields)
            {
                if (!string.IsNullOrEmpty(field.Text) && (!double.TryParse(field.Text, out double value) || value < 0))
                {
                    MessageBox.Show($"Поле {field.Name} має бути додатним числом.");
                    return;
                }
            }

            foreach (var field in intFields)
            {
                if (!string.IsNullOrEmpty(field.Text) && !int.TryParse(field.Text, out int intValue))
                {
                    MessageBox.Show($"Поле {field.Name} має бути цілим числом.");
                    return;
                }
            }
            string b1 = textBox1.Text;
            string b2 = textBox2.Text;

            double b3min = GetValueOrDefault(textBox3, double.MinValue);
            double b3max = GetValueOrDefault(textBox4, double.MaxValue);
            double b4min = GetValueOrDefault(textBox5, double.MinValue);
            double b4max = GetValueOrDefault(textBox6, double.MaxValue);
            double b5min = GetValueOrDefault(textBox7, double.MinValue);
            double b5max = GetValueOrDefault(textBox8, double.MaxValue);
            double b6min = GetValueOrDefault(textBox9, double.MinValue);
            double b6max = GetValueOrDefault(textBox10, double.MaxValue);

            string b7 = textBox11.Text;
            string b8 = textBox12.Text;
            string b9 = textBox13.Text;

            int b10min = GetValueOrDefault(textBox14, int.MinValue);
            int b10max = GetValueOrDefault(textBox15, int.MaxValue);
            int b11min = GetValueOrDefault(textBox16, int.MinValue);
            int b11max = GetValueOrDefault(textBox17, int.MaxValue);

            string b12 = textBox18.Text;

            double b13min = GetValueOrDefault(textBox19, double.MinValue);
            double b13max = GetValueOrDefault(textBox20, double.MaxValue);

            string b14 = textBox21.Text;
            string b15 = textBox22.Text;

            int b16min = GetValueOrDefault(textBox23, int.MinValue);
            int b16max = GetValueOrDefault(textBox24, int.MaxValue);

            for (int i = 0; i < MainMenu.MainList._dataGrid.Rows.Count; i++)
            {
                var row = MainMenu.MainList._dataGrid.Rows[i];
                bool isVisible = true;
                string cellValue0 = row.Cells[0].Value?.ToString() ?? "";
                string cellValue1 = row.Cells[1].Value?.ToString() ?? "";
                string cellValue6 = row.Cells[6].Value?.ToString() ?? "";
                string cellValue7 = row.Cells[7].Value?.ToString() ?? "";
                string cellValue8 = row.Cells[8].Value?.ToString() ?? "";
                string cellValue11 = row.Cells[11].Value?.ToString() ?? "";
                string cellValue13 = row.Cells[13].Value?.ToString() ?? "";
                string cellValue14 = row.Cells[14].Value?.ToString() ?? "";
                string cellValue15 = row.Cells[15].Value?.ToString() ?? "";

                if (cellValue0 != b1 && b1 != "" ||
                    cellValue1 != b2 && b2 != "" ||
                    !CheckRange(row.Cells[2].Value, b3min, b3max) ||
                    !CheckRange(row.Cells[3].Value, b4min, b4max) ||
                    !CheckRange(row.Cells[4].Value, b5min, b5max) ||
                    !CheckRange(row.Cells[5].Value, b6min, b6max) ||
                    cellValue6 != b7 && b7 != "" ||
                    cellValue7 != b8 && b8 != "" ||
                    cellValue8 != b9 && b9 != "" ||
                    !CheckRange(row.Cells[9].Value, b10min, b10max, true) ||
                    !CheckRange(row.Cells[10].Value, b11min, b11max, true) ||
                    cellValue11 != b12 && b12 != "" ||
                    !CheckRange(row.Cells[12].Value, b13min, b13max) ||
                    cellValue13 != b14 && b14 != "" ||
                    cellValue14 != b15 && b15 != "" ||
                    !CheckRange(cellValue15, b16min, b16max, true))
                {
                    isVisible = false;
                }
                row.Visible = isVisible;
            }

        }
        private bool CheckRange(object value, double min, double max, bool isInt = false)
        {
            if (value == null || string.IsNullOrEmpty(value.ToString()))
                return true;

            if (isInt)
            {
                if (int.TryParse(value.ToString(), out int intValue))
                    return intValue >= min && intValue <= max;
            }
            else
            {
                if (double.TryParse(value.ToString(), out double doubleValue))
                    return doubleValue >= min && doubleValue <= max;
            }

            return false;
        }

        private double GetValueOrDefault(TextBox textBox, double defaultValue)
        {
            return string.IsNullOrEmpty(textBox.Text) ? defaultValue : double.Parse(textBox.Text);
        }

        private int GetValueOrDefault(TextBox textBox, int defaultValue)
        {
            return string.IsNullOrEmpty(textBox.Text) ? defaultValue : int.Parse(textBox.Text);
        }
    }
}
