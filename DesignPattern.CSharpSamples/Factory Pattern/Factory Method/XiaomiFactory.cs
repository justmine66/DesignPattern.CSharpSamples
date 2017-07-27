using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CSharpSamples.Factory_Pattern.Factory_Method
{
    /// <summary>
    /// 具体工厂 - 小米手机生产工厂
    /// </summary>
    public class XiaomiFactory : IMobileFactory
    {
        public Mobile product()
        {
            Console.WriteLine("生产小米手机.");
            return new XiaomiMobile();
        }
    }
}
