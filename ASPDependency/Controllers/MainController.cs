using Microsoft.AspNetCore.Mvc;
using ASPDependency.Services;

namespace ASPDependency.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MainController : ControllerBase
    {

        private readonly ITransientService _transientService;
        private readonly ITransientService _transientService2;
        private readonly IScopedService _scopedService;
        private readonly IScopedService _scopedService2;
        private readonly ISingletonService _singletonService;
        private readonly ISingletonService _singletonService2;

        public MainController(ITransientService transientService, ITransientService transientService2,
            IScopedService scopedService, IScopedService scopedService2,
            ISingletonService singletonService, ISingletonService singletonService2)
        {
            _transientService = transientService;
            _transientService2 = transientService2;
            _scopedService = scopedService;
            _scopedService2 = scopedService2;
            _singletonService = singletonService;
            _singletonService2 = singletonService2;
        }

        [HttpGet(Name = "GetServiceStates")]
        public Dictionary<string, string> GetState()
        {
            string transientGUID = _transientService.guid;
            string transient_two_GUID = _transientService.guid;
            string scopedGUID = _scopedService.guid;
            string singletonGUID = _singletonService.guid;


            return new Dictionary<string, string>
            {
                { "transient1", _transientService.guid },
                { "transient2", _transientService2.guid },
                { "scoped1", _scopedService.guid},
                { "scoped2", _scopedService2.guid},
                { "singleton1", _singletonService.guid},
                { "singleton2", _singletonService2.guid},
            };

        }
    }
}