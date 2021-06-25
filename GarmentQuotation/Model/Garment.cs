namespace GarmentQuotation.Model
{
    public class Garment
    {
        public bool IsPremium => _isPremium;
        public float Price => _price;
        public string ClothName => _name;
        public int UnitsInStock => _unitsInStock;
        
        private bool _isPremium;
        private float _price;
        private int _unitsInStock;
        private string _name;

        public Garment(bool isPremium, float price, int unitsInStock, string name)
        {
            _isPremium = isPremium;
            _price = price;
            _unitsInStock = unitsInStock;
            _name = name;
        }
    }
}