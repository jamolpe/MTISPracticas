using Apache.NMS;
using System;
using System.Threading;

namespace Invernadero
{
    public class AsyncMessageHelper : IDisposable
    { 
    public IMessage Message { get; set; }
    public AutoResetEvent Trigger { get; private set; }

    public AsyncMessageHelper()
    {
        this.Trigger = new AutoResetEvent(false);
    }

    #region IDisposable Members

    public void Dispose()
    {
        this.Trigger.Dispose();
        this.Message = null;
    }

    #endregion
}
}