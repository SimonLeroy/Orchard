using Orchard.ProviderDice;
using Orchard.ProviderFruits;
using Orchard.ProviderRaven;
using Orchard.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orchard
{
    public class RunOrchard
    {
        public void Run()
        {
            FruitsProvider fruitsProvider = new FruitsProvider();
            RavenProvider ravenProvider = new RavenProvider();
            DiceProvider dice = new DiceProvider();
            Util util = new Util();
                     
            var listPommeVerte = fruitsProvider.GetFruits();
            var listPommeRouge = fruitsProvider.GetFruits();
            var listPoire = fruitsProvider.GetFruits();
            var listPrune = fruitsProvider.GetFruits();
           
            var RavensPath = ravenProvider.GetRavensPath();
            int Prunes = listPrune.Count;
            int PommesVertes = listPommeVerte.Count;
            int PommesRouges = listPommeRouge.Count;
            int Poires = listPoire.Count;
            int raven = RavensPath.Count;
            int fruits = 16;
            int ravenposition = 0;

            Console.WriteLine("************nouvelle partie**********");

            while ((fruits > 0) && (raven  > 0))
            {
                Console.WriteLine("************score******************************");
                Console.WriteLine("Corbeau "+ ravenposition.ToString() + " Poires " +Poires.ToString()+ " Pommes vertes "+ PommesVertes.ToString());
                Console.WriteLine("Prunes " + Prunes.ToString() + "  " + Poires.ToString() + " Pommes rouges " + PommesRouges.ToString());
                Console.WriteLine("***********************************************");
                Console.WriteLine("   ");
                Console.WriteLine("Lancer le dé en tapant O");
                string response = Console.ReadLine();

                if (util.isOkToPlay(response))
                {
                    var diceresult = dice.RollADice();
                    var diceValue = dice.GetDiceValue(diceresult);
                    switch (diceValue)
                    {
                        case "Prune":                          
                            if(Prunes > 0)
                            {
                                Prunes--;
                                fruits--;
                                Console.WriteLine("Vous gagnez une prune. il reste " + Prunes.ToString() + " prune(s) à cueillir");
                            }
                            else
                            {
                                Console.WriteLine("pas de chance plus de Prune");
                            }                           
                            break;
                        case "Pomme verte":
                            if(PommesVertes > 0)
                            {
                                PommesVertes--;
                                fruits--;
                                Console.WriteLine("Vous gagnez une pomme verte. il reste " + PommesVertes.ToString() + " pomme(s) verte(s) à cueillir");
                            }
                            else
                            {
                                Console.WriteLine("pas de chance plus de Pomme verte");
                            }

                            break;
                        case "Pomme rouge":
                            if(PommesRouges > 0)
                            {
                                PommesRouges--;
                                fruits--;
                                Console.WriteLine("Vous gagnez une pomme rouge. il reste " + PommesRouges.ToString() + " pomme(s) rouge(s) à cueillir");
                            }
                            else
                            {
                                Console.WriteLine("pas de chance plus de Pomme rouge");
                            }

                            break;
                        case "Corbeau":
                            raven--;
                            ravenposition++;
                           
                            Console.WriteLine("le corbeau gagne il avance d'une case. Position " + ravenposition.ToString() + "sur 8");
                            break;
                        case "Poire":
                            if(Poires > 0)
                            {
                                Poires--;
                                fruits--;
                                Console.WriteLine("Vous gagnez une poire. il reste " + Poires.ToString() + " poires(s) à cueillir");
                            }
                            else
                            {
                                Console.WriteLine("pas de chance plus de Poire");
                            }
                           
                            break;
                    }
                }
                else
                {
                    break;
                }
                              
            }
            if(raven == 0)
            {
                Console.WriteLine("Le corbeau dévore tous les fruits vous avez perdu");
            }
            else
            {
                Console.WriteLine("bravo vous avez gagné");
            }
            Console.ReadKey();
        } 
       
    }
}
