using System.Collections.Generic;

namespace GarmentQuotation.Model
{
    public class ClothingStore
    {
        public string Name => _name;
        public string Address => _address;
        public List<Garment> Garments => _garments;
        
        private string _name;
        private string _address;
        private List<Garment> _garments = new List<Garment>();

        public ClothingStore(string name, string address)
        {
            _name = name;
            _address = address;
        }

        public void AddGarment(Garment garment)
        {
            _garments.Add(garment);
        }
    }
}