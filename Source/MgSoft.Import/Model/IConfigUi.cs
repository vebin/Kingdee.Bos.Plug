using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.Import.Model
{
    public interface IConfigUi
    {
        ConfigUiType ConfigUiType { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="successCallTack">object autoface为ILifetimeScope</param>
        /// <param name="failCallBack">object autoface参数为ILifetimeScope</param>
        void CustomerConfigUi(object lifetimeScope, Action successCallTack,Action failCallBack);
    }
}
