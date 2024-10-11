using System.Collections.Generic;
using System.Windows.Forms;
using ЛР_03_03_Пироговський;

public class CryptoData
{
    public CryptoData()
    {
    }
    public List<CryptoCurrency> ListOfCrypto { set; get; } = new List<CryptoCurrency>();
    public DataGridView _dataGrid { set; get; } = new DataGridView();
    public void add(CryptoCurrency item)
    {
        ListOfCrypto.Add(item);
    }

    public void RefreshDataGrid()
    {
        _dataGrid.Rows.Clear();
        for (int i = 0; i < ListOfCrypto.Count; i++)
        {
            _dataGrid.Rows.Add();
            ListOfCrypto[i].FillDataGridRow(_dataGrid.Rows[i]);
        }
    }
}
