namespace source
{
    public class Mario: Character
    {
          public Mario() {                
                name = "Mario";
                attackBehavior = new FireFlowerAttack();
                }

               public string GetCharacterStats() {
            return $"Name: {name}, Max Power: {maxPower}, Health: {health}, Attack Strength: {attackStrength}, Defense Power: {defensePower} Attack Behavior ";  }
        
    }
}


    