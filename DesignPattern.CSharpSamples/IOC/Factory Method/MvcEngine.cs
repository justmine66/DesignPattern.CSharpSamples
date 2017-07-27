using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CSharpSamples.IOC.Factory_Method
{
    public class MvcEngine
    {
        public void Start(Uri address)
        {
            while (true)
            {
                Request request = this.GetListener().Listen(address);
                Task.Run(() =>
                {
                    Controller controller = this.GetControllerActivator()
                                                .ActivateController(request);
                    View view = this.GetControllerExecutor()
                                    .ExecuteController(controller);
                    this.GetViewRenderer().RenderView(view);
                });
            }
        }
        protected virtual Listener GetListener()
        {
            return new Listener();
        }
        protected virtual ControllerActivator GetControllerActivator()
        {
            return new ControllerActivator();
        }
        protected virtual ControllerExecutor GetControllerExecutor()
        {
            return new ControllerExecutor();
        }
        protected virtual ViewRenderer GetViewRenderer()
        {
            return new ViewRenderer();
        }
    }
}
