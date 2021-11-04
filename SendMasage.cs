using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiatorGame
{
    class SendMasage:CharacterHeroes
    {
        public void Massage(string massage)
        {
            string ShowMessage = "";
            ShowMessage = massage;
            Console.WriteLine(ShowMessage);
        }
    }
}
