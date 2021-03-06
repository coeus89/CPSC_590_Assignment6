using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CBClient;

namespace CBClient
{
    class CBClient : PS.ILongComputeCallback, IDisposable
    {
        PS.LongComputeClient proxy = null;
        public void Dispose()
        {
            proxy.Close();
        }

        public void CallLongCompute(int x, int y, string clientID)
        {
            proxy = new PS.LongComputeClient(new System.ServiceModel.InstanceContext(this), "PSEP");
            proxy.Compute(x, y, clientID);
        }

        #region ILongComputeCallback Members
        public void OnComputeResult(PS.ComputeResult res)
        {
            try
            {
                MessageBox.Show(res.Result.ToString() + "\n" + res.ClientID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
