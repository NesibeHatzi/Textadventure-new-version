using System;
using System.IO;
using Newtonsoft.Json;

namespace Program.GameCharacters
{
    public enum Monsters { Dragon, Boar, Bear }

    public class Monster : Character
    {
        public int Attack { get; set; }
        
        
        public static Monster CreateMonster(Monsters monsterType)
        {
            string       projectPath = AppDomain.CurrentDomain.BaseDirectory;
            string       path        = projectPath + @"\JSON\" + monsterType + ".json";
            StreamReader reader      = new StreamReader(path);
            string       jsonData    = reader.ReadToEnd();
            reader.Close();
            Monster loadedMonster = JsonConvert.DeserializeObject<Monster>(jsonData);
            return loadedMonster;
        }


        public Monster(Monsters monsterType) : base("Monster", 10)
        {
            Attack = 10;
        }
    }
}