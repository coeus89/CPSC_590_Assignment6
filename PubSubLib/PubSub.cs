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
    public class PubSub : ILongCompute
    {
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
    }
}
