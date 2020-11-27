﻿using ContentProvider.DTO;
using ContentProvider.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContentProvider.Controllers
{
    [Route("api/routes")]
    [ApiController]
    public class RoutesController : ControllerBase
    {

        private readonly ILogger<RoutesController> logger;
        private readonly IRoutesService routesService;

        public RoutesController(ILogger<RoutesController> logger, IRoutesService routesService) {
            this.logger = logger;
            this.routesService = routesService;
        }

        [HttpGet]
        public IEnumerable<MicroService> Get()
        {
            return routesService.GetRandomServiceRoutes();
        }

    }


}