using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDon_tGo
{
    class Program
    {
        static void Main(string[] args)
        {
            var pokemons = Console.ReadLine().Split().Select(int.Parse).ToList();

            long removedElements = 0;

            while (pokemons.Count() != 0)
            {
                int index = int.Parse(Console.ReadLine());

                if (index < 0)
                {
                    int current = pokemons[0];
                    removedElements += current;
                    pokemons.RemoveAt(0);
                    pokemons.Insert(0, pokemons[pokemons.Count - 1]);
                    for (int i = 0; i < pokemons.Count; i++)
                    {
                        if (pokemons[i] <= current)
                        {
                            pokemons[i] += current;
                        }
                        else
                        {
                            pokemons[i] -= current;
                        }
                    }
                }

                else if (index > pokemons.Count - 1)
                {
                    int current = pokemons[pokemons.Count - 1];
                    removedElements += current;
                    pokemons.RemoveAt(pokemons.Count - 1);
                    pokemons.Add(pokemons[0]);
                    for (int i = 0; i < pokemons.Count; i++)
                    {
                        if (pokemons[i] <= current)
                        {
                            pokemons[i] += current;
                        }
                        else
                        {
                            pokemons[i] -= current;
                        }
                    }
                }

                else
                {
                    int current = pokemons[index];
                    removedElements += current;
                    pokemons.RemoveAt(index);
                    for (int i = 0; i < pokemons.Count; i++)
                    {
                        if (pokemons[i] <= current)
                        {
                            pokemons[i] += current;
                        }
                        else
                        {
                            pokemons[i] -= current;
                        }
                    }
                }
            }


            Console.WriteLine(removedElements);
        }
    }
}
