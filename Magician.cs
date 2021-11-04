using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiatorGame
{
    class Magician:CharacterHeroes
    {
        public Magician()
        {
            _health = 75;
            _heroClass = "Маг";
            _damageWeapon = 10;
            _armor = 50;
        }
        public void StartGame(CharacterHeroes hero)
        {
            string name = _heroClass;
            Game(hero,name);

        }
        protected override void  Game(CharacterHeroes hero,string name)
        {
            Random rnd = new Random();
            int Chance = rnd.Next(0, 2); 
            if (Chance==1)
            {
                _health += 10;
                SendMasage Send = new SendMasage();
                string massage = ("С шансом 50%" + _heroClass + "использовал фласку(хилку).Его жизни увеличиислиь на 10\nЖизни: " + _health);
                Send.Massage(massage);
            }
            base.InstalDamage(_damageWeapon);
            base.Action(hero,name);
        }
    }
}
