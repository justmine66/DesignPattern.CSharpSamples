using DesignPattern.CSharpSamples.Factory_Pattern.Abstract_Factory.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CSharpSamples.Factory_Pattern.Abstract_Factory
{
    /// <summary>
    /// 单元测试类
    /// </summary>
    public class UnitTest
    {
        public static void Test()
        {
            IAbstractFactory factory = null;

            factory = new XiaomiFactory();
            factory.ProductMobile();
            factory.ProductMP3();

            factory = new HuaweiFactory();
            factory.ProductMobile();
            factory.ProductMP3();
        }
    }
}
