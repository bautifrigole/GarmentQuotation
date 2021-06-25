using GarmentQuotation.Model;

namespace GarmentQuotation.Controller.PriceStrategies
{
    public class PriceUpdate : IPriceUpdate
    {
        private Garment _garment;

        public Garment Garment => _garment;

        public PriceUpdate(Garment garment)
        {
            _garment = garment;
        }
        
        public virtual float Execute()
        {
            return _garment.Price;
        }
    }
}