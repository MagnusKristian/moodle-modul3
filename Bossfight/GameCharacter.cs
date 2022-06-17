using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bossfight
{
    internal class GameCharacter
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Strength { get; set; }
        public int Stamina { get; set; }
        public int MaxStamina { get; set; }

        public GameCharacter(string name, int health, int strength, int maxStamina)
        {
            Name = name;
            Health = health;
            Strength = strength;
            MaxStamina = maxStamina;
            Stamina = MaxStamina;
        }

        public void Fight(GameCharacter opponent)
        {
            if (Stamina <= 0)
            {
                Recharge();
                return;
            }
            opponent.Health -= this.Strength;
            this.Stamina -= 10;
            Console.WriteLine($"{this.Name} attacks {opponent.Name}, dealing {this.Strength} damage, leaving opponent with {opponent.Health} HP.");
            
        }
        public void Recharge()
        {
            Console.WriteLine($"{this.Name}'s stamina is {Stamina}.");
            Stamina = MaxStamina;
            Console.WriteLine($"{this.Name}'s stamina is recharging... Stamina is now {this.Stamina}");
        }
    }
}

/*
 * Oppgave: Bossfight
   Oppgave "Bossfight":
   
   Dere skal lage en konsoll app som viser en battle mellom en hero og en boss.
   
   Skriv en klasse GameCharacter som har en metode Fight(), en metode Recharge() og følgende properties:
   
   Health, Strength, Stamina
   
   Program.cs filen må initialisere to objekter av denne klassen, en Hero og en Boss med følgende stats:
   
   Hero:                         Boss:
   Health: 100                Health: 400
   Strength: 20               Strength: 0-30
   Stamina: 40                Stamina: 10
   Disse to skal i kamp frem til en seirer (motstanderen sin health = 0) konsollen skal logge hvem som angriper, hvor mye skade som tas og hvor mye liv motstanderen har igjen etter slaget.
   
   I en fight mister GameCharacterene like mye i Health som mostanderen har i Strength.
   
   Hver gang en character bruker metoden Fight() mister de også 10 stamina.
   
   Om Fight() kalles med 0 i stamina må de bruke metoden Recharge() som restorer Stamina til det de hadde da de startet kampen. De rundene gamecharacterene må recharge får de ikke utført noe skade.
   
   Styrken til Bossen varierer med en random verdi mellom 0-30 for hver gang Fight() kalles. Om dette blir for avansert, la bossen også få en fast styrke på 20.
   
   Eksempel på Konsollens logg når programmet har kjørt ferdig:
   
   Enemy hit hero with 5 damage, hero now has 30 health left.
   Hero hit enemy with 20 damage, enemy has 0 health left.
   Hero is the winner!
   Lykke til <smile>
 */