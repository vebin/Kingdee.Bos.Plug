using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.Log
{
    public class NullMgLog : IMgLog
    {
        void IMgLog.Debug(string messageTemplate)
        {
        }

        void IMgLog.Debug<T>(string messageTemplate, T propertyValue)
        {
        }

        void IMgLog.Debug<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
        }

        void IMgLog.Error(string messageTemplate)
        {
        }

        void IMgLog.Error<T>(string messageTemplate, T propertyValue)
        {
        }

        void IMgLog.Error<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
        }

        void IMgLog.Fatal(string messageTemplate)
        {
        }

        void IMgLog.Fatal<T>(string messageTemplate, T propertyValue)
        {
        }

        void IMgLog.Fatal<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
        }

        void IMgLog.Information(string messageTemplate)
        {
        }

        void IMgLog.Information<T>(string messageTemplate, T propertyValue)
        {
        }

        void IMgLog.Information<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
        }

        void IMgLog.Warning(string messageTemplate)
        {
        }

        void IMgLog.Warning<T>(string messageTemplate, T propertyValue)
        {
        }

        void IMgLog.Warning<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1)
        {
        }
    }
}
