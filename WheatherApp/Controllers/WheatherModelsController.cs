using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Wheather.Data;
using Wheather.Models;
using Wheather.ServiceContract;

namespace WheatherApp.Controllers
{


    public class WheatherModelsController : Controller
    {
        public readonly IWheatherContract _context;
        public WheatherModelsController(IWheatherContract context)
        {
            _context = context;
        }

        [Route("/")]
        public async Task<IActionResult> Index()
        {
            var data = await _context.GetAllAsync();


            return View(data);
        }

    }
}
