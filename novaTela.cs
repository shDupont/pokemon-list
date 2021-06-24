using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Webkit;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pokemonList
{
    [Activity(Label = "novaTela")]
    public class novaTela : Activity
    {
        WebView webview1;
        string urlPokemon;
        Button btnVoltar;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.telaWeb);

            webview1 = FindViewById<WebView>(Resource.Id.webView1);
            btnVoltar = FindViewById<Button>(Resource.Id.btnVoltar);

            webview1.Settings.JavaScriptEnabled = true;
            urlPokemon = Intent.GetStringExtra("Url");
            webview1.SetWebViewClient(new MeuWebViewClient());
            webview1.LoadUrl(urlPokemon);
            btnVoltar.Click += BtnVoltar_Click;
        }

        private void BtnVoltar_Click(object sender, System.EventArgs e)
        {
            Finish();
        }

        public class MeuWebViewClient : WebViewClient
        {
            public override bool ShouldOverrideUrlLoading(WebView view, string url)
            {
                view.LoadUrl(url);
                return true;
            }
        }
    }
}