using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CSharpSamples.IOC.Template_Method
{
    public class FoobarMvcEngine : MvcEngine
    {
        //定制目标Controller的激活模板方法
        protected override Controller OnActivateController(Request request)
        {
            return base.OnActivateController(request);
        }
    }
}
