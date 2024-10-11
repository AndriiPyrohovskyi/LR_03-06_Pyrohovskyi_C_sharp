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
            switch (AddMenu.Type1)
            {
                case 1:
                    {
                        CryptoCurrency currency = new CryptoCurrency(textBox1.Text, textBox2.Text, Double.Parse(textBox3.Text), Double.Parse(textBox4.Text), Double.Parse(textBox5.Text), Double.Parse(textBox6.Text));
                        MainMenu.MainList.add(currency);
                        MainMenu.MainList.RefreshDataGrid();
                        break;
                    }
                case 2:
                    {
                        CryptoCurrency stable = new StableCoin(textBox1.Text, textBox2.Text, Double.Parse(textBox3.Text), Double.Parse(textBox4.Text), Double.Parse(textBox5.Text), Double.Parse(textBox6.Text), textBox8.Text, textBox9.Text);
                        MainMenu.MainList.add(stable);
                        MainMenu.MainList.RefreshDataGrid();
                        break;
                    }
                case 3:
                    {
                        CryptoCurrency blockchain = new Blockchain(textBox1.Text, textBox2.Text, Double.Parse(textBox3.Text), Double.Parse(textBox4.Text), Double.Parse(textBox5.Text), Double.Parse(textBox6.Text), textBox8.Text, Double.Parse(textBox9.Text));
                        MainMenu.MainList.add(blockchain);
                        MainMenu.MainList.RefreshDataGrid();
                        break;
                    }
                case 4:
                    {
                        CryptoCurrency shit = new ShitCoin(textBox1.Text, textBox2.Text, Double.Parse(textBox3.Text), Double.Parse(textBox4.Text), Double.Parse(textBox5.Text), Double.Parse(textBox6.Text), int.Parse(textBox8.Text), int.Parse(textBox9.Text));
                        MainMenu.MainList.add(shit);
                        MainMenu.MainList.RefreshDataGrid();
                        break;
                    }
                case 5:
                    {
                        CryptoCurrency meme = new MemeCoin(textBox1.Text, textBox2.Text, Double.Parse(textBox3.Text), Double.Parse(textBox4.Text), Double.Parse(textBox5.Text), Double.Parse(textBox6.Text), textBox8.Text, Double.Parse(textBox9.Text), textBox10.Text, int.Parse(textBox11.Text));
                        MainMenu.MainList.add(meme);
                        MainMenu.MainList.RefreshDataGrid();
                        break;
                    }
                case 6:
                    {
                        CryptoCurrency coin = new Coins(textBox1.Text, textBox2.Text, Double.Parse(textBox3.Text), Double.Parse(textBox4.Text), Double.Parse(textBox5.Text), Double.Parse(textBox6.Text), textBox8.Text, Double.Parse(textBox9.Text), textBox10.Text);
                        MainMenu.MainList.add(coin);
                        MainMenu.MainList.RefreshDataGrid();
                        break;
                    }
            }
        }
    }
}
