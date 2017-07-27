using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CSharpSamples.IOC.Abstract_Factory
{
    public class EngineFactory
    {
        public virtual Listener GetListener()
        {
            return new Listener();
        }

        public virtual ControllerActivator GetControllerActivator()
        {
            return new ControllerActivator();
        }

        public virtual ControllerExecutor GetControllerExecutor()
        {
            return new ControllerExecutor();
        }

        public virtual ViewRenderer GetViewRenderer()
        {
            return new ViewRenderer();
        }
    }
}
