namespace source
{
    public class DonkeyKong: Character
    {

        public DonkeyKong(){
            name ="Donkey Kong";
            attackBehavior= new PrimatePunchAttack();
            }
            

 
               public string GetCharacterStats() {
            return $"Name: {name}, Max Power: {maxPower}, Health: {health}, Attack Strength: {attackStrength}, Defense Power: {defensePower} Attack Behavior ";  }
        
            }        
    
}
