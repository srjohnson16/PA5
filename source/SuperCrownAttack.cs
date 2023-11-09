namespace source
{
    public class SuperCrownAttack: IAttack
    {         
          public void PreformAttack(Character attacker, Character defender) {
           System.Console.WriteLine("Fireflower");
           
           System.Console.WriteLine($"{attacker.name} attacks using Super Crown!");
               PlayAttackSound();

           //calc type bonus 
          double typeBonus =  CalcTypeBonus(attacker, defender);

          //calc damage 
          double damage = CalcDamage(attacker, defender, typeBonus);

          //calc health 
          defender.health -= damage;

          System.Console.WriteLine($"Damage dealth: {damage}");
          System.Console.WriteLine($"{defender.name} health: {defender.health}");

           PressToContinue();
           PlayHitSound();

          //health logic 
          if(defender.health <=0) {
            System.Console.WriteLine($"{defender.name} has been defeated");
          }
        
        }
              private void PlayAttackSound()
        {
            // Simulate an attack sound
            Console.Beep(1000, 200);
        }

        private void PlayHitSound()
        {
            // Simulate a hit sound
            Console.Beep(500, 200);
        }

private void PressToContinue()
        {
            System.Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
        }
public static int CalcDamage(Character attacker, Character defender, double typeBonus) {
    int damage = 0;

    damage = (int)((attacker.attackStrength - defender.defensePower) * typeBonus);



    return damage;
}
        public bool IsSpecialCombination(Character attacker, Character defender) {

            if ((attacker.name == "Mario" && defender.name == "Bowser")||(defender.name == "Mario"&& attacker.name == "Donkey Kong")) {
                return true;
            }
            else return false;
        }

        public double CalcTypeBonus(Character attacker, Character defender) {
            double typeBonus = 0.0;

            if(IsSpecialCombination(attacker, defender)) {
                typeBonus = 1.2;
            }
            else {typeBonus = 1.0;}

            return typeBonus;
        }




    }
}