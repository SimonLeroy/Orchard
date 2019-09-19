using System;
using System.Collections.Generic;
using System.Text;

namespace Orchard.ProviderDice
{
    public class DiceProvider
    {
        private Random random;

        public DiceProvider()
        {
            random = new Random();
        }

        public int RollADice()
        {
            return random.Next(1, 6);
        }

        public string GetDiceValue(int dicesNumber)
        {
            var diceValue = createDiceValue();
           
            return diceValue[dicesNumber];
        }
        private Dictionary<int, string> createDiceValue()
        {
            Dictionary<int, string> diceValue = new Dictionary<int, string>();

            diceValue.Add(1, "Prune");
            diceValue.Add(2, "Pomme rouge");
            diceValue.Add(3, "Pomme verte");
            diceValue.Add(4, "Poire");        
            diceValue.Add(5, "Corbeau");

            return diceValue;

        }
    }
}
