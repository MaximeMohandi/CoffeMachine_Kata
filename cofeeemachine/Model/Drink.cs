using cofeeemachine.interfaces;

namespace cofeeemachine.Model
{
    public record Drink : IDrink
    {
        protected string _codeChar = "";

        public int NbSugar { get; init; }
        public int NbStirrer => NbSugar > 0 ? 1 : 0;

        public bool ExtraHot { get; init; } = false;

        protected string GetMessage(string coffeeType)
        {
            var sugar = NbSugar == 0 ? "" : NbSugar.ToString();
            var stirrer = NbStirrer == 0 ? "" : "0";
            var extraHot = ExtraHot ? "h" : "";

            return $"{coffeeType}{extraHot}:{sugar}:{stirrer}";
        }

    }
}
