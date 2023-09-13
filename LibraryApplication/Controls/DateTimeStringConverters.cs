using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication.Controls
{
    public class DateTimeStringConverters
    {

        public string ConvertDateToStringInFormat(DateTime date)
        {
            string format = date.GetDateTimeFormats().First().ToString();
            return date.ToString(format);
        }

        public DateTime ConvertStringToDateInFormat(string value)
        {
            
            var format = "dd/MM/yyyy hh:mm:ss tt";
            var dateTime = DateTime.ParseExact(value, format, CultureInfo.InvariantCulture);

            

            return dateTime;
        }

    }
}
