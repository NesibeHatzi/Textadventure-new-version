using System;
using System.IO;
using Newtonsoft.Json;

namespace Program.GameCharacters
{
    public enum Friendlies { Fairy }

    public class Friendly : Character
    {
        public static Friendly CreateFriendly (Friendlies friendlyType)
        {
            string projectPath = AppDomain.CurrentDomain.BaseDirectory;
            string path = projectPath + @"\JSON\" + friendlyType + ".json";
            StreamReader reader = new StreamReader (path);
            string jsonData = reader.ReadToEnd ();
            reader.Close ();
            Friendly loadedFriendly = JsonConvert.DeserializeObject<Friendly> (jsonData);
            return loadedFriendly;
        }

        public Friendly () : base ("Friendly", 10) { }

        public int Power { get; }
    }
}