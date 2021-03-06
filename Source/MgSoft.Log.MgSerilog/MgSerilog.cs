﻿using System;

namespace MgSoft.Log.MgSerilog
{
    public class MgSerilog : IMgSerilog
    {
        protected Serilog.ILogger log;
        public MgSerilog(Serilog.ILogger logger)
        {
            this.log = logger;
        }

        void IMgLog.Debug(string messageTemplate)
        {
            log.Debug(messageTemplate);
        }

        void IMgLog.Debug<T>(string messageTemplate, T propertyValue)
        {
            log.Debug(messageTemplate, propertyValue);
        }

        void IMgLog.Debug<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            log.Debug(messageTemplate, propertyValue0, propertyValue1);
        }

        void IMgLog.Error(string messageTemplate)
        {
            log.Error(messageTemplate);
        }

        void IMgLog.Error<T>(string messageTemplate, T propertyValue)
        {
            log.Error(messageTemplate, propertyValue);
        }

        void IMgLog.Error<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            log.Error(messageTemplate, propertyValue0, propertyValue1);
        }

        void IMgLog.Fatal(string messageTemplate)
        {
            log.Fatal(messageTemplate);
        }

        void IMgLog.Fatal<T>(string messageTemplate, T propertyValue)
        {
            log.Fatal(messageTemplate, propertyValue);
        }

        void IMgLog.Fatal<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            log.Fatal(messageTemplate, propertyValue0, propertyValue1);
        }

        void IMgLog.Information(string messageTemplate)
        {
            log.Information(messageTemplate);
        }

        void IMgLog.Information<T>(string messageTemplate, T propertyValue)
        {
            log.Information(messageTemplate, propertyValue);
        }

        void IMgLog.Information<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            log.Information(messageTemplate, propertyValue0, propertyValue1);
        }

        void IMgLog.Warning(string messageTemplate)
        {
            log.Warning(messageTemplate);
        }

        void IMgLog.Warning<T>(string messageTemplate, T propertyValue)
        {
            log.Warning(messageTemplate, propertyValue);
        }

        void IMgLog.Warning<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
            log.Warning(messageTemplate, propertyValue0, propertyValue1);
        }
    }
}
