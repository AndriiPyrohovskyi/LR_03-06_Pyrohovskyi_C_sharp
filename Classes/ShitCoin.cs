using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛР_03_03_Пироговський
{
    [Serializable]
    public class ShitCoin : CryptoCurrency
    { 
        public string TypeOfCrypto { get; set; }
        public int RiskLevel { get; set; }
        public int ReliabilityOfDevelopers { get; set; }
        public ShitCoin() { }
        public ShitCoin(string shortName,
                          string fullName,
                          double lastPrice,
                          double priceChange24H,
                          double capitalization,
                          double volumeTrading,
                          int riskLevel,
                          int reliabilityOfDevelopers)
                          : base(shortName,
                                fullName,
                                lastPrice,
                                priceChange24H,
                                capitalization,
                                volumeTrading)
        {
            TypeOfCrypto = "Шіткоін";
            RiskLevel = riskLevel;
            ReliabilityOfDevelopers = reliabilityOfDevelopers;
        }
        ~ShitCoin() { }
        public override void FillDataGridRow(DataGridViewRow row)
        {
            base.FillDataGridRow(row);
            row.Cells[6].Value = "Шіткоін";
            row.Cells[9].Value = RiskLevel;
            row.Cells[10].Value = ReliabilityOfDevelopers;
        }
    }
}
