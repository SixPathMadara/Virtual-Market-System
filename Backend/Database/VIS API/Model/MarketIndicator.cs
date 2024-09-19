using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VIS_API.Model
{
    public class MarketIndicator
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IndicatorID { get; set; } // Primary Key
        public string IndicatorName { get; set; }
    }

   /* public class IndicatorAnalysis
    {
        public int ID { get; private set; } // Primary Key
        public double IndicatorCurrentPrice { get; set; }
        public double IndicatorStartPrice { get; set; }
        public byte[] IndicatorImage { get; set; }
        public double IndicatorEndPrice { get; set; }
        public string IndicatorDirection { get; set; }
        public string IndicatorDescription { get; set; }

    }*/

}
