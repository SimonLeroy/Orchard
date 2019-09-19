using System;
using System.Collections.Generic;
using System.Text;

namespace Orchard.ProviderFruits
{
   public class FruitsProvider
    {

        public List<int> GetFruits()
        {
            List<int> listFruits = new List<int>();

            for(int i = 0; i < 4; i++)
            {
                listFruits.Add(i);
            }

            return listFruits;
        }
    }
}
