using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    public class SymbolType
    {
        public string Type;
        public string Regex;
    }
    public class FoundSymbol
    {
        public string content;
        public SymbolType type;
    }
    public class SymbolReader
    {
        public static SymbolType[] MatchTypes = new[] {
            new SymbolType {Type = "identyfikator",Regex = @"[^\W_]+"},
            new SymbolType {Type = "int",Regex = @"\d+"},
            new SymbolType {Type = "float",Regex = @"\d+\.\d+"},
            new SymbolType {Type = "plus",Regex = @"\+"},
            new SymbolType {Type = "minus",Regex = @"-"},
            new SymbolType {Type = "gwiazdka",Regex = @"\*"},
            new SymbolType {Type = "ukośnik",Regex = @"\/"},
            new SymbolType {Type = "nawiasLewy",Regex = @"\("},
            new SymbolType {Type = "nawiasPrawy",Regex = @"\)"},
            new SymbolType {Type = "znBiały",Regex = @"[ \n]+"},
            new SymbolType {Type = "błąd",Regex = ""},
        };

        string baseText;
        string currentText;
        public SymbolReader(string text)
        {
            baseText = text;
            currentText = text;
        }

        public FoundSymbol GetNextSymbol()
        {
            List<SymbolType> currentSymbols;
            bool isFinished = false;
            string currentFragment = "";
            do
            {
                currentSymbols = new List<SymbolType>();
                //currentFragment += currentText

            }
            while (!isFinished);

        }
    }
}
