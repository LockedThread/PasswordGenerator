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

        private bool Alphanumeric { get; }
        private int Length { get; }
        private bool Symbols { get; }

        public string CreatePassword(Random random)
        {
            var allowed = GetAllowedCharacters();
            var stringBuilder = new StringBuilder();
            for (var i = 0; i < Length; i++) stringBuilder.Append(allowed[random.Next(0, allowed.Length)]);

            return stringBuilder.ToString();
        }

        public char[] GetAllowedCharacters()
        {
            return Symbols && Alphanumeric ? ArrayUtils.CombineArrays(ref Program.Symbols, ref Program.Alphanumeric) :
                Symbols ? Program.Symbols :
                Alphanumeric ? Program.Alphanumeric : null;
        }
    }
}