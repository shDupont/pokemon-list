using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pokemonList
{
    class Pokemon
    {
        public string nome { get; set; }
        public string tipo { get; set; }
        public string urlPokemon { get; set; }
        public int imagem { get; set; }

        public Pokemon()
        {
            nome = "";
            tipo = "";
            imagem = 0;
            urlPokemon = "";
        }
    }
}