using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CSharpSamples.IOC.Abstract_Factory
{
    public class UnitTest
    {
        public static void Test()
        {
            Uri address = new Uri("http://localhost/mvcapp");
            MvcEngine engine = new MvcEngine(new FoobarEngineFactory());
            engine.Start(address);
        }
    }

    public class FoobarEngineFactory : EngineFactory
    {
        public override ControllerActivator GetControllerActivator()
        {
            return new SingletonControllerActivator();
        }
    }
}
