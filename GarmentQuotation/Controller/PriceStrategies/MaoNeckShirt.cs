using GarmentQuotation.Model;

namespace GarmentQuotation.Controller.PriceStrategies
{
    public class MaoNeckShirt : PriceUpdate
    {
        private Garment _garment;
        
        public MaoNeckShirt(Garment garment) : base(garment)
        {
            _garment = garment;
        }
        
        public override float Execute()
        {
            var totalPrice = 103 * _garment.Price / 100;
            return totalPrice;
        }
    }
}