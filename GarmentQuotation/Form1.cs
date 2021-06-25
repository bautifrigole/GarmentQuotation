using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GarmentQuotation.Controller;
using GarmentQuotation.Controller.PriceStrategies;
using GarmentQuotation.Model;

namespace GarmentQuotation
{
  public partial class Form1 : Form
  {
      private int _quotationId;
      private QuotationController quotationController;
      private bool hasDoneFirstQuote;
      
      public Form1()
      {
          InitializeComponent();
          quotationController = new QuotationController();
      }

      private void buttonQuote_Click(object sender, EventArgs e)
      {
            var stringTextboxes = new List<TextBox> {textBoxStoreName, textBoxAddressStore, textBoxSellerName, textBoxSellerSurname};
            var intTextboxes = new List<TextBox> {textBoxVendorCode, textBoxAvailableStock, textBoxQuantity};
            var floatTextboxes = new List<TextBox> {textBoxPrice};

            bool areStringCorrect = FieldsValidator.AreFieldsCorrect(stringTextboxes, "string");
            bool areIntCorrect = FieldsValidator.AreFieldsCorrect(intTextboxes, "int");
            bool areFloatCorrect = FieldsValidator.AreFieldsCorrect(floatTextboxes, "float");
            
            if (!areStringCorrect || !areIntCorrect || !areFloatCorrect)
            {
                MessageBox.Show("¡Datos inválidos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            var store = new ClothingStore(textBoxStoreName.Text, textBoxAddressStore.Text);
            if (!quotationController.IsCurrentStore(store)) quotationController.SetStore(store);

            var seller = new Seller(textBoxSellerName.Text, textBoxSellerSurname.Text, Convert.ToInt32(textBoxVendorCode.Text));
            if (!quotationController.IsCurrentSeller(seller)) quotationController.SetSeller(seller);

            _quotationId += 1;
            var quotation = new Quotation(_quotationId, DateTime.Now, quotationController.Seller);
            quotationController.SetQuotation(quotation);


            if (radioButtonShirt.Checked)
            {
                var shirt = new Shirt(radioButtonPremium.Checked, Convert.ToSingle(textBoxPrice.Text),
                    Convert.ToInt32(textBoxAvailableStock.Text), checkBoxMaoNeck.Checked, checkBoxShortSleeves.Checked, "Remera");
                
                if (checkBoxMaoNeck.Checked) quotationController.AddPriceUpdateToList(new MaoNeckShirt(shirt));
                if (checkBoxShortSleeves.Checked) quotationController.AddPriceUpdateToList(new ShortSleevedShirt(shirt));
                
                quotationController.Quotation.SetQuotedAndQuantityGarment(shirt, Convert.ToInt32(textBoxQuantity.Text));
            }
            
            if (radioButtonPant.Checked)
            {
                var pant = new Pant(radioButtonPremium.Checked, Convert.ToSingle(textBoxPrice.Text),
                    Convert.ToInt32(textBoxAvailableStock.Text), checkBoxTightPant.Checked, "Pantalón");
                
                if (checkBoxShortSleeves.Checked) quotationController.AddPriceUpdateToList(new TightPant(pant));
                
                quotationController.Quotation.SetQuotedAndQuantityGarment(pant, Convert.ToInt32(textBoxQuantity.Text));
            }
            
            labelTotal.Text = Convert.ToString(quotationController.CalculateTotal());
            MessageBox.Show("¡Venta realizada con éxito! \nVendedor: "+quotationController.Seller.Surname+"\nTienda: "+quotationController.ClothingStore.Name);
            hasDoneFirstQuote = true;
      }
      
      private void UpdateRadioButtons()
      {
          radioButtonPant.Checked = !radioButtonShirt.Checked;
          radioButtonPremium.Checked = !radioButtonStandard.Checked;
      }

      private void radioButtonPant_CheckedChanged(object sender, EventArgs e)
      {
          UpdateRadioButtons();
      }

      private void radioButtonPremium_CheckedChanged(object sender, EventArgs e)
      {
          UpdateRadioButtons();
      }

      private void labelQuotationHistory_Click(object sender, EventArgs e)
      {
          if (!hasDoneFirstQuote)
          {
              MessageBox.Show("¡Debes realizar al menos una venta para ver el historial!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              return;
          }
          HistoryForm historyForm = new HistoryForm();
          historyForm.Show();
          historyForm.ShowHistory(quotationController.Seller.QuotationsHistory);
      }
  }
}