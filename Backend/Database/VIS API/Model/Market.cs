﻿namespace VIS_API.Model
{
    public class Market
    {
        public int MarketID {get;set;}
        public string MarketName {get;set;}
        public double CurrentPrice { get;set; }

    }

    public class MarketAnalysis
    {
        public int MarketID { get; private set; }
        public int IndicatorID { get; set; }
        public double MarketStartPrice { get; }
        public double MarketEndPrice { get; }  
        public string MarketDirection { get; set; }
        public string MarketDescription { get; set; } 
        public byte[] MarketStartImage { get; set;}

        public byte[] MarketEndImage { get; set; }

    }

}
