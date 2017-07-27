using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CSharpSamples.IOC.Abstract_Factory
{
    public class ControllerActivator
    {
        public virtual Controller ActivateController(Request request) { return null; }
    }
}
