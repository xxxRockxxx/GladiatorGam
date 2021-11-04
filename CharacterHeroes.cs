using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiatorGame
{
    abstract class CharacterHeroes
    {
        protected int _health;
        protected int _damageWeapon;
        protected int _armor;
        protected string _heroClass;

        protected void InstalDamage(int damageWeapon)
        {
            _damageWeapon = damageWeapon;
        }

        protected void Action(CharacterHeroes hero,string name)
        {
            hero.TakeDamage(_damageWeapon,name);
        }
        protected virtual void TakeDamage(int damage,string name)
        {
            string massage = "";
            if (_armor > 0)
            {
                _armor -= _damageWeapon;
                massage = (name + "Атаковал персонажа" + _heroClass + "\n Осталось здоровья:" + _health + "\t Осталось брони:" + _armor);
            }
            else
            {
                _health -= _damageWeapon;
                massage = (name + "Атаковал персонажа" + _heroClass + "\n Осталось здоровья:" + _health + "\t Осталось брони:" + _armor);
            }
            SendMasage Send = new SendMasage();
            Send.Massage(massage);

        }
        protected virtual void Game(CharacterHeroes hero,string name)
        {
            Action(hero,name);

        }
    }
}
