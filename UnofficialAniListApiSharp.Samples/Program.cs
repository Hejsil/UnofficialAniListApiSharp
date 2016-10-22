using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using UnofficialAniListApiSharp.Api;
using UnofficialAniListApiSharp.Api.Data;

namespace UnofficialAniListApiSharp.Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            var auth = Anilist.GrantClientCredentials(
                ConfigurationManager.AppSettings.Get("ClientID"),
                ConfigurationManager.AppSettings.Get("ClientSecret"));

            var animes = Anilist.BrowseAndDeserialize<Anime>(auth, Category.Anime, "year=2016", "season=summer", "full_page=true");
            PrintAllInCollection(animes);
            Console.WriteLine();
            Console.WriteLine();
            
            Console.WriteLine("----- Anime Search -----");
            animes = Anilist.SearchAndDeserialize<Anime>(auth, Category.Anime, "clannad");
            PrintAllInCollection(animes);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("----- Character Search -----");
            var characters = Anilist.SearchAndDeserialize<Anime>(auth, Category.Character, "nagisa");
            PrintAllInCollection(characters);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("----- Staff Search -----");
            var staffs = Anilist.SearchAndDeserialize<Anime>(auth, Category.Staff, "jun");
            PrintAllInCollection(staffs);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("----- Studio Search -----");
            var studios = Anilist.SearchAndDeserialize<Anime>(auth, Category.Studio, "kyoto");
            PrintAllInCollection(studios);
            Console.WriteLine();
            Console.WriteLine();
            /**/

            Console.ReadLine();
        }

        static void PrintAllInCollection<T>(IEnumerable<T> coll)
        {
            Console.WriteLine("[");
            foreach (var item in coll)
            {
                Console.WriteLine("{");

                foreach (PropertyDescriptor prop in TypeDescriptor.GetProperties(item))
                {
                    string name = prop.Name;
                    object value = prop.GetValue(item);
                    Console.WriteLine("\t{0} = {1}", name, value);
                }

                Console.WriteLine("}");
            }
            Console.WriteLine("]");
        }
    }
}
