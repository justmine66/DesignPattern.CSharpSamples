using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CSharpSamples.IOC.Abstract_Factory
{
    public class Listener
    {
        public virtual Request Listen(Uri address) { return null; }
    }
}
