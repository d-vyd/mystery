using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.Generic;

namespace mystery
{
    public class Know
    {
        // In this simplified demo, a Prolog database is represented as a simple dictionary
        // of string queries and List<string> answers. In the real project, the variable "prolog"
        // is actually a handle to prolog interpreter (https://github.com/jsakamoto/CSharpProlog)
        // and I have no idea where it should go, but this "public static" definition seems to work.
        public static Dictionary<string, List<string>> prolog = new Dictionary<string, List<string>>();
    }

    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // add a few queries and answers to the fake Prolog database
            Know.prolog.Add("person(X)", new List<string>() { "adam", "bob", "carl", "dina" });
            Know.prolog.Add("room(X)", new List<string>() { "bedroom", "hallway", "salon" });
            Know.prolog.Add("location(bob)", new List<string>() { "hallway" });
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
