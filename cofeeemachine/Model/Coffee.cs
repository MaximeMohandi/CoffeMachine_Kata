namespace cofeeemachine.Model
{
    public record Coffee : Drink
    {
        public Coffee()
        {
            _codeChar = "C";
        }

        public override string ToString()
        {
            return GetMessage(_codeChar);
        }
    }
}
