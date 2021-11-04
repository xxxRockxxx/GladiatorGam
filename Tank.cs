using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiatorGame
{
    class Tank:CharacterHeroes
    {
        public Tank()
        {
            _health = 100;
            _heroClass = "Танк";
            _damageWeapon = 20;
            _armor = 100;

        }
        public void StartGame(CharacterHeroes hero)
        {
            string name = _heroClass;
            Game(hero,name);

        }
        protected override void TakeDamage(int damage,string name)
        {
            string massage = "";
            Random rnd = new Random();
            int Chance = rnd.Next(0,2);
            if (Chance == 0 && (_armor>0 && (_armor-(damage/2)>=0)))
            {
                _armor -= (damage / 2);
                _health -= (damage / 2);
                massage=(name+"Атаковал персонажа"+_heroClass+"\n Осталось здоровья:"+_health+"\t Осталось брони:"+_armor);
            }
            else
            {
                _health -= damage;
                massage = (name + "Атаковал персонажа" + _heroClass + "\n Осталось здоровья:" + _health + "\t Осталось брони:" + _armor);
            }
            SendMasage Send = new SendMasage();
            Send.Massage(massage);
        }
        protected override void Game(CharacterHeroes hero,string name)
        {
            base.InstalDamage(_damageWeapon);
            base.Action(hero,name);
        }

    }
}
