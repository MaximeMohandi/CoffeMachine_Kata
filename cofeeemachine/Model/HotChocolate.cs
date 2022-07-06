namespace cofeeemachine.Model
{
    public record HotChocolate : Drink
    {
        public HotChocolate()
        {
            _codeChar = "H";
        }

        public override string ToString()
        {
            return GetMessage(_codeChar);
        }
    }
}
