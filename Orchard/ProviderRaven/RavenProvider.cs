using System;
using System.Collections.Generic;
using System.Text;

namespace Orchard.ProviderRaven
{
   public class RavenProvider
    {
        public List<int> GetRavensPath()
        {
            List<int> ravensPath = new List<int>();

            for (int i = 0; i < 8; i++)
            {
                ravensPath.Add(i);
            }

            return ravensPath;           
        } 
    }
}
