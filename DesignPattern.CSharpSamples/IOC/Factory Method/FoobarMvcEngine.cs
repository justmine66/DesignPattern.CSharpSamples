using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CSharpSamples.IOC.Factory_Method
{
    //定制
    public class FoobarMvcEngine: MvcEngine
    {
        protected override ControllerActivator GetControllerActivator()
        {
            return new SingletonControllerActivator();
        }
    }
}
