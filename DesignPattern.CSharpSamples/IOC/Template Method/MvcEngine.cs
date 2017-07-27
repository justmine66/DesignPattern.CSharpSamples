using DesignPattern.CSharpSamples.IOC.Template_Method.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CSharpSamples.IOC.Template_Method
{
    /// <summary>
    /// 驱动引擎
    /// </summary>
    public class MvcEngine
    {
        public void Start(Uri address)
        {
            while (true)
            {
                Request request = this.OnListenAndReceiveRequest(address);
                Task.Run(() =>
                {
                    Controller controller = this.OnActivateController(request);
                    View view = this.OnExecuteContrller(controller);
                    this.OnRenderView(view);
                });
            }
        }

        protected virtual Request OnListenAndReceiveRequest(Uri address) { return null; }
        protected virtual Controller OnActivateController(Request request) { return null; }
        protected virtual View OnExecuteContrller(Controller controller) { return null; }
        protected virtual void OnRenderView(View view) { }

        //结合“事件注册”使应用程序对流程的定制变得更加自由，应用程序只需要注册相应的事件来完成对请求处理流程的定制。
        public EventHandler<ControllerActivationEventArgs> ControllerActivating;
        public EventHandler<ControllerActivationEventArgs> ControllerActivated;
        public EventHandler<ControllerExecutionEventArgs> ControllerExecuting;
        public EventHandler<ControllerExecutionEventArgs> ControllerExecuted;
        public EventHandler<ViewRenderEventArgs> ViewRendering;
        public EventHandler<ViewRenderEventArgs> ViewRendered;
    }
}
