using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ЛР_03_03_Пироговський
{
    public partial class MainMenu : Form
    {
        public static CryptoData MainList = new CryptoData();
        public void Starter()
        {
            label1.Parent = Questionnaire;
            label2.Parent = Questionnaire;
            label3.Parent = Questionnaire;
            label4.Parent = Questionnaire;
            label5.Parent = Questionnaire;
            label6.Parent = Questionnaire;
            label7.Parent = Questionnaire;
            label8.Parent = Questionnaire;
            label9.Parent = Questionnaire;
            label10.Parent = Questionnaire;
            label11.Parent = Questionnaire;
            label12.Parent = Questionnaire;
            label13.Parent = Questionnaire;
            label1.Text = string.Empty;
            label2.Text = string.Empty;
            label3.Text = string.Empty;
            label4.Text = string.Empty;
            label5.Text = string.Empty;
            label6.Text = string.Empty;
            label7.Text = string.Empty;
            label8.Text = string.Empty;
            label9.Text = string.Empty;
            label10.Text = string.Empty;
            label11.Text = string.Empty;
            label12.Visible = false;
            label13.Text = string.Empty;
            pictureBox2.Parent = pictureBox1;
            pictureBox3.Parent = pictureBox1;
            pictureBox4.Parent = pictureBox1;
            pictureBox5.Parent = pictureBox1;
            pictureBox6.Parent = pictureBox1;
            pictureBox7.Parent = pictureBox1;
        }
        public int Type = 1;
        public void CryptoPositions()
        {
            Questionnaire.Image = Properties.Resources.questionnaire1;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
        }
        public void StablePositions()
        {
            Questionnaire.Image = Properties.Resources.questionnaire3;
            label7.Visible = true; label7.Location = new Point(205, 483); // 490 - 7
            label8.Visible = true; label8.Location = new Point(195, 516); // 523 - 7
            label9.Visible = true; label9.Location = new Point(240, 550); // 523 - 7
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
        }
        public void ShitPositions()
        {
            Questionnaire.Image = Properties.Resources.questionnaire4;
            label7.Visible = true; label7.Location = new Point(205, 483); // 490 - 7
            label8.Visible = true; label8.Location = new Point(225, 515); // 522 - 7
            label9.Visible = true; label9.Location = new Point(319, 545); // 552 - 7
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
        }
        public void BlockchainPositions()
        {
            Questionnaire.Image = Properties.Resources.questionnaire6;
            label7.Visible = true; label7.Location = new Point(205, 483); // 490 - 7
            label8.Visible = true; label8.Location = new Point(196, 516); // 523 - 7
            label9.Visible = true; label9.Location = new Point(240, 546); // 553 - 7
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
        }
        public void MemePositions()
        {
            Questionnaire.Image = Properties.Resources.questionnaire7;
            label7.Visible = true; label7.Location = new Point(205, 483); // 490 - 7
            label8.Visible = true; label8.Location = new Point(196, 516); // 523 - 7
            label9.Visible = true; label9.Location = new Point(240, 546); // 553 - 7
            label10.Visible = true; label10.Location = new Point(240, 578); // 585 - 7
            label11.Visible = true; label11.Location = new Point(179, 609); // 616 - 7
            label12.Visible = true;
            label13.Visible = true;
        }
        public void CoinPositions()
        {
            Questionnaire.Image = Properties.Resources.questionnaire5;
            label7.Visible = true; label7.Location = new Point(205, 483); // 490 - 7
            label8.Visible = true; label8.Location = new Point(196, 516); // 523 - 7
            label9.Visible = true; label9.Location = new Point(240, 546); // 553 - 7
            label10.Visible = true; label10.Location = new Point(137, 578); // 585 - 7
            label11.Visible = false;
            label12.Visible = true;
            label13.Visible = true;
        }
        public MainMenu()
        {
            InitializeComponent();
            Starter();
            MainList._dataGrid = TableOfCrypto;
        }
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMenu addMenu = new AddMenu();
            addMenu.Show();
        }
        private void TableOfCrypto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0 || e.RowIndex >= MainList.ListOfCrypto.Count)
                {
                    throw new IndexOutOfRangeException("Вихід за межі масиву.");
                }
                if (MainList.ListOfCrypto[e.RowIndex].GetType() == typeof(CryptoCurrency))
                {
                    CryptoPositions();
                    label1.Text = TableOfCrypto.Rows[e.RowIndex].Cells[0].Value.ToString();
                    label2.Text = TableOfCrypto.Rows[e.RowIndex].Cells[1].Value.ToString();
                    label3.Text = TableOfCrypto.Rows[e.RowIndex].Cells[2].Value.ToString();
                    label4.Text = TableOfCrypto.Rows[e.RowIndex].Cells[3].Value.ToString();
                    label5.Text = TableOfCrypto.Rows[e.RowIndex].Cells[4].Value.ToString();
                    label6.Text = TableOfCrypto.Rows[e.RowIndex].Cells[5].Value.ToString();
                }
                if (MainList.ListOfCrypto[e.RowIndex].GetType() == typeof(StableCoin))
                {
                    StablePositions();
                    label1.Text = TableOfCrypto.Rows[e.RowIndex].Cells[0].Value.ToString();
                    label2.Text = TableOfCrypto.Rows[e.RowIndex].Cells[1].Value.ToString();
                    label3.Text = TableOfCrypto.Rows[e.RowIndex].Cells[2].Value.ToString();
                    label4.Text = TableOfCrypto.Rows[e.RowIndex].Cells[3].Value.ToString();
                    label5.Text = TableOfCrypto.Rows[e.RowIndex].Cells[4].Value.ToString();
                    label6.Text = TableOfCrypto.Rows[e.RowIndex].Cells[5].Value.ToString();
                    label7.Text = TableOfCrypto.Rows[e.RowIndex].Cells[6].Value.ToString();
                    label8.Text = TableOfCrypto.Rows[e.RowIndex].Cells[7].Value.ToString();
                    label9.Text = TableOfCrypto.Rows[e.RowIndex].Cells[8].Value.ToString();
                }
                if (MainList.ListOfCrypto[e.RowIndex].GetType() == typeof(ShitCoin))
                {
                    ShitPositions();
                    label1.Text = TableOfCrypto.Rows[e.RowIndex].Cells[0].Value.ToString();
                    label2.Text = TableOfCrypto.Rows[e.RowIndex].Cells[1].Value.ToString();
                    label3.Text = TableOfCrypto.Rows[e.RowIndex].Cells[2].Value.ToString();
                    label4.Text = TableOfCrypto.Rows[e.RowIndex].Cells[3].Value.ToString();
                    label5.Text = TableOfCrypto.Rows[e.RowIndex].Cells[4].Value.ToString();
                    label6.Text = TableOfCrypto.Rows[e.RowIndex].Cells[5].Value.ToString();
                    label7.Text = TableOfCrypto.Rows[e.RowIndex].Cells[6].Value.ToString();
                    label8.Text = TableOfCrypto.Rows[e.RowIndex].Cells[9].Value.ToString();
                    label9.Text = TableOfCrypto.Rows[e.RowIndex].Cells[10].Value.ToString();
                }
                if (MainList.ListOfCrypto[e.RowIndex].GetType() == typeof(Blockchain))
                {
                    BlockchainPositions();
                    label1.Text = TableOfCrypto.Rows[e.RowIndex].Cells[0].Value.ToString();
                    label2.Text = TableOfCrypto.Rows[e.RowIndex].Cells[1].Value.ToString();
                    label3.Text = TableOfCrypto.Rows[e.RowIndex].Cells[2].Value.ToString();
                    label4.Text = TableOfCrypto.Rows[e.RowIndex].Cells[3].Value.ToString();
                    label5.Text = TableOfCrypto.Rows[e.RowIndex].Cells[4].Value.ToString();
                    label6.Text = TableOfCrypto.Rows[e.RowIndex].Cells[5].Value.ToString();
                    label7.Text = TableOfCrypto.Rows[e.RowIndex].Cells[6].Value.ToString();
                    label8.Text = TableOfCrypto.Rows[e.RowIndex].Cells[11].Value.ToString();
                    label9.Text = TableOfCrypto.Rows[e.RowIndex].Cells[12].Value.ToString();
                }
                if (MainList.ListOfCrypto[e.RowIndex].GetType() == typeof(MemeCoin))
                {
                    MemePositions();
                    label1.Text = TableOfCrypto.Rows[e.RowIndex].Cells[0].Value.ToString();
                    label2.Text = TableOfCrypto.Rows[e.RowIndex].Cells[1].Value.ToString();
                    label3.Text = TableOfCrypto.Rows[e.RowIndex].Cells[2].Value.ToString();
                    label4.Text = TableOfCrypto.Rows[e.RowIndex].Cells[3].Value.ToString();
                    label5.Text = TableOfCrypto.Rows[e.RowIndex].Cells[4].Value.ToString();
                    label6.Text = TableOfCrypto.Rows[e.RowIndex].Cells[5].Value.ToString();
                    label7.Text = TableOfCrypto.Rows[e.RowIndex].Cells[6].Value.ToString();
                    label8.Text = TableOfCrypto.Rows[e.RowIndex].Cells[11].Value.ToString();
                    label9.Text = TableOfCrypto.Rows[e.RowIndex].Cells[12].Value.ToString();
                    label10.Text = TableOfCrypto.Rows[e.RowIndex].Cells[14].Value.ToString();
                    label11.Text = TableOfCrypto.Rows[e.RowIndex].Cells[15].Value.ToString();
                    label13.Text = TableOfCrypto.Rows[e.RowIndex].Cells[13].Value.ToString();
                }
                if (MainList.ListOfCrypto[e.RowIndex].GetType() == typeof(Coins))
                {
                    CoinPositions();
                    label1.Text = TableOfCrypto.Rows[e.RowIndex].Cells[0].Value.ToString();
                    label2.Text = TableOfCrypto.Rows[e.RowIndex].Cells[1].Value.ToString();
                    label3.Text = TableOfCrypto.Rows[e.RowIndex].Cells[2].Value.ToString();
                    label4.Text = TableOfCrypto.Rows[e.RowIndex].Cells[3].Value.ToString();
                    label5.Text = TableOfCrypto.Rows[e.RowIndex].Cells[4].Value.ToString();
                    label6.Text = TableOfCrypto.Rows[e.RowIndex].Cells[5].Value.ToString();
                    label7.Text = TableOfCrypto.Rows[e.RowIndex].Cells[6].Value.ToString();
                    label8.Text = TableOfCrypto.Rows[e.RowIndex].Cells[11].Value.ToString();
                    label9.Text = TableOfCrypto.Rows[e.RowIndex].Cells[12].Value.ToString();
                    label10.Text = TableOfCrypto.Rows[e.RowIndex].Cells[16].Value.ToString();
                    label13.Text = TableOfCrypto.Rows[e.RowIndex].Cells[13].Value.ToString();
                }
            }
            // test command
            catch (IndexOutOfRangeException ex)
            {

            }
            catch (Exception ex)
            {
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < TableOfCrypto.Rows.Count - 1; i++)
            {
                if (MainList.ListOfCrypto[i].GetType() != typeof(CryptoCurrency))
                {
                    TableOfCrypto.Rows[i].Visible = false;
                }
                else TableOfCrypto.Rows[i].Visible = true;
            }
            TableOfCrypto.Columns[6].Visible = false;
            TableOfCrypto.Columns[7].Visible = false;
            TableOfCrypto.Columns[8].Visible = false;
            TableOfCrypto.Columns[9].Visible = false;
            TableOfCrypto.Columns[10].Visible = false;
            TableOfCrypto.Columns[11].Visible = false;
            TableOfCrypto.Columns[12].Visible = false;
            TableOfCrypto.Columns[13].Visible = false;
            TableOfCrypto.Columns[14].Visible = false;
            TableOfCrypto.Columns[15].Visible = false;
            TableOfCrypto.Columns[16].Visible = false;
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < TableOfCrypto.Rows.Count; i++)
            {
                if (MainList.ListOfCrypto[i].GetType() != typeof(StableCoin))
                {
                    TableOfCrypto.Rows[i].Visible = false;
                }
                else TableOfCrypto.Rows[i].Visible = true;
            }
            TableOfCrypto.Columns[6].Visible = true;
            TableOfCrypto.Columns[7].Visible = true;
            TableOfCrypto.Columns[8].Visible = true;
            TableOfCrypto.Columns[9].Visible = false;
            TableOfCrypto.Columns[10].Visible = false;
            TableOfCrypto.Columns[11].Visible = false;
            TableOfCrypto.Columns[12].Visible = false;
            TableOfCrypto.Columns[13].Visible = false;
            TableOfCrypto.Columns[14].Visible = false;
            TableOfCrypto.Columns[15].Visible = false;
            TableOfCrypto.Columns[16].Visible = false;
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < TableOfCrypto.Rows.Count; i++)
            {
                if (MainList.ListOfCrypto[i].GetType() != typeof(ShitCoin))
                {
                    TableOfCrypto.Rows[i].Visible = false;
                }
                else TableOfCrypto.Rows[i].Visible = true;
            }
            TableOfCrypto.Columns[6].Visible = true;
            TableOfCrypto.Columns[7].Visible = false;
            TableOfCrypto.Columns[8].Visible = false;
            TableOfCrypto.Columns[9].Visible = true;
            TableOfCrypto.Columns[10].Visible = true;
            TableOfCrypto.Columns[11].Visible = false;
            TableOfCrypto.Columns[12].Visible = false;
            TableOfCrypto.Columns[13].Visible = false;
            TableOfCrypto.Columns[14].Visible = false;
            TableOfCrypto.Columns[15].Visible = false;
            TableOfCrypto.Columns[16].Visible = false;
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вивести криптовалюти наслідувані від блокчейну?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                for (int i = 0; i < TableOfCrypto.Rows.Count; i++)
                {
                    if (MainList.ListOfCrypto[i].GetType() != typeof(Blockchain) && MainList.ListOfCrypto[i].GetType() != typeof(MemeCoin) && MainList.ListOfCrypto[i].GetType() != typeof(Coins))
                    {
                        TableOfCrypto.Rows[i].Visible = false;
                    }
                    else TableOfCrypto.Rows[i].Visible = true;
                }
                TableOfCrypto.Columns[6].Visible = true;
                TableOfCrypto.Columns[7].Visible = false;
                TableOfCrypto.Columns[8].Visible = false;
                TableOfCrypto.Columns[9].Visible = false;
                TableOfCrypto.Columns[10].Visible = false;
                TableOfCrypto.Columns[11].Visible = true;
                TableOfCrypto.Columns[12].Visible = true;
                TableOfCrypto.Columns[13].Visible = true;
                TableOfCrypto.Columns[14].Visible = true;
                TableOfCrypto.Columns[15].Visible = true;
                TableOfCrypto.Columns[16].Visible = true;
            }
            else if (result == DialogResult.No)
            {
                for (int i = 0; i < TableOfCrypto.Rows.Count; i++)
                {
                    if (MainList.ListOfCrypto[i].GetType() != typeof(Blockchain))
                    {
                        TableOfCrypto.Rows[i].Visible = false;
                    }
                    else TableOfCrypto.Rows[i].Visible = true;
                }
                TableOfCrypto.Columns[6].Visible = true;
                TableOfCrypto.Columns[7].Visible = false;
                TableOfCrypto.Columns[8].Visible = false;
                TableOfCrypto.Columns[9].Visible = false;
                TableOfCrypto.Columns[10].Visible = false;
                TableOfCrypto.Columns[11].Visible = true;
                TableOfCrypto.Columns[12].Visible = true;
                TableOfCrypto.Columns[13].Visible = false;
                TableOfCrypto.Columns[14].Visible = false;
                TableOfCrypto.Columns[15].Visible = false;
                TableOfCrypto.Columns[16].Visible = false;
            }
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < TableOfCrypto.Rows.Count; i++)
            {
                if (MainList.ListOfCrypto[i].GetType() != typeof(MemeCoin))
                {
                    TableOfCrypto.Rows[i].Visible = false;
                }
                else TableOfCrypto.Rows[i].Visible = true;
            }
            TableOfCrypto.Columns[6].Visible = true;
            TableOfCrypto.Columns[7].Visible = false;
            TableOfCrypto.Columns[8].Visible = false;
            TableOfCrypto.Columns[9].Visible = false;
            TableOfCrypto.Columns[10].Visible = false;
            TableOfCrypto.Columns[11].Visible = true;
            TableOfCrypto.Columns[12].Visible = true;
            TableOfCrypto.Columns[13].Visible = true;
            TableOfCrypto.Columns[14].Visible = true;
            TableOfCrypto.Columns[15].Visible = true;
            TableOfCrypto.Columns[16].Visible = false;
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < TableOfCrypto.Rows.Count; i++)
            {
                if (MainList.ListOfCrypto[i].GetType() != typeof(Coins))
                {
                    TableOfCrypto.Rows[i].Visible = false;
                }
                else TableOfCrypto.Rows[i].Visible = true;
            }
            TableOfCrypto.Columns[6].Visible = true;
            TableOfCrypto.Columns[7].Visible = false;
            TableOfCrypto.Columns[8].Visible = false;
            TableOfCrypto.Columns[9].Visible = false;
            TableOfCrypto.Columns[10].Visible = false;
            TableOfCrypto.Columns[11].Visible = true;
            TableOfCrypto.Columns[12].Visible = true;
            TableOfCrypto.Columns[13].Visible = true;
            TableOfCrypto.Columns[14].Visible = false;
            TableOfCrypto.Columns[15].Visible = false;
            TableOfCrypto.Columns[16].Visible = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < TableOfCrypto.Rows.Count; i++)
            {
                TableOfCrypto.Rows[i].Visible = true;
            }
            TableOfCrypto.Columns[6].Visible = true;
            TableOfCrypto.Columns[7].Visible = true;
            TableOfCrypto.Columns[8].Visible = true;
            TableOfCrypto.Columns[9].Visible = true;
            TableOfCrypto.Columns[10].Visible = true;
            TableOfCrypto.Columns[11].Visible = true;
            TableOfCrypto.Columns[12].Visible = true;
            TableOfCrypto.Columns[13].Visible = true;
            TableOfCrypto.Columns[14].Visible = true;
            TableOfCrypto.Columns[15].Visible = true;
            TableOfCrypto.Columns[16].Visible = true;
        }
        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Show();
        }
        public interface IWorkWithFile
        {
            void WorkWithFile(string format);
        }
        public class Read : IWorkWithFile
        {
            public void WorkWithFile(string format)
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = format;
                    openFileDialog.Title = "Виберіть файл для відкриття";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = openFileDialog.FileName;

                        if (filePath.EndsWith(".txt"))
                        {
                            string[] lines = File.ReadAllLines(filePath);
                            foreach (var line in lines)
                            {
                                string[] rowData = line.Split(new char[] { '\t' }, StringSplitOptions.None);
                                MainList._dataGrid.Rows.Add(rowData);
                            }
                        }
                        else if (filePath.EndsWith(".dat"))
                        {
                            using (StreamReader reader = new StreamReader(File.Open(filePath, FileMode.Open)))
                            {
                                while (!reader.EndOfStream)
                                {
                                    string line = reader.ReadLine();
                                    string[] rowData = line.Split(new char[] { '\t' }, StringSplitOptions.None);
                                    MainList._dataGrid.Rows.Add(rowData);
                                }
                            }
                        }
                    }
                }
                MainList.AllocateList();
                MainList.RefreshDataGrid();
            }
        }
        public class Write : IWorkWithFile
        {
            public void WorkWithFile(string format)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = format;
                    saveFileDialog.Title = "Збережіть файл як";
                    saveFileDialog.FileName = "document";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;

                        if (filePath.EndsWith(".dat"))
                        {
                            using (StreamWriter writer = new StreamWriter(File.Open(filePath, FileMode.Create)))
                            {
                                foreach (DataGridViewRow row in MainList._dataGrid.Rows)
                                {
                                    if (!row.IsNewRow)
                                    {
                                        List<string> rowData = new List<string>();
                                        foreach (DataGridViewCell cell in row.Cells)
                                        {
                                            rowData.Add(cell.Value != null ? cell.Value.ToString() : "");
                                        }
                                        writer.WriteLine(string.Join("\t", rowData));
                                    }
                                }
                            }
                        }
                        else if (filePath.EndsWith(".txt"))
                        {
                            using (StreamWriter writer = new StreamWriter(File.Open(filePath, FileMode.Create)))
                            {
                                foreach (DataGridViewRow row in MainList._dataGrid.Rows)
                                {
                                    if (!row.IsNewRow)
                                    {
                                        List<string> rowData = new List<string>();
                                        foreach (DataGridViewCell cell in row.Cells)
                                        {
                                            rowData.Add(cell.Value != null ? cell.Value.ToString() : "");
                                        }
                                        writer.WriteLine(string.Join("\t", rowData));
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public abstract class Format
        {
            protected IWorkWithFile _workWithFile;
            protected Format(IWorkWithFile workWithFile)
            {
                _workWithFile = workWithFile;
            }
            public abstract void WorkWithFile();
        }
        public class DAT : Format
        {
            public DAT(IWorkWithFile workWithFile) : base(workWithFile) { }
            public override void WorkWithFile()
            {
                _workWithFile.WorkWithFile("Binnary Files (*.dat)|*.dat|All Files (*.*)|*.*");
            }
        }
        public class TXT : Format
        {
            public TXT(IWorkWithFile workWithFile) : base(workWithFile) { }
            public override void WorkWithFile()
            {
                _workWithFile.WorkWithFile("Text Files (*.txt)|*.txt|All Files (*.*)|*.*");
            }
        }

        private void fromBinnaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IWorkWithFile dat = new Read();
            Format datRead = new DAT(dat);
            datRead.WorkWithFile();
        }
        private void fromtxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IWorkWithFile txt = new Read();
            Format txtRead = new TXT(txt);
            txtRead.WorkWithFile();
        }
        private void todatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IWorkWithFile dat = new Write();
            Format datWrite = new DAT(dat);
            datWrite.WorkWithFile();
        }
        private void totxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IWorkWithFile txt = new Write();
            Format txtWrite = new TXT(txt);
            txtWrite.WorkWithFile();
        }
    }
}
