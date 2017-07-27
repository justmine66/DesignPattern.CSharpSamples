using DesignPattern.CSharpSamples.Factory_Pattern.Abstract_Factory.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CSharpSamples.Factory_Pattern.Abstract_Factory
{
    /// <summary>
    /// 小米工厂类
    /// </summary>
    public class XiaomiFactory : IAbstractFactory
    {
        public Mobile ProductMobile()
        {
            Console.WriteLine("生产小米手机.");
            return new XiaomiMobile();
        }

        public MP3 ProductMP3()
        {
            Console.WriteLine("生产小米MP3.");
            return new XiaomiMP3();
        }
    }
}
