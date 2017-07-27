using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CSharpSamples.IOC.Factory_Method
{
    public class SingletonControllerActivator : ControllerActivator
    {
        public override Controller ActivateController(Request request)
        {
            return base.ActivateController(request);
        }
    }
}
