﻿// See https://aka.ms/new-console-template for more information
using PokemonUI;

bool repeat = true;
IMenu menu = new MainMenu();

while (repeat)
{
    menu.Display();
    string ans = menu.UserChoice();

    switch (ans)
    {
        case "SearchPokemon":
            //call SearchPokemon method
            Console.WriteLine("SearchPokemon() Method implementation is in progress....");
            break;
        case "AddPokemon":
            PokemonOperations.AddDummyPokemon();
            Console.WriteLine("Actual AddPokemon() method implementaion is in progress.... This is just a dummy");
            break;
        case "GetAllPokemons":
            PokemonOperations.GetAllPokemons();
            break;
        case "MainMenu":
            menu=new MainMenu();
            break;
        case "Exit":
            repeat = false;
            break;
        default:
            Console.WriteLine("View does not exist");
            Console.WriteLine("Please press <enter> to continue");
            Console.ReadLine();
            break;
    }
}