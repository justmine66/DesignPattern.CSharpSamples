using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CSharpSamples.Factory_Pattern.Abstract_Factory.Abstracts
{
    /// <summary>
    /// 抽象工厂接口
    /// </summary>
    public interface IAbstractFactory
    {
        Mobile ProductMobile();
        MP3 ProductMP3();
    }
}
