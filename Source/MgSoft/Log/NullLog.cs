using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.Log
{
    public class NullLog : ILog
    {
        void ILog.Debug(string messageTemplate)
        {
        }

        void ILog.Debug<T>(string messageTemplate, T propertyValue)
        {
        }

        void ILog.Debug<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
        }

        void ILog.Error(string messageTemplate)
        {
        }

        void ILog.Error<T>(string messageTemplate, T propertyValue)
        {
        }

        void ILog.Error<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
        }

        void ILog.Fatal(string messageTemplate)
        {
        }

        void ILog.Fatal<T>(string messageTemplate, T propertyValue)
        {
        }

        void ILog.Fatal<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
        }

        void ILog.Information(string messageTemplate)
        {
        }

        void ILog.Information<T>(string messageTemplate, T propertyValue)
        {
        }

        void ILog.Information<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
        }

        void ILog.Warning(string messageTemplate)
        {
        }

        void ILog.Warning<T>(string messageTemplate, T propertyValue)
        {
        }

        void ILog.Warning<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
        }
    }
}
