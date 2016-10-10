using Microsoft.AspNetCore.Mvc;
using OdeToFood_AspCore.Services;

namespace OdeToFood_AspCore.Components
{
    public class GreetingViewComponent : ViewComponent
    {
        private IGreeter _greeter;

        public GreetingViewComponent(IGreeter greeter)
        {
            _greeter = greeter;
        }
        public IViewComponentResult Invoke()
        {
            var model = _greeter.GetGreeting();
            return View("Default",model);
        }
    }
}
