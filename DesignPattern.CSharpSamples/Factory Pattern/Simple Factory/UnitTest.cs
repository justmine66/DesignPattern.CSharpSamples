using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CSharpSamples.Factory_Pattern.Simple_Factory
{
    /// <summary>
    /// 单元测试类
    /// </summary>
    public class UnitTest
    {
        public static void Test()
        {
            //生产小米手机
            MobileFactory.product("xiaomi");
            //生产华为手机
            MobileFactory.product("huawei");
            //生产锤子手机
            MobileFactory.product("chuizi");
        }
    }
}
