using GarmentQuotation.Model;

namespace GarmentQuotation.Controller.PriceStrategies
{
    public class PremiumQuality : PriceUpdate
    {
        private Garment _garment;
        
        public PremiumQuality(Garment garment) : base(garment)
        {
            _garment = garment;
        }
        
        public override float Execute()
        {
            var totalPrice = 130 * _garment.Price / 100;
            return totalPrice;
        }
    }
}