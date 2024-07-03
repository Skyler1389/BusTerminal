using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace BusTerminal
{
    internal static class Timekeeper
    {
        public static String getTimeUntilNextBusDepartures(String hhmm)
        {
            if (hhmm.Length > 4)
            {
                throw new ArgumentException(hhmm 
                    + " String does not conform to hhmm format!");
                // Fehlermeldung, falls der String nicht dem Format
                // entsprechen kann
            }
            if (int.Parse(String.Concat(hhmm[0], hhmm[1])) >= 24 
                || int.Parse(String.Concat(hhmm[2], hhmm[3])) >= 60)
            {
                throw new ArgumentException(hhmm 
                    + " String is not a valid time!");
                // Fehlermeldung, falls die gegeben Zeit nicht existiert
            }
            if (hhmm.Length < 4)
            {
                hhmm.PadLeft(-hhmm.Length + 4, '0');
                // Füge führende Nullen hinzu, wenn die Uhrzeit ohne
                // übergeben wurde.
            }
            int minutes = int.Parse(String.Concat(hhmm[2], hhmm[3]));
            // Ermittle die Minuten anhand des Übergebenen Strings
            int minutesSinceLastBiHourlyDeparture = minutes % 30;
            // Ermittle Unterschied der aktuellen Minute zur letzten
            // halben Stunde
            int minutesUntilNextBiHourlyDeparture = 30 
                - minutesSinceLastBiHourlyDeparture;
            // Ermittle die Differenz zwischen der nächsten
            // und letzten Abfahrt
            String output = "The next bus departure is in " 
                + minutesUntilNextBiHourlyDeparture.ToString() + " minutes";
            if (minutesUntilNextBiHourlyDeparture == 30)
            {
                output = "The bus is departing now!";
            }
            return output;
        }
    }
}
