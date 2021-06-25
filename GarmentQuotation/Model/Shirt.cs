namespace GarmentQuotation.Model
{
    public class Shirt : Garment
    {
        public bool HasShortSleeve => _hasShortSleeve;
        public bool HasMaoNeck => _hasMaoNeck;
        public new string ClothName => _name;
        
        private bool _hasShortSleeve;
        private bool _hasMaoNeck;
        private string _name;

        public Shirt(bool isPremium, float price, int unitsInStock, bool hasMaoNeck, bool hasShortSleeve, string name) : base(isPremium, price, unitsInStock, name)
        {
            _hasMaoNeck = hasMaoNeck;
            _hasShortSleeve = hasShortSleeve;
            _name = name;
        }
    }
}