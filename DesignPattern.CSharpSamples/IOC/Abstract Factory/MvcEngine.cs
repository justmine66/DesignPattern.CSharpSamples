using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CSharpSamples.IOC.Abstract_Factory
{
    public class MvcEngine
    {
        public EngineFactory Factory { get; private set; }
        public MvcEngine(EngineFactory factory = null)
        {
            this.Factory = factory ?? new EngineFactory();
        }

        public void Start(Uri address)
        {
            while (true)
            {
                Request request = this.Factory.GetListener().Listen(address);
                Task.Run(() =>
                {
                    Controller controller = this.Factory.GetControllerActivator().ActivateController(request);
                    View view = this.Factory.GetControllerExecutor().ExecuteController(controller);
                    this.Factory.GetViewRenderer().RenderView(view);
                });
            }
        }
    }
}
