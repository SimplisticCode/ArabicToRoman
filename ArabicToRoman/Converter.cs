using System;
using System.Collections.Generic;
using System.Linq;

namespace ArabicToRoman
{
    public class Converter
    {
        private List<Symbol> symbols { get; set; }

        public Converter()
        {
            symbols = new List<Symbol>
            {
                new Symbol(1, "I", 1, "None"),
                new Symbol(5, "V", 0.8, "I"),
                new Symbol(10, "X", 0.8, "I"),
                new Symbol(50, "L", 0.8, "X"),
                new Symbol(100, "C", 0.9, "X"),
                new Symbol(500, "D", 0.8, "C"),
                new Symbol(1000, "M", 0.9, "C")
            };
        }
        
        public string Convert(int arabicNumber)
        {
            var result = "";
            
            var lastSymbol = symbols.First();
            var isPrefixed = false;

            while (arabicNumber > 0)
            {
                foreach (var symbol in symbols)
                {
                    if (arabicNumber >= symbol.Arabic)
                    {
                        lastSymbol = symbol;
                    }
                    else if(shouldBePrefixed(arabicNumber, symbol))
                    {
                        result += prefixRomanNumber(ref arabicNumber, symbol);
                        isPrefixed = true;
                    }
                    else if(arabicNumber < symbol.Arabic)
                    {
                        break;
                    }
                }

                if (!isPrefixed)
                {
                    result += lastSymbol.Roman;
                    arabicNumber -= lastSymbol.Arabic;
                }

                isPrefixed = false;
            }

            return result;

        }

        private string prefixRomanNumber(ref int arabicNumber, Symbol symbol)
        {
            var result = symbol.Prefix;
            arabicNumber += symbols.First(o => o.Roman == symbol.Prefix).Arabic;
            return result;
        }

        private static bool shouldBePrefixed(int arabicNumber, Symbol symbol)
        {
            return Decimal.Divide(arabicNumber, symbol.Arabic) >= (decimal) symbol.Fraction;
        }
    }
}