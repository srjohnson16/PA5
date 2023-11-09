namespace source
{
    public class Character
    {
        public string name { get; set; }
        public double maxPower { get; set; }
        public double health { get; set; }
        public double attackStrength { get; set; }
        public double defensePower { get; set; }
        public IAttack attackBehavior{get; set;}

        // public string GetAttackName(){
        //     return name;.
        // }
        public Character()
         {
            this.name = null;
            maxPower = new Random().Next(1, 101); 
            health = 100; // Starts at 100
            attackStrength = new Random().Next(1, (int)(maxPower + 1)); // Random number between 1 and MaxPower
            defensePower = new Random().Next(1, (int)(maxPower + 1)); // Random number between 1 and MaxPower
            this.attackBehavior = null;
        }

        public void GetCharacterStats() {
            System.Console.WriteLine($"Name: {name}, Max Power: {maxPower}, Health: {health}, Attack Strength: {attackStrength}, Defense Power: {defensePower} Attack Behavior ");  }

        public void PerformAttack(Character defender)
        {
            // Delegate the attack to the assigned attack behavior
            attackBehavior.PreformAttack(this, defender);
        }


    }
}