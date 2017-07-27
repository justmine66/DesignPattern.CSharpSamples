using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CSharpSamples.Factory_Pattern.Factory_Method
{
    /// <summary>
    /// 一个抽象工厂接口
    /// </summary>
    public interface IMobileFactory
    {
        Mobile product();
    }
}
