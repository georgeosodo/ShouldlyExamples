using System;
using System.Collections.Generic;
using System.Text;

namespace Democode
{
    public class PlayerCharacter
    {
        public PlayerCharacter()
        {
          Name = GenerateName();
           IsNoob = true;
          CreateStartWeapons();
        }

        private void CreateStartWeapons()
        {
            Weapons = new List<string>
            {
                "Long Bow",
                "Short Bow",
                "Short Sword",
                "Staff of wonder"
            };
        }

        private string GenerateName()
        {
            var names = new[]
            {
                "Danieth",
                "Derrick",
                "Shalnorr",
                "G' Toth' lop",
                "Boldrakteethtop"
            };

            return names[new Random().Next(0, names.Length)];
        }

        public void sleep()
        {
            var rnd = new Random();
            var healthincrease = rnd.Next(1, 101);
            Health += healthincrease;
        }

        public int Health { get; set; }
        public string Name { get; set; }
        public string NickName { get; set; }
        public bool IsNoob { get; set; }
        public List<string> Weapons { get; set; }
    }
}
