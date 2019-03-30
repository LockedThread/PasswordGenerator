using System;
using System.Text;

namespace PasswordGenerator
{
    public class Password
    {
        public Password(int length, bool alphanumeric, bool symbols)
        {
            Length = length;
            Alphanumeric = alphanumeric;
            Symbols = symbols;
        }

        public bool Alphanumeric { get; set; }
        public int Length { get; set; }
        public bool Symbols { get; set; }

        public string createPassword(Random random)
        {
            var allowed = getAllowedCharacters();
            var stringBuilder = new StringBuilder();
            for (var i = 0; i < Length; i++) stringBuilder.Append(allowed[random.Next(0, allowed.Length)]);

            return stringBuilder.ToString();
        }

        public char[] getAllowedCharacters()
        {
            return Symbols && Alphanumeric ? ArrayUtils.CombineArrays(ref Program.Symbols, ref Program.Alphanumeric) :
                Symbols ? Program.Symbols :
                Alphanumeric ? Program.Alphanumeric : null;
        }
    }
}