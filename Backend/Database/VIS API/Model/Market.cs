using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VIS_API.Model
{
    public class Market
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MarketID {get;set;} //Primary Key
        public string MarketName {get;set;}
        public double CurrentPrice { get;set; }

    }

   /* public class MarketAnalysis
    {
        public int AnalysisID { get; private set; } //Primary Key
        public int IndicatorID { get; set; } // Foreign Key
        public double MarketStartPrice { get; }
        public double MarketEndPrice { get; }  
        public string MarketDirection { get; set; }
        public string MarketDescription { get; set; } 
        public byte[] MarketStartImage { get; set;}

        public byte[] MarketEndImage { get; set; }

    }*/

}
