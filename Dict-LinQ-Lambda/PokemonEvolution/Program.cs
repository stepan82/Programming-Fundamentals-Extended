﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonEvolution
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

            var pokemonDiary = new Dictionary<string, List<KeyValuePair<string, long>>>();

            while (data[0] != "wubbalubbadubdub")
            {
                if (data.Length == 1)
                {
                    foreach (var pokemon in pokemonDiary)
                    {
                        if (pokemon.Key == data[0])
                        {
                            Console.WriteLine($"# {pokemon.Key}");

                            foreach (var evo in pokemon.Value)
                            {
                                Console.WriteLine($"{evo.Key} <-> {evo.Value}");
                            }
                        }
                    }
                }

                else
                {

                    string name = data[0];
                    string evolution = data[1];
                    long index = long.Parse(data[2]);

                    if (!pokemonDiary.ContainsKey(name))
                    {
                        pokemonDiary[name] = new List<KeyValuePair<string, long>>();
                    }

                    pokemonDiary[name].Add(new KeyValuePair<string, long>(evolution, index));

                }

                data = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var pokemon in pokemonDiary)
            {
                Console.WriteLine($"# {pokemon.Key}");

                foreach (var evo in pokemon.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"{evo.Key} <-> {evo.Value}");
                }
            }
        }
    }
}