using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhilipicaltWebAPI.Controllers
{
    public class ApiController<T> : ControllerBase
    {
        public readonly ILogger<T> logger;

        public ApiController(ILogger<T> logger)
        {
            this.logger = logger;
        }
    }
}
