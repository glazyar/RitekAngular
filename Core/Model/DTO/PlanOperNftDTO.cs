using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model.DTO
{
    public class PlanOperNftDTO
    {
        public int kodTPP { get; set; }
        public int RangeNumber { get; set; }
        public int ObjectKod { get; set; }
        public string ObjectType { get; set; }
        public string Title { get; set; }
        public double? PlanMonth { get; set; }
        public double? GraphicMonth { get; set; }
        public string EditStyle
        {
            get
            {
                if (Title.Contains("ЦДНГ") || Title.Contains("ИТОГО"))
                    return "2";
                else return "1";
            }
        }
    }
}
