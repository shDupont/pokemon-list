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

namespace pokemonList{
    class PokemonAdaptador : BaseAdapter<Pokemon>{
        private List<Pokemon> pokemoon;
        Activity contexto;
        public PokemonAdaptador(List<Pokemon> pokemon, Activity activity){
            this.pokemoon = pokemon;
            this.contexto = activity;
        }
        public override Pokemon this[int position]{
            get { return pokemoon[position]; }
        }
        public override int Count{
            get { return pokemoon.Count; }
        }
        public override long GetItemId(int position){
            return position;
        }
        public override View GetView(int position, View convertView, ViewGroup parent){
            var item = pokemoon[position];
            View view = convertView;
            if (view == null){
                view = contexto.LayoutInflater.Inflate(Resource.Layout.listItem, null);
            }
            view.FindViewById<TextView>(Resource.Id.nome).Text = item.nome;
            view.FindViewById<TextView>(Resource.Id.tipo).Text = item.tipo;
            switch (item.imagem){
                case 0:
                    view.FindViewById<ImageView>(Resource.Id.imagem).SetImageResource(Resource.Drawable.foguinho);
                    break;
                case 1:
                    view.FindViewById<ImageView>(Resource.Id.imagem).SetImageResource(Resource.Drawable.squirtle);
                    break;
                case 2:
                    view.FindViewById<ImageView>(Resource.Id.imagem).SetImageResource(Resource.Drawable.blastoise);
                    break;
                case 3:
                    view.FindViewById<ImageView>(Resource.Id.imagem).SetImageResource(Resource.Drawable.charizard);
                    break;
            }
            return view;
        }
    }
}