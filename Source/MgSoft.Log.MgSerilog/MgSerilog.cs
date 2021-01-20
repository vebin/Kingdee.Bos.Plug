using System;

namespace MgSoft.Log.MgSerilog
{
    public class MgSerilog : IMgSerilog
    {
        protected Serilog.ILogger log;
        public MgSerilog(Serilog.ILogger logger)
        {
            this.log = logger;
        }

        void ILog.Debug(string messageTemplate)
        {
            log.Debug(messageTemplate);
        }

        void ILog.Debug<T>(string messageTemplate, T propertyValue)
        {
            log.Debug(messageTemplate, propertyValue);
        }

        void ILog.Debug<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            log.Debug(messageTemplate, propertyValue0, propertyValue1);
        }

        void ILog.Error(string messageTemplate)
        {
            log.Error(messageTemplate);
        }

        void ILog.Error<T>(string messageTemplate, T propertyValue)
        {
            log.Error(messageTemplate, propertyValue);
        }

        void ILog.Error<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            log.Error(messageTemplate, propertyValue0, propertyValue1);
        }

        void ILog.Fatal(string messageTemplate)
        {
            log.Fatal(messageTemplate);
        }

        void ILog.Fatal<T>(string messageTemplate, T propertyValue)
        {
            log.Fatal(messageTemplate, propertyValue);
        }

        void ILog.Fatal<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            log.Fatal(messageTemplate, propertyValue0, propertyValue1);
        }

        void ILog.Information(string messageTemplate)
        {
            log.Information(messageTemplate);
        }

        void ILog.Information<T>(string messageTemplate, T propertyValue)
        {
            log.Information(messageTemplate, propertyValue);
        }

        void ILog.Information<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            log.Information(messageTemplate, propertyValue0, propertyValue1);
        }

        void ILog.Warning(string messageTemplate)
        {
            log.Warning(messageTemplate);
        }

        void ILog.Warning<T>(string messageTemplate, T propertyValue)
        {
            log.Warning(messageTemplate, propertyValue);
        }

        void ILog.Warning<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            log.Warning(messageTemplate, propertyValue0, propertyValue1);
        }
    }
}
