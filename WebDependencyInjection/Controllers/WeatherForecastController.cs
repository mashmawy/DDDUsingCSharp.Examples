using Microsoft.AspNetCore.Mvc;

namespace WebDependencyInjection.Controllers
{
    [ApiController] 
    public class WeatherForecastController : ControllerBase
    {
        private readonly ISingletonService singletonService;
        private readonly ISingletonService singletonService2;
        private readonly ITransientService transientService;
        private readonly ITransientService transientService2;
        private readonly IScopedService scopedService;
        private readonly IScopedService scopedService2;

        public WeatherForecastController(ISingletonService singletonService, ISingletonService singletonService2,
            ITransientService transientService, ITransientService transientService2,
            IScopedService scopedService, IScopedService scopedService2)
        {
            this.singletonService = singletonService;
            this.singletonService2 = singletonService2;
            this.transientService = transientService;
            this.scopedService = scopedService;
            this.scopedService2 = scopedService2;
            this.transientService2 = transientService2;
        }



        [HttpGet()]
        [Route("get_result")]
        public Result Get()
        {
            return new Result()
            {
                ScopedValue = scopedService.GetValue(),
                ScopedValue2 = scopedService2.GetValue(),
                SingletonValue = singletonService.GetValue(),
                SingletonValue2 = singletonService2.GetValue(),
                TransientValue = transientService.GetValue(),
                Transient2Value = transientService2.GetValue()

            };
        }
    }
}