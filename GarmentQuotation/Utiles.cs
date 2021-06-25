using System;

namespace GarmentQuotation
{
    public static class Utiles
    {
        public static bool ValidateFields(string field, string type)
        {
            switch (type)
            {
                case "string":
                    if (field.Trim() != "")
                    {
                        try
                        {
                            Convert.ToString(field.Trim());
                            return true;
                        }
                        catch (Exception)
                        {
                            return false;
                        }
                    }
                    else return false;

                case "int":
                    if (field != null)
                    {
                        try
                        {
                            Convert.ToInt32(field);
                            return true;
                        }
                        catch (Exception)
                        {
                            return false;
                        }
                    }
                    else return false;
                    
                case "float":
                    if (field != null)
                    {
                        try
                        {
                            Convert.ToSingle(field);
                            return true;
                        }
                        catch (Exception)
                        {
                            return false;
                        }
                    }
                    else return false;
                    
                default : return false;
            }
        }
    }
}