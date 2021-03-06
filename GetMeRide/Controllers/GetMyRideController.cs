﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GetMeRide.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GetMeRide.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetMyRideController : ControllerBase
    {
        private readonly IGetMeRideService _getMeRideService;

        public GetMyRideController(IGetMeRideService getMeRideService)
        {

            _getMeRideService = getMeRideService;
            
        }
        public IActionResult GetAllCabDetails()
        {
            var busesFromRepo = _getMeRideService.GetAllCabsDetails();
            return Ok(busesFromRepo);
        }

        [HttpGet("{cabId}/Location")]
        public IActionResult GetBusLocation(int cabId)
        {
            var busLocation = _getMeRideService.GetBusLocation(cabId);
            return Ok(busLocation);
        }

        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public async Task<IActionResult> DrverDetails([FromQuery] int cabId)
        {
            var driverDetails = wait _getMeRideService.GetDriverDetails(cabId);
            return Ok(driverDetails);
        }

    }
}
