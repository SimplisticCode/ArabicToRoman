using System.Security.Cryptography;
using System.Xml.Schema;

namespace ArabicToRoman
{
    public class Symbol
    {
        public Symbol(int arabic, string roman, double fraction, string prefix)
        {
            Arabic = arabic;
            Roman = roman;
            Fraction = fraction;
            Prefix = prefix;
        }

        public string Prefix { get; set; }

        public int Arabic { get; set; }
        public string Roman { get; set; }        
        public double Fraction { get; set; }
    }
}