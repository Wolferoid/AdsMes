using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuxiliaryLibrary
{
    public static class BoolToString
    {
        public static string YesNo(bool? bVal)
        {
            string result;
            if (bVal.HasValue)
            {
                result = (bool)bVal ? "Да" : "Нет";
            }
            else
            {
                result = "Не указано";
            }
            return result;
        }

        public static string Conformity(bool? bVal)
        {
            string result;
            if (bVal.HasValue)
            {
                result = (bool)bVal ? "Соответствует" : "Не соответствует";
            }
            else
            {
                result = "Не указано";
            }
            return result;
        }
    }
}
