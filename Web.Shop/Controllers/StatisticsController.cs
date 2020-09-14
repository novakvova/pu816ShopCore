using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Shop.Models;

namespace Web.Shop.Controllers
{
    public class StatisticsController : Controller
    {
        public IActionResult Index()
        {
            StatisticsVM model = new StatisticsVM();
            model.Title = "Наша Бригада";
            model.ListData = new List<DataChartVM>
            {
                new DataChartVM
                {
                    Id = 1,
                    Value= "100",
                    Label = "20 серпня 2019р."
                },
                new DataChartVM
                {
                    Id = 2,
                    Value= "300",
                    Label = "21 серпня 2019р."
                },
                new DataChartVM
                {
                    Id = 3,
                    Value= "200",
                    Label = "22 серпня 2019р."
                },
                new DataChartVM
                {
                    Id = 3,
                    Value= "250",
                    Label = "23 серпня 2019р."
                },
                new DataChartVM
                {
                    Id = 4,
                    Value= "50",
                    Label = "24 серпня 2019р."
                },
                new DataChartVM
                {
                    Id = 4,
                    Value= "-20",
                    Label = "25 серпня 2019р."
                },
                new DataChartVM
                {
                    Id = 4,
                    Value= "400",
                    Label = "26 серпня 2019р."
                },
            };
            return View(model);
        }
    }
}
