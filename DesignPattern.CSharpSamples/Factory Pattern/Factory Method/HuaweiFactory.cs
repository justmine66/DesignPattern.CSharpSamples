using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CSharpSamples.Factory_Pattern.Factory_Method
{
    /// <summary>
    /// 具体工厂 - 华为手机生产工厂
    /// </summary>
    public class HuaweiFactory : IMobileFactory
    {
        public Mobile product()
        {
            Console.WriteLine("生产华为手机.");
            return new HuaweiMobile();
        }
    }
}
