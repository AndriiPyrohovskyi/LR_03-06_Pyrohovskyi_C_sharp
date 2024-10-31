using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛР_03_03_Пироговський
{
    public partial class MainMenu : Form
    {
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
        public static string SelectedCrypto = "";
        public static string SelectedCryptoType = "";
        public static int SelectedRow = 0;
        public static CryptoData MainList = new CryptoData();
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMenu addMenu = new AddMenu();
            addMenu.Show();
        }
        private void TableOfCrypto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedRow = e.RowIndex;
            SelectedCrypto = TableOfCrypto.Rows[e.RowIndex].Cells[0].Value.ToString();
            try
            {
                if (e.RowIndex < 0 || e.RowIndex >= MainList.ListOfCrypto.Count)
                {
                    throw new IndexOutOfRangeException("Вихід за межі масиву.");
                }
                if (MainList.ListOfCrypto[e.RowIndex].GetType() == typeof(CryptoCurrency))
                {
                    SelectedCryptoType = "CryptoCurrency";
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
                    SelectedCryptoType = "StableCoin";
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
                    SelectedCryptoType = "ShitCoin";
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
                    SelectedCryptoType = "Blockchain";
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
                    SelectedCryptoType = "MemeCoin";
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
                    SelectedCryptoType = "Coins";
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
                        try
                        {
                            string filePath = openFileDialog.FileName;
                            if (filePath.EndsWith(".txt"))
                            {
                                ReadTxtFile(filePath);
                            }
                            else if (filePath.EndsWith(".json"))
                            {
                                ReadJsonFile(filePath);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Помилка при читанні файлу: {ex.Message}");
                        }
                    }
                }
                MainList.AllocateList();
                MainList.RefreshDataGrid();
            }

            private void ReadTxtFile(string filePath)
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    string[] rowData = line.Split('\t');
                    MainList._dataGrid.Rows.Add(rowData);
                }
            }
            private void ReadJsonFile(string filePath)
            {
                try
                {
                    string json = File.ReadAllText(filePath);
                    var cryptoList = JsonConvert.DeserializeObject<List<CryptoCurrency>>(json);

                    if (cryptoList != null)
                    {
                        MainList.ListOfCrypto.Clear();
                        MainList.ListOfCrypto.AddRange(cryptoList);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка при читанні JSON: {ex.Message}");
                }
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
                        try
                        {
                            string filePath = saveFileDialog.FileName;
                            if (filePath.EndsWith(".json"))
                            {
                                WriteJsonFile(filePath);
                            }
                            else if (filePath.EndsWith(".txt"))
                            {
                                WriteTxtFile(filePath);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Помилка при збереженні файлу: {ex.Message}");
                        }
                    }
                }
            }
            private void WriteJsonFile(string filePath)
            {
                try
                {
                    string json = JsonConvert.SerializeObject(MainList.ListOfCrypto, Formatting.Indented);
                    File.WriteAllText(filePath, json);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка при збереженні JSON: {ex.Message}");
                }
            }
            private void WriteTxtFile(string filePath)
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (DataGridViewRow row in MainList._dataGrid.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            List<string> rowData = new List<string>();
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                rowData.Add(cell.Value?.ToString() ?? string.Empty);
                            }
                            writer.WriteLine(string.Join("\t", rowData));
                        }
                    }
                }
            }
        }

        public interface IWorkWithFile
        {
            void WorkWithFile(string format);
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

        public class JSON : Format
        {
            public JSON(IWorkWithFile workWithFile) : base(workWithFile) { }

            public override void WorkWithFile()
            {
                _workWithFile.WorkWithFile("JSON Files (*.json)|*.json|All Files (*.*)|*.*");
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
        private void ExecuteFileOperation(Format format)
        {
            format.WorkWithFile();
        }
        private void toJSONToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ExecuteFileOperation(new JSON(new Write()));
        }

        private void toTXTToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ExecuteFileOperation(new TXT(new Write()));
        }

        private void fromJSONToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ExecuteFileOperation(new JSON(new Read()));
        }

        private void fromTXTToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ExecuteFileOperation(new TXT(new Read()));
        }
        private async void button2_Click(object sender, EventArgs e)
        {
            string info = await Get24HrMarketInfo(SelectedCrypto + "USDT");
            if (info != "")
                MessageBox.Show(info, "Інформація за 24 години");
        }
        private async Task<string> Get24HrMarketInfo(string symbol)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string url = $"https://api.binance.com/api/v3/ticker/24hr?symbol={symbol}";
                    HttpResponseMessage response = await client.GetAsync(url);

                    response.EnsureSuccessStatusCode();

                    string responseData = await response.Content.ReadAsStringAsync();
                    JObject json = JObject.Parse(responseData);

                    string info = $"Остання ціна: {json["lastPrice"].ToString()}\n" +
                                  $"Відкриваюча ціна: {json["openPrice"].ToString()}\n" +
                                  $"Максимальна ціна: {json["highPrice"].ToString()}\n" +
                                  $"Мінімальна ціна: {json["lowPrice"].ToString()}\n" +
                                  $"Об'єм: {json["volume"].ToString()}\n" +
                                  $"Зміна ціни: {json["priceChangePercent"].ToString()}%";
                    return info;
                }
                catch (HttpRequestException httpEx)
                {
                    MessageBox.Show($"Помилка HTTP: {httpEx.Message}", "Помилка");
                }
                catch (JsonReaderException jsonEx)
                {
                    MessageBox.Show($"Помилка обробки JSON: {jsonEx.Message}", "Помилка");
                }
                catch (TaskCanceledException timeoutEx)
                {
                    MessageBox.Show($"Час очікування вичерпано: {timeoutEx.Message}", "Помилка");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Неочікувана помилка: {ex.Message}", "Помилка");
                }
                return "";
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (SelectedCryptoType == "StableCoin")
            {
                if (MainList.ListOfCrypto[SelectedRow].Validate()) MessageBox.Show("Стейблкоін стабільний.", "Успіх.");
                else MessageBox.Show("Стейблкоін нестабільний.", "Успіх.");
            }
        }
    }
}
