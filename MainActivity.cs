using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Webkit;
using Android.Widget;
using AndroidX.AppCompat.App;
using System.Collections.Generic;

namespace pokemonList
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        ListView lv;
        List<Pokemon> lista = new List<Pokemon>();
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            lv = FindViewById<ListView>(Resource.Id.lstPokemon);

            lista.Add(new Pokemon
            {
                nome = "Charmander",
                tipo = "Fogo",
                imagem = 0,
                urlPokemon = "https://www.pokemon.com/br/pokedex/charmander"
            });

            lista.Add(new Pokemon
            {
                nome = "Squirtle",
                tipo = "Água",
                imagem = 1,
                urlPokemon = "https://www.pokemon.com/br/pokedex/squirtle"
            });

            lista.Add(new Pokemon
            {
                nome = "Blastoise",
                tipo = "Água",
                imagem = 2,
                urlPokemon = "https://www.pokemon.com/br/pokedex/blastoise"
            });

            lista.Add(new Pokemon
            {
                nome = "Charizard",
                tipo = "Fogo",
                imagem = 3,
                urlPokemon = "https://www.pokemon.com/br/pokedex/charizard"
            });

            lv.Adapter = new PokemonAdaptador(lista, this);
            lv.ItemClick += Lv_ItemClick;
        }

        private void Lv_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var item = lista[e.Position];
            Toast.MakeText(this, item.nome, ToastLength.Short).Show();
            Intent novaTela = new Intent(this, typeof(novaTela));
            novaTela.PutExtra("Url", item.urlPokemon);
            StartActivity(novaTela);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}