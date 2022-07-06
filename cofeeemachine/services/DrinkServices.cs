using cofeeemachine.enums;
using cofeeemachine.interfaces;
using cofeeemachine.Model;

namespace cofeeemachine.services
{
    public class DrinkServices : IDrinkServices
    {
        public string GetDrink(int input, int nbSugar, bool extraHot)
        {
            try
            {
                var result = DefineDrink(input, nbSugar, extraHot).ToString();
                return result;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        private IDrink DefineDrink(int input, int nbSugar, bool extraHot)
        {
            switch (input)
            {
                case (int)DrinkChoicesEnum.Tea:
                    return new Tea { NbSugar = nbSugar, ExtraHot = extraHot };
                case (int)DrinkChoicesEnum.Coffe:
                    return new Coffee { NbSugar = nbSugar, ExtraHot = extraHot };
                case (int)DrinkChoicesEnum.HotChocolate:
                    return new HotChocolate { NbSugar = nbSugar, ExtraHot = extraHot };
                case (int)DrinkChoicesEnum.Orange:
                    return new Orange { NbSugar = nbSugar };

                default: throw new Exception("no drink with this code");

            };
        }

    }
}
