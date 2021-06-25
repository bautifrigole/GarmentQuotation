namespace GarmentQuotation.Model
{
    public class Pant : Garment
    {
        public bool IsTight => _isTight;
        public new string ClothName => _name;

        private bool _isTight;
        private string _name;

        public Pant(bool isPremium, float price, int unitsInStock, bool isTight, string name) : base(isPremium, price, unitsInStock, name)
        {
            _isTight = isTight;
            _name = name;
            
        }
    }
}