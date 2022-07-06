namespace cofeeemachine.Model
{
    public record Tea : Drink
    {
        public Tea()
        {
            _codeChar = "T";
        }

        public override string ToString()
        {
            return GetMessage(_codeChar);
        }
    }
}
