namespace VIS_API.Model
{
    public class Market
    {
        public int MarketID {get;set;} //Primary Key
        public string MarketName {get;set;}
        public double CurrentPrice { get;set; }

    }

    public class MarketAnalysis
    {
        public int MarketID { get; private set; } //Primary Key
        public int IndicatorID { get; set; } // Foreign Key
        public double MarketStartPrice { get; }
        public double MarketEndPrice { get; }  
        public string MarketDirection { get; set; }
        public string MarketDescription { get; set; } 
        public byte[] MarketStartImage { get; set;}

        public byte[] MarketEndImage { get; set; }

    }

}
