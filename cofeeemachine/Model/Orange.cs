namespace cofeeemachine.Model
{
    public record Orange : Drink
    {
        public Orange()
        {
            _codeChar = "O";
        }

        public override string ToString()
        {
            return GetMessage(_codeChar);
        }
    }
}
