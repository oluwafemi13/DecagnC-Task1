using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTask1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int numberMachineCanWash = 20;
            int[] cleanPile = new int[] { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };
            int[] dirtyPile = new int[] { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };
            //Program p = new Program();
            GetMaximumPairOfSocks(numberMachineCanWash, cleanPile, dirtyPile);
        }
        public static void GetMaximumPairOfSocks(int numberMachineCanWash, int[] cleanPile, int[] dirtyPile)
        {
            //List<int> cleanpile = new List<int>(cleanPile);
            //List<int> dirtypile = new List<int>(dirtyPile);
            int[] cleanpair = new int[] { };
            int[] dirtypair = new int[] { };
            int totalCleanPair = 0;
            int totalDirtyPair = 0;
            int totalPair = 0;
            int value;
            int value2;

            List<int> occurrences = new List<int>();
            List<int> occurrences2 = new List<int>();

            for (int i = 0; i < 50; i++)
            {
                value = cleanPile.Count(x => x == i);
                occurrences.Add(value);
            }
            for (int j = 0; j < occurrences.Count; j++)
            {
                if (occurrences[j] == 0)
                {
                    totalCleanPair += 0;
                }
                else if (occurrences[j] == 1)
                {
                    totalCleanPair += 0;
                }
                else if (occurrences[j] == 2)
                {
                    totalCleanPair += 1;
                }
                if (occurrences[j] > 2 && occurrences[j] % 2 == 0 || occurrences[j] % 2 == 1)
                {
                    totalCleanPair += occurrences[j] / 2;
                }
            }

            //searching  through the dirty pair
            for (int i = 0; i < dirtyPile.Length; i++)
            {
                value2 = dirtyPile.Count(x => x == i);
                occurrences2.Add(value2);

                if (occurrences[i] !=1 || occurrences[i]%2 != 1 && numberMachineCanWash>1)
                {
                    

                    if (occurrences2[i] == 0)
                    {
                        totalDirtyPair += 0;
                    }
                    else if (occurrences2[i] == 1)
                    {
                        totalDirtyPair += 0;
                    }
                    else if (occurrences2[i] == 2)
                    {
                        totalDirtyPair += 1;
                    }
                    if (occurrences2[i] > 2 && occurrences2[i] % 2 == 0 || occurrences2[i] % 2 == 1)
                    {
                        totalDirtyPair += occurrences2[i] / 2;
                    }

                    /* if(numberMachineCanWash%2 == 1)
                     {
                         int Pair = (numberMachineCanWash - 1);
                         if (Pair == 2)
                         {
                             totalDirtyPair += 1;
                         }else if (Pair >2)
                         {
                             totalDirtyPair = totalDirtyPair + (Pair / 2);
                         }


                     }
                     else if(numberMachineCanWash % 2 == 0 && numberMachineCanWash>=2)
                     {
                         if(numberMachineCanWash == 2)
                         {
                             totalDirtyPair += 1;
                         }
                         else
                         {
                             totalDirtyPair = numberMachineCanWash / 2;
                             //totalDirtyPair = totalDirtyPair + (Pair / 2);
                         }

                     }*/

                }

                if (occurrences[i] == 1 || occurrences[i] % 2 == 1 && numberMachineCanWash == 1)
                {
                    totalDirtyPair += 0;
                }

                if (occurrences[i] == 1 && numberMachineCanWash == 2)
                {
                    value = dirtyPile.Count(x => x == i);
                    if (value >= 1)
                    {
                        totalDirtyPair += 1;
                    }
                    else
                    {
                        totalDirtyPair += 0;
                    }
                }
                else if (occurrences[i] % 2 == 1 && numberMachineCanWash == 2)
                {
                    value = dirtyPile.Count(x => x == i);
                    if (value >= 1)
                    {
                        totalDirtyPair += 1;
                    }
                    else
                    {
                        totalDirtyPair += 0;
                    }

                }
                else if (occurrences[i] % 2 == 1 || occurrences[i] == 1 && numberMachineCanWash > 2)
                {
                    value = dirtyPile.Count(x => x == i);
                    if (value == 1)
                    {
                        totalDirtyPair += 1;
                    }
                    else if (value >= 2)
                    {
                        value = (numberMachineCanWash - 1) / 2;
                        totalDirtyPair += value;
                    }

                }

                totalPair = totalCleanPair + totalDirtyPair;


                String z = totalPair.ToString();

                String s = totalCleanPair.ToString();
                //String s = occurrences.ToString();  
                String y = String.Join(",", occurrences);

                //Console.WriteLine(y);
                //Console.WriteLine(s);
                Console.WriteLine(z);
                Console.ReadLine();

                

            }
        }
    }
}

