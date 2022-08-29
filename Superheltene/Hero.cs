using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superheltene
{
    public class Hero
    {
        private string identity;
        private string power;
        private string costume;
        private string backstory;
        private string moralcode;
        private string nemesis;
        private string weakness;


        public string Identity
        {
            get { return identity; }
            private set
            {
                identity = "batman";
            }
        }
        public string Power
        {
            get { return power; }
            private set
            {
                power = "always prepared";
            }
        }
        public string Costume
        {
            get { return costume; }
            private set
            {
                costume = "black outfit, cape, bat ears, utility belt";
            }
        }
        public string Backstory
        {
            get { return backstory; }
            private set
            {
                backstory = "parents being shot, he avenges them as a crime fighting vigilante";
            }
        }
        public string Moralcode
        {
            get { return moralcode; }
            private set
            {
                moralcode = "do not kill";
            }
        }
        public string Nemesis
        {
            get { return nemesis; }
            private set
            {
                nemesis = "the joker";
            }
        }
        public string Weakness
        {
            get { return weakness; }
            private set
            {
                weakness = "being unprepared";
            }
        }
    }
}
