using GarmentQuotation.Model;

namespace GarmentQuotation.Controller.PriceStrategies
{
    public class TightPant : PriceUpdate
    {
        private Garment _garment;
        
        public TightPant(Garment garment) : base(garment)
        {
            _garment = garment;
        }
        
        public override float Execute()
        {
            var totalPrice = 88 * _garment.Price / 100;
            return -totalPrice;
        }
    }
}