using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GarmentQuotation.Controller
{
    public static class FieldsValidator
    {
        public static bool AreFieldsCorrect(List<TextBox> textboxes, string type)
        {
            bool result = true;
            
            foreach (var textBox in textboxes)
            {
                bool isCorrectString = Utiles.ValidateFields(textBox.Text, type);
                
                if (isCorrectString)
                {
                    textBox.BackColor = Color.White;
                }
                else
                {
                    textBox.BackColor = Color.Orange;
                    result = false;
                }
            }
            
            return result;
        }
    }
}