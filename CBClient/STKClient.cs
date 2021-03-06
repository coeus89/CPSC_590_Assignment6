using SP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CBClient
{
    class STKClient : SP.IStocksCallback, IDisposable
    {
        SP.StocksClient stkProxy = null;
        int myId = 0;

        public void OnPriceChange(SP.StockInfo sinfo)
        {
            MessageBox.Show("Price Change Notification Received (MYId = " + myId.ToString() + ")\n" + sinfo.Symbol + ":" + sinfo.Price.ToString());
        }

        public void Dispose()
        {
            stkProxy.Close();
        }

        public void SubscribeToPriceChange(string sym, double triggerPrice, int id)
        {
            try
            {
                myId = id;
                stkProxy = new SP.StocksClient(new System.ServiceModel.InstanceContext(this), "SPEP");
                //SPEP is the endpoint name for IStocks interface endpoint
                stkProxy.SubscribeToStockPrice(sym, triggerPrice);
            }
            catch
            {
                throw;
            }
        }

        public void UnsubscribeToPriceChange(string sym)
        {
            try
            {
                stkProxy?.UnsubscribeToStockPrice(sym);
            }
            catch
            {
                throw;
            }
        }
    }
}
