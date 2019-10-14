using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrigeratorAppPractice3.Model
{
    public class Refrigerator
    {
        public double MaximumWeight { set; get; }
        public int NumberOfItem { set; get; }
        public double UnitWeight { set; get; }

        public double CurrentWeight()
        {
            return NumberOfItem * UnitWeight;
        }
        public double RemainingWeight()
        {
            return MaximumWeight - Convert.ToDouble(CurrentWeight());
        }
    }
}
