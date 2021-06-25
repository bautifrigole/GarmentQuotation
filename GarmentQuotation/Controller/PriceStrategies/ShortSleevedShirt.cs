using GarmentQuotation.Model;

namespace GarmentQuotation.Controller.PriceStrategies
{
    public class ShortSleevedShirt : PriceUpdate
    {
        private Garment _garment;
        
        public ShortSleevedShirt(Garment garment) : base(garment)
        {
            _garment = garment;
        }
        
        public override float Execute()
        {
            var totalPrice = 90 * _garment.Price / 100;
            return -totalPrice;
        }
    }
}