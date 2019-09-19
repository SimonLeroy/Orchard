using Orchard.ProviderDice;
using System;
using System.Collections.Generic;
using System.Text;

namespace Orchard.Utils
{
   public class Util
    {
        public bool isOkToPlay(string response)
        {
            if(response.ToUpper() == "O")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isListEqualZero(List<int>list)
        {
            if(list.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }  
       
    }
}
