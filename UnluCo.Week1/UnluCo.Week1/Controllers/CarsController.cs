using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnluCo.Week1.Models;

namespace UnluCo.Week1.Controllers
{
    [Route("api/cars")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private static List<Cars> CarsList = new List<Cars>()
        {
            new Cars
            {
                Id = 1,
                Brand = "Ford",
                Model = "Focus",
                Km = 45000,
                Year = 2018,
                Price = 300000
            },
            new Cars
            {
                Id = 2,
                Brand = "Toyota",
                Model = "Corolla",
                Km = 120000,
                Year = 2015,
                Price = 220000
            },
            new Cars
            {
                Id = 3,
                Brand = "Volvo",
                Model = "V40",
                Km = 80000,
                Year = 2018,
                Price = 450000
            },
            new Cars
            {
                Id = 4,
                Brand = "Volkswagen",
                Model = "Passat",
                Km = 123000,
                Year = 2020,
                Price = 750000
            },
            new Cars
            {
                Id = 5,
                Brand = "Volkswagen",
                Model = "GolfR",
                Km = 83000,
                Year = 2019,
                Price = 900000
            }
        };
    }
}
