namespace cofeeemachine.interfaces
{
    public interface IDrink
    {
        public int NbSugar { get; init; }

        public int NbStirrer { get; }

        public bool ExtraHot { get; init; }

    }
}
