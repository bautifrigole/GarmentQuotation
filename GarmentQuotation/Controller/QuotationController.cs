using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GarmentQuotation.Controller.PriceStrategies;
using GarmentQuotation.Model;

namespace GarmentQuotation.Controller
{
    public class QuotationController
    {
        public Seller Seller { get; private set; }

        public Quotation Quotation { get; private set; }

        public ClothingStore ClothingStore { get; private set; }

        private float _totalPrice;
        
        private List<PriceUpdate> _priceUpdateStrategies;

        public QuotationController()
        {
            _priceUpdateStrategies = new List<PriceUpdate>();
        }

        public void SetStore(ClothingStore store)
        {
            ClothingStore = store;
        }
        
        public void SetSeller(Seller seller)
        {
            Seller = seller;
        }
        
        public void SetQuotation(Quotation quotation)
        {
            Quotation = quotation;
        }
        
        public void AddPriceUpdateToList(PriceUpdate priceUpdate)
        {
            _priceUpdateStrategies.Add(priceUpdate);
            
            if (priceUpdate.Garment.IsPremium) _priceUpdateStrategies.Add(new PremiumQuality(priceUpdate.Garment));
        }

        public float CalculateTotal()
        {
            _totalPrice = Quotation.QuotedGarment.Price * Quotation.QuotedUnits;

            foreach (var priceUpdate in _priceUpdateStrategies)
            {
                _totalPrice += priceUpdate.Execute();
            }
            
            Quotation.SetTotalQuote(_totalPrice);
            return _totalPrice;
        }

        public bool IsCurrentSeller(Seller seller)
        {
            if (Seller == null) return false;

            return seller.Name == Seller.Name && seller.Surname == Seller.Surname && seller.VendorCode == Seller.VendorCode;
        }
        
        public bool IsCurrentStore(ClothingStore store)
        {
            if (ClothingStore == null) return false;

            return store.Name == ClothingStore.Name && store.Address == ClothingStore.Address;
        }
    }
}