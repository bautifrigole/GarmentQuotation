using System.Collections.Generic;

namespace GarmentQuotation.Model
{
    public class Seller
    {
        public string Name => _name;
        public string Surname => _surname;
        public int VendorCode => _vendorCode;
        public List<Quotation> QuotationsHistory { get; }

        private string _name;
        private string _surname;
        private int _vendorCode;

        public Seller(string name, string surname, int vendorCode)
        {
            _name = name;
            _surname = surname;
            _vendorCode = vendorCode;
            QuotationsHistory = new List<Quotation>();
        }

        public void AddQuotationToHistory(Quotation quotation)
        {
            QuotationsHistory.Add(quotation);
        }
    }
}