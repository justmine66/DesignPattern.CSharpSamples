using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CSharpSamples.Factory_Pattern1.Template_Method
{
    using DesignPattern.CSharpSamples.Factory_Pattern1.Entities;
    public class Factory
    {
        public virtual Mobile ProductMobile() { return new Mobile(); }
        public virtual MP3 ProductMP3() { return new MP3(); }
    }
}
