﻿using PokemonDL;
using PokemonModels;

namespace PokemonUI
{
    internal class PokemonOperations
    {
        static Repository repository= new Repository();

        public static void GetAllPokemons() {
            repository.GetAllPokemons();
        }
        public static void AddDummyPokemon()
        {
            Pokemon pokemon1 = new Pokemon() {
                Name = "Pikachu",
                Level = 4,
                Attack = 40,
                Defense = 45,
                Health = 50,
                Abilities = new List<Ability>() { 
                    new Ability()
                    {
                        Name = "ThunderBolt",
                        Accuracy = 100,
                        Power = 90,
                        PP = 15
                    }
                }
            };
            
            repository.AddPokemon(pokemon1);
        }
    }
}
