using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft
{
    public interface IMgLog
    { 
        void Debug(string messageTemplate);
        void Debug<T>(string messageTemplate, T propertyValue);
        void Debug<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1);
        void Error(string messageTemplate);
        void Error<T>(string messageTemplate, T propertyValue);
        void Error<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1);
        void Fatal(string messageTemplate);
        void Fatal<T>(string messageTemplate, T propertyValue);
        void Fatal<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1);
        void Information(string messageTemplate);
        void Information<T>(string messageTemplate, T propertyValue);
        void Information<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1);
        void Warning(string messageTemplate);
        void Warning<T>(string messageTemplate, T propertyValue);
        void Warning<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1);
    }
}

