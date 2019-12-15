using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic.Interfaces;
using BusinessLogic.Service_Contracts;
using BusinessLogic.Services;
using DataProviders.Data_Providers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Nextech.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HackerNewsController : Controller
    {
        private readonly IHackerNewsService _hackerNewsService;
        private readonly int _topStoryLimit;

        public HackerNewsController(IConfiguration config, IHackerNewsService hackerNewsService)
        {
            _topStoryLimit = int.Parse(config.GetSection("topStoryLimit").Value);
            _hackerNewsService = hackerNewsService;
        }

        public IActionResult Index()
        {
            try            {
                return View(_hackerNewsService.GetTopNewsStoryIdsAsync(_topStoryLimit).Result);
            }catch(Exception e)
            {
                return StatusCode(500, e);
            }
        }

    }
}