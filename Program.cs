using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

/* Projektvorgabe:
  
Zwischen zwei Terminals eines Hafens verkehrt ein Zubringerbus, der jeweils
zur halben und zur vollen Stunde losfährt. Schreiben Sie ein Programm, das
eine Uhrzeit in der Form hhmm (also ein Parameter, aber ohne führende Nullen)
erhält und berechnet, wie lange es bis zur Abfahrt des nächsten Busses 
noch dauert. Dabei bezeichnet hh die aktuelle Stunde und mm die aktuelle Minute.
Tipp: Berechne bitte aus den Minuten der aktuellen Uhrzeit die zugehörige 
halbe Stunde.

 */

namespace BusTerminal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Timekeeper.getTimeUntilNextBusDepartures("1337"));
        }
    }
}
