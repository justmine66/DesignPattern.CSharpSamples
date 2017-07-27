using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CSharpSamples.IOC.Factory_Method
{
    public class Listener
    {
        public virtual Request Listen(Uri address) { return null; }
    }
}
