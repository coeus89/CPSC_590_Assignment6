using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace PubSubLib
{
    [ServiceContract]
    interface IPriceChange
    {
        [OperationContract()]
        bool ChangeStockPrice(string symbol, double newprice);
    }
}
