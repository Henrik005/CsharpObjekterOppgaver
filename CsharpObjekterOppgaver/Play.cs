using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpObjekterOppgaver
{
    internal class Play
    {
        public void Run(List<Pokemon> pokedex)
        {
            ShowPokemon(pokedex);



        }
        public void ShowPokemon(List<Pokemon> pokedex)
        {
            for (int i = 0; i < pokedex.Count; i++)
            {
                pokedex[i].PrintStats();
            }
        }
    }
}
