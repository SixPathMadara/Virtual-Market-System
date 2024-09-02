namespace VIS_API.Model
{
    public class MarketIndicator
    {
        public int IndicatorID { get; set; }
        public string IndicatorName { get; set; }
    }

    public class IndicatorAnalysis
    {
        public int IndicatorID { get; private set; }
        public double IndicatorCurrentPrice { get; set; }
        public double IndicatorStartPrice { get; set; }
        public byte[] IndicatorImage { get; set; }
        public double IndicatorEndPrice { get; set; }
        public string IndicatorDirection { get; set; }
        public string IndicatorDescription { get; set; }

    }

}
