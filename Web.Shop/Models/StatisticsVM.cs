using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Shop.Models
{
    public class StatisticsVM
    {
        public string Title { get; set; }
        public List<DataChartVM> ListData { get; set; }
    }
    public class DataChartVM
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public string Label { get; set; }
    }
}
