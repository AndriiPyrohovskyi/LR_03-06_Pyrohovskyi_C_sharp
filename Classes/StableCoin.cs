using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛР_03_03_Пироговський
{
    public class StableCoin : CryptoCurrency
    {
        public string TypeOfCrypto { get; set; }
        public string ConnectionWithActive { get; set; }
        public string StabilizationMechanizm { get; set; }
        public StableCoin() { }
        public StableCoin(string shortName, 
                          string fullName,
                          double lastPrice, 
                          double priceChange24H, 
                          double capitalization, 
                          double volumeTrading, 
                          string connectionWithActive, 
                          string stabilizationMechanizm) 
                          : base(shortName, 
                                fullName, 
                                lastPrice, 
                                priceChange24H, 
                                capitalization, 
                                volumeTrading)
        {

            TypeOfCrypto = "Стейблкоін";
            ConnectionWithActive = connectionWithActive;
            StabilizationMechanizm = stabilizationMechanizm;
        }
        ~StableCoin() { }
        public override void FillDataGridRow(DataGridViewRow row)
        {
            base.FillDataGridRow(row);
            row.Cells[6].Value = "Стейблкоін";
            row.Cells[7].Value = ConnectionWithActive;
            row.Cells[8].Value = StabilizationMechanizm;
        }
    }
}
