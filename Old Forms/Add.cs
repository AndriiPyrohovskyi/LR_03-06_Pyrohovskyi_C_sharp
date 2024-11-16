 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CryptoDataDLL;
namespace ЛР_03_03_Пироговський
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
            label2.Parent = Questionnaire;
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
            textBox7.Text = string.Empty;
            textBox8.Text = string.Empty;
            textBox9.Text = string.Empty;
            textBox10.Text = string.Empty;
            textBox11.Text = string.Empty;
            textBox12.Text = string.Empty;
            switch (AddMenu.Type1)
            {
                case 1: CryptoPositions(); break;
                case 2: StablePositions(); break;
                case 3: BlockchainPositions(); break;
                case 4: ShitPositions(); break;
                case 5: MemePositions(); break;
                case 6: CoinPositions(); break;
            }
        }

        private void Add_FormClosing(object sender, FormClosingEventArgs e)
        {
            AddMenu addMenu = new AddMenu();
            this.Hide();
            addMenu.Show();
        }
        public void CryptoPositions()
        {
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;
            label2.Visible = false;
            Questionnaire.Image = Properties.Resources.questionnaire1;
        }
        public void StablePositions()
        {
            textBox7.Visible = true; textBox7.Location = new Point(196, 464); textBox7.Size = new Size(266, 30); textBox7.Text = "Стейблкоін"; textBox7.Enabled = false;
            textBox8.Visible = true; textBox8.Location = new Point(196, 498); textBox8.Size = new Size(266, 30);
            textBox9.Visible = true; textBox9.Location = new Point(226, 530); textBox9.Size = new Size(236, 30);
            textBox10.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;
            label2.Visible = false;
            Questionnaire.Image = Properties.Resources.questionnaire3;
        }
        public void ShitPositions()
        {
            textBox7.Visible = true; textBox7.Location = new Point(196, 464); textBox7.Size = new Size(266, 30); textBox7.Text = "Блокчейн"; textBox7.Enabled = false;
            textBox8.Visible = true; textBox8.Location = new Point(217, 498); textBox8.Size = new Size(245, 30);
            textBox9.Visible = true; textBox9.Location = new Point(305, 530); textBox9.Size = new Size(157, 30);
            textBox10.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;
            label2.Visible = false;
            Questionnaire.Image = Properties.Resources.questionnaire4;
        }
        public void BlockchainPositions()
        {
            textBox7.Visible = true; textBox7.Location = new Point(196, 464); textBox7.Size = new Size(266, 30); textBox7.Text = "Шіткоін"; textBox7.Enabled = false;
            textBox8.Visible = true; textBox8.Location = new Point(196, 498); textBox8.Size = new Size(266, 30);
            textBox9.Visible = true; textBox9.Location = new Point(226, 530); textBox9.Size = new Size(236, 30);
            textBox10.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;
            label2.Visible = false;
            Questionnaire.Image = Properties.Resources.questionnaire6;
        }
        public void MemePositions()
        {
            textBox7.Visible = true; textBox7.Location = new Point(196, 464); textBox7.Size = new Size(266, 30); textBox7.Text = "Блокчейн"; textBox7.Enabled = false;
            textBox8.Visible = true; textBox8.Location = new Point(196, 498); textBox8.Size = new Size(266, 30);
            textBox9.Visible = true; textBox9.Location = new Point(226, 530); textBox9.Size = new Size(236, 30);
            textBox10.Visible = true; textBox10.Location = new Point(225, 562); textBox10.Size = new Size(236, 30);
            textBox11.Visible = true; textBox11.Location = new Point(169, 593); textBox11.Size = new Size(292, 30);
            textBox12.Visible = true; textBox12.Location = new Point(311, 625); textBox12.Size = new Size(151, 30); textBox12.Text = "Мемкоін"; textBox12.Enabled = false;
            label2.Visible = true; label2.Location = new Point(2, 643); 
            Questionnaire.Image = Properties.Resources.questionnaire7;
        }
        public void CoinPositions()
        {
            textBox7.Visible = true; textBox7.Location = new Point(196, 464); textBox7.Size = new Size(266, 30); textBox7.Text = "Блокчейн"; textBox7.Enabled = false;
            textBox8.Visible = true; textBox8.Location = new Point(196, 498); textBox8.Size = new Size(266, 30);
            textBox9.Visible = true; textBox9.Location = new Point(226, 530); textBox9.Size = new Size(236, 30);
            textBox10.Visible = true; textBox10.Location = new Point(122, 562); textBox10.Size = new Size(339, 30);
            textBox11.Visible = false;
            textBox12.Visible = true; textBox12.Location = new Point(311, 594); textBox12.Size = new Size(151, 30); textBox12.Text = "Монета"; textBox12.Enabled = false;
            label2.Visible = true; label2.Location = new Point(1, 615);
            Questionnaire.Image = Properties.Resources.questionnaire5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidateCommonFields()) return;

            switch (AddMenu.Type1)
            {
                case 1:
                    {
                        CreateCryptoCurrency();
                        break;
                    }
                case 2:
                    {
                        if (!ValidateTextBoxFields(new[] { textBox8, textBox9 })) return;

                        CryptoCurrency stable = new StableCoin(
                            textBox1.Text, textBox2.Text,
                            double.Parse(textBox3.Text), double.Parse(textBox4.Text),
                            double.Parse(textBox5.Text), double.Parse(textBox6.Text),
                            textBox8.Text, textBox9.Text);

                        AddAndRefresh(stable);
                        break;
                    }
                case 3:
                    {
                        if (!ValidateTextBoxFields(new[] { textBox8 }) || !TryParseDouble(textBox9.Text)) return;

                        CryptoCurrency blockchain = new Blockchain(
                            textBox1.Text, textBox2.Text,
                            double.Parse(textBox3.Text), double.Parse(textBox4.Text),
                            double.Parse(textBox5.Text), double.Parse(textBox6.Text),
                            textBox8.Text, double.Parse(textBox9.Text));

                        AddAndRefresh(blockchain);
                        break;
                    }
                case 4:
                    {
                        if (!ValidateTextBoxFields(new[] { textBox8, textBox9 }) || !TryParseInt(textBox8.Text) || !TryParseInt(textBox9.Text)) return;

                        CryptoCurrency shit = new ShitCoin(
                            textBox1.Text, textBox2.Text,
                            double.Parse(textBox3.Text), double.Parse(textBox4.Text),
                            double.Parse(textBox5.Text), double.Parse(textBox6.Text),
                            int.Parse(textBox8.Text), int.Parse(textBox9.Text));

                        AddAndRefresh(shit);
                        break;
                    }
                case 5:
                    {
                        if (!ValidateTextBoxFields(new[] { textBox8, textBox9, textBox10, textBox11 }) ||
                            !TryParseDouble(textBox9.Text) || !TryParseInt(textBox11.Text)) return;

                        CryptoCurrency meme = new MemeCoin(
                            textBox1.Text, textBox2.Text,
                            double.Parse(textBox3.Text), double.Parse(textBox4.Text),
                            double.Parse(textBox5.Text), double.Parse(textBox6.Text),
                            textBox8.Text, double.Parse(textBox9.Text),
                            textBox10.Text, int.Parse(textBox11.Text));

                        AddAndRefresh(meme);
                        break;
                    }
                case 6:
                    {
                        if (!ValidateTextBoxFields(new[] { textBox8, textBox9, textBox10 }) || !TryParseDouble(textBox9.Text)) return;

                        CryptoCurrency coin = new Coins(
                            textBox1.Text, textBox2.Text,
                            double.Parse(textBox3.Text), double.Parse(textBox4.Text),
                            double.Parse(textBox5.Text), double.Parse(textBox6.Text),
                            textBox8.Text, double.Parse(textBox9.Text), textBox10.Text);

                        AddAndRefresh(coin);
                        break;
                    }
            }
        }
        private bool ValidateCommonFields()
        {
            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty ||
                textBox3.Text == string.Empty || textBox4.Text == string.Empty ||
                textBox5.Text == string.Empty || textBox6.Text == string.Empty)
            {
                MessageBox.Show("Введіть всі дані.", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!TryParseDoubles(new[] { textBox3, textBox4, textBox5, textBox6 }))
            {
                MessageBox.Show("Дані введені неправильно.", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool ValidateTextBoxFields(TextBox[] fields)
        {
            foreach (var field in fields)
            {
                if (field.Text == string.Empty)
                {
                    MessageBox.Show("Введіть всі дані.", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }
        private bool TryParseDoubles(TextBox[] fields)
        {
            foreach (var field in fields)
            {
                if (!double.TryParse(field.Text, out _))
                    return false;
            }
            return true;
        }
        private bool TryParseDouble(string text) => double.TryParse(text, out _);
        private bool TryParseInt(string text) => int.TryParse(text, out _);

        private void AddAndRefresh(CryptoCurrency currency)
        {
            MainMenu.MainList.add(currency);
            MainMenu.MainList.RefreshDataGrid();
        }
        private void CreateCryptoCurrency()
        {
            CryptoCurrency currency = new CryptoCurrency(
                textBox1.Text, textBox2.Text,
                double.Parse(textBox3.Text), double.Parse(textBox4.Text),
                double.Parse(textBox5.Text), double.Parse(textBox6.Text));
            AddAndRefresh(currency);
        }

    }
}
