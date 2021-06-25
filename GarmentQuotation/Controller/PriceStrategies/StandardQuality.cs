using GarmentQuotation.Model;

namespace GarmentQuotation.Controller.PriceStrategies
{
    public class StandardQuality : PriceUpdate
    {
        private Garment _garment;
        
        public StandardQuality(Garment garment) : base(garment)
        {
            _garment = garment;
        }
        
        public override float Execute()
        {
            return _garment.Price;
        }
    }
}