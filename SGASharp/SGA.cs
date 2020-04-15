using System;
using System.Collections.Generic;
using System.Linq;

namespace SGASharp
{
    public static class SGA
    {
        public static Dictionary<char, string> CharacterTable = new Dictionary<char, string>()
        {
            ['a'] = "ᔑ",
            ['b'] = "ʖ",
            ['c'] = "ᓵ",
            ['d'] = "↸",
            ['e'] = "ᒷ",
            ['f'] = "⎓",
            ['g'] = "⊣",
            ['h'] = "⍑",
            ['i'] = "╎",
            ['j'] = "⋮",
            ['k'] = "ꖌ",
            ['l'] = "ꖎ",
            ['m'] = "ᒲ",
            ['n'] = "リ",
            ['o'] = "フ",
            ['p'] = "!¡",
            ['q'] = "ᑑ",
            ['r'] = "∷",
            ['s'] = "ᓭ",
            ['t'] = "ℸ ̣",
            ['u'] = "⚍",
            ['v'] = "⍊",
            ['w'] = "∴",
            ['x'] = "̇/",
            ['y'] = "׀׀",
            ['z'] = "⨅",
            ['.'] = "·-·"
        };

        public static string LatinToSGA(string text)
        {
            string newText = "";

            foreach (var c in text.ToCharArray())
            {
                if (CharacterTable.ContainsKey(char.ToLower(c)))
                    newText += CharacterTable[char.ToLower(c)];
                else newText += c;
            }

            return newText;
        }

        public static string SGAToLatin(string text, bool upperCase = false)
        {
            string newText = "";

            for (int i=0; i<text.Length; i++)
            {
                string buffer = "";

                while(i<text.Length)
                {
                    buffer += text[i];

                    if(text[i] == ' ' || (i == text.Length-2 && text[i + 1] == ' ')) break;

                    if(CharacterTable.Values.Any(v => v.StartsWith(buffer))) 
                    {
                        if(CharacterTable.ContainsValue(buffer)) break;
                        else i++;
                    }
                }

                newText += CharacterTable.ContainsValue(buffer) ?
                    (upperCase ?
                        CharacterTable.First(x => x.Value == buffer).Key.ToString().ToUpper() :
                        CharacterTable.First(x => x.Value == buffer).Key.ToString()) :
                    buffer;
            }

            return newText;
        }
    }

    public static class SGAStringExtension
    {
        public static string LatinToSGA(this String str)
            => SGA.LatinToSGA(str);

        public static string SGAToLatin(this String str, bool upperCase = false)
            => SGA.SGAToLatin(str, upperCase);
    }
}