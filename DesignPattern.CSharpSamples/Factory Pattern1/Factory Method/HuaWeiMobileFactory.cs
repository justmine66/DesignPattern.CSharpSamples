using System;
using System.Collections.Generic;
using System.Text;
using DesignPattern.CSharpSamples.Factory_Pattern1.Entities;

namespace DesignPattern.CSharpSamples.Factory_Pattern1.Factory_Method
{
    /// <summary>
    /// 华为手机工厂
    /// </summary>
    public class HuaWeiMobileFactory : MobileFactory
    {
        public override Mobile Product()
        {
            return new HuaweiMobile();
        }
    }
}
