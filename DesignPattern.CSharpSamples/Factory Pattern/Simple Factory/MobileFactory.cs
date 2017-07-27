using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CSharpSamples.Factory_Pattern.Simple_Factory
{
    /// <summary>
    /// 生产手机的工厂
    /// </summary>
    public class MobileFactory
    {
        /// <summary>
        /// 静态工厂方法=>根据手机类型生成手机
        /// </summary>
        /// <param name="mobiletype">手机类型</param>
        /// <returns>手机</returns>
        public static Mobile product(String mobiletype)
        {
            Mobile mobile = null;
            if ("xiaomi".Equals(mobiletype))
            {
                mobile = new XiaomiMobile();
                Console.WriteLine("生产小米手机.");
            }
            else if ("huawei".Equals(mobiletype))
            {
                mobile = new HuaweiMobile();
                Console.WriteLine("生产华为手机.");
            }
            else
            {
                Console.WriteLine("不能生产该手机类型.");
            }
            return mobile;
        }
    }
}
