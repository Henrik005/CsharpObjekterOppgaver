
using CsharpObjekterOppgaver;

var pokemon1 = new Pokemon(25, 50, "Snarf", "Snom");
var pokemon2 = new Pokemon(15, 800, "Barf", "Diglet");
var pokemon3 = new Pokemon(50, 560, "Lucius Autumn", "Lucario");
var pokemon4 = new Pokemon(33, 440, "Horf", "Ratatta");
var pokemon5 = new Pokemon(2, 5, "Garf", "Squirtle");
List<Pokemon> pokedex = new List<Pokemon> { pokemon1, pokemon2, pokemon3, pokemon4, pokemon5 };
Play play = new Play();
play.Run(pokedex);