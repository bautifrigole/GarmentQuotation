using System.Collections.Generic;
using System.Windows.Forms;
using GarmentQuotation.Model;

namespace GarmentQuotation
{
    public partial class HistoryForm : Form
    {
        private string _content;
        
        public HistoryForm()
        {
            InitializeComponent();
        }

        public void ShowHistory(List<Quotation> quotationsHistory)
        {
            quotationsHistory.ForEach(q =>  _content += "Fecha: " + q.QuoteDate.ToShortDateString() + "\nHora: " + q.QuoteDate.ToShortTimeString() +
                                                        "\nPrenda: " + q.QuotedGarment.ClothName + "\nCosto: $" + q.TotalQuote +"\n" + "\n");
            labelHistory.Text = _content;
        }
    }
}