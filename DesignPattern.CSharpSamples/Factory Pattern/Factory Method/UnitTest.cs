using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CSharpSamples.Factory_Pattern.Factory_Method
{
    /// <summary>
    /// 单元测试类
    /// </summary>
    public class UnitTest
    {
        public static void Test()
        {
            IMobileFactory factory = null;

            factory = new XiaomiFactory();
            factory.product();

            factory = new HuaweiFactory();
            factory.product();
        }
    }
}
