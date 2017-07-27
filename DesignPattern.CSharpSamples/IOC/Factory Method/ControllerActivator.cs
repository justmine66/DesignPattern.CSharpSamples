using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CSharpSamples.IOC.Factory_Method
{
    public class ControllerActivator
    {
        public virtual Controller ActivateController(Request request) { return null; }
    }
}
