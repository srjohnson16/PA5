namespace source
{
    public class Bowser: Character {
        
        public Bowser() {
             name= "Bowser";
             attackBehavior= new PrimatePunchAttack();

             }

               public string GetCharacterStats() {
            return $"Name: {name}, Max Power: {maxPower}, Health: {health}, Attack Strength: {attackStrength}, Defense Power: {defensePower} Attack Behavior ";  }
        
    }
}
  

