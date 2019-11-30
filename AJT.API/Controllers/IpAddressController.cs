﻿using AJT.API.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AJT.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [AllowAnonymous]
    public class IpAddressController : ControllerBase
    {
        private readonly IIpService _ipService;

        public IpAddressController(IIpService ipService)
        {
            _ipService = ipService;
        }

        [HttpGet]
        public IActionResult WhatsMyIp()
        {
            return new OkObjectResult(_ipService.GetRemoteIp());
        }

        [HttpGet]
        public IActionResult GetIpAddressDetails()
        {
            var ipAddress = _ipService.GetRemoteIp();
            var ipAddressDetails = _ipService.GetIpAddressDetails(ipAddress);

            return new OkObjectResult(ipAddressDetails);
        }
    }
}