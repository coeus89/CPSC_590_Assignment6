using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PubSubLib
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class PubSub : ILongCompute, IStocks, IPriceChange
    {
        static List<IStockCallback> SubsriberList = new List<IStockCallback>();
        //static List<StockInfo> siList = new List<StockInfo>();
        static Dictionary<IStockCallback, List<StockInfo>> siDict = new Dictionary<IStockCallback, List<StockInfo>>();
        ComputeResult cr = new ComputeResult();
        Object olock = new object();


        #region ILongCompute Members
        public void Compute(int a, int b, string clientId)
        {
            Thread.Sleep(5000);// asssume 5 secs to produce result
            lock (olock)
            {
                cr.Result = 45.667 + a + b;
                cr.ResultTime = DateTime.Now;
                cr.ClientID = clientId;
                // trigger callback in client
                IComputeCallback callbackChannel =
                OperationContext.Current.GetCallbackChannel<IComputeCallback>();
                if (((ICommunicationObject)callbackChannel).State ==
               CommunicationState.Opened)
                    callbackChannel.OnComputeResult(cr);
            }
            Thread.Sleep(5000); // 5 more secs to produce updated res
            lock (olock)
            {
                cr.Result = cr.Result + a + b;
                cr.ResultTime = DateTime.Now;
                cr.ClientID = clientId;
                //trigger callback in client
                IComputeCallback callbackChannel =

                OperationContext.Current.GetCallbackChannel<IComputeCallback>();
                if (((ICommunicationObject)callbackChannel).State ==
               CommunicationState.Opened)
                    callbackChannel.OnComputeResult(cr);
            }
        }

        #endregion

        #region IStocks Members
        public bool SubscribeToStockPrice(string stocksym, double triggerPrice)
        {
            try
            {
                IStockCallback callbackChannel = OperationContext.Current.GetCallbackChannel<IStockCallback>();
                if (SubsriberList.Contains(callbackChannel) == false)
                    SubsriberList.Add(callbackChannel);
                List<StockInfo> userStocks = null;

                if (siDict.ContainsKey(callbackChannel))
                {
                    userStocks = siDict[callbackChannel];
                }
                else
                {
                    userStocks = new List<StockInfo>();
                    siDict.Add(callbackChannel, userStocks);
                }
                bool containsEntry = false;
                foreach (StockInfo stock in userStocks)
                {
                    if (stock.Symbol == stocksym)
                    {
                        stock.Price = triggerPrice;
                        containsEntry = true;
                    }
                }
                if (!containsEntry)
                {
                    StockInfo si = new StockInfo
                    {
                        Symbol = stocksym,
                        TriggerPrice = triggerPrice,
                        Price = 0,
                        STime = DateTime.Now
                    };
                    userStocks.Add(si);
                }
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message, new FaultCode("Subscription Error"));
            }
            return true;
        }

        public bool UnsubscribeToStockPrice(string stocksym)
        {
            try
            {
                IStockCallback callbackChannel = OperationContext.Current.GetCallbackChannel<IStockCallback>();
                if (SubsriberList.Contains(callbackChannel) == true)
                {
                    foreach (StockInfo stock in siDict[callbackChannel])
                    {
                        if (stock.Symbol == stocksym)
                        {
                            siDict[callbackChannel].Remove(stock);
                        }
                    }
                    if (siDict[callbackChannel].Count == 0)
                    {
                        siDict.Remove(callbackChannel);
                        SubsriberList.Remove(callbackChannel);
                    }
                    //siList.RemoveAt(SubsriberList.IndexOf(callbackChannel));
                }
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message, new FaultCode("Unsubscription Error"));
            }
            return true;
        }
        #endregion

        #region IPriceChange Members
        public bool ChangeStockPrice(string symbol, double newprice)
        {
            try
            {
                //if((symbol == "IBM") && (newprice > 120))
                //{
                //    // trigger call to teh subsribers
                //    foreach(IStockCallback icbChannel in SubsriberList)
                //    {
                //        StockInfo si = new StockInfo();
                //        si.Price = newprice;
                //        si.Symbol = symbol;
                //        si.STime = DateTime.Now;
                //        if (((ICommunicationObject)icbChannel).State == CommunicationState.Opened)
                //            icbChannel.OnPriceChange(si);
                //    }
                //}
                foreach(IStockCallback icbChannel in SubsriberList)
                {
                    List<StockInfo> userStocks = siDict[icbChannel];
                    foreach (StockInfo stock in userStocks)
                    {
                        if (stock.Symbol == symbol)
                        {
                            stock.Price = newprice;
                            stock.STime = DateTime.Now;
                            if (stock.Price > stock.TriggerPrice)
                                if (((ICommunicationObject)icbChannel).State == CommunicationState.Opened)
                                    icbChannel.OnPriceChange(stock);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message, new FaultCode("Change Price Error"));
            }
            return true;
        }
        #endregion
    }
}
