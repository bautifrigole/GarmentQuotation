using System;

namespace GarmentQuotation.Model
{
    public class Quotation
    {
        public int IdentificationNumber => _identificationNumber;
        public DateTime QuoteDate => _quoteDate;
        public int VendorCode => _vendorCode;
        public Garment QuotedGarment => _quotedGarment;
        public int QuotedUnits => _quotedUnits;
        public float TotalQuote => _totalQuote;

        private int _identificationNumber;
        private DateTime _quoteDate;
        private int _vendorCode;
        private Garment _quotedGarment;
        private int _quotedUnits;
        private float _totalQuote;

        public Quotation(int identificationNumber, DateTime date, Seller seller)
        {
            _identificationNumber = identificationNumber;
            _quoteDate = date;
            _vendorCode = seller.VendorCode;
            seller.AddQuotationToHistory(this);
        }

        public void SetQuotedAndQuantityGarment(Garment garment, int units)
        {
            _quotedGarment = garment;
            _quotedUnits = units;
        }

        public void SetTotalQuote(float total)
        {
            _totalQuote = total;
        }
    }
}