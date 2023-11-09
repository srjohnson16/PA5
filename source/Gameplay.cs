// namespace source
// {
//     public class Gameplay
//     {
//         public  void Battle(Character attacker, Character defender)
//         {
//             //System.Console.WriteLine("In Gameplay class!!");
//             System.Console.WriteLine($"Attacker: {attacker.name} and Defender: {defender.name} are battling");

//             //display stats
//             attacker.GetCharacterStats();
//             defender.GetCharacterStats();

//             while (attacker.health > 0 && defender.health > 0)
//             {
//                 // Attacker's turn
//                 attacker.PerformAttack(defender);

//                 // Check if defender is still alive
//                 if (defender.health <= 0)
//                 {
//                     System.Console.WriteLine($"{defender.name} has been defeated!");
//                     break;
//                 }

//                 // Switch roles for the next round
//                 Character temp = attacker;
//                 attacker = defender;
//                 defender = temp;
//             }

//             System.Console.WriteLine($"{attacker.name} wins the battle!");
//             attacker.GetCharacterStats();
//             defender.GetCharacterStats();

//             Console.Beep();
//         }
//     }
// }


using System.Xml.Serialization;

namespace source
{
    public class Gameplay
    {
       
 public void ShowMenu()
{
    while (true)
    {
        
        System.Console.WriteLine("Welcom to SUper Matio Bros (Tip: Turn on sound!)");
        System.Console.WriteLine("1. Battle");
        System.Console.WriteLine("2. Display All Character Stats");
        System.Console.WriteLine("3. View Gameplay Rules");
        System.Console.WriteLine("4. Exit");
        System.Console.Write("Choose an option: ");

        int choice;
        if (!int.TryParse(System.Console.ReadLine(), out choice))
        {
            System.Console.WriteLine("Invalid input. Please enter a number.");
            continue;
        }

        switch (choice)
        {
            case 1:
           // Battle option
                Console.WriteLine("Choose an attacker:");
                Character attacker = ChooseCharacter();
                
                Console.WriteLine("Choose a defender:");
                Character defender = ChooseCharacter();

                Battle(attacker, defender);
                break;

            case 2:
                // Display all character stats
                DisplayCharacterStats(new Mario());
                DisplayCharacterStats(new Bowser());
                DisplayCharacterStats(new DonkeyKong());
                break;

            case 3:
                // View Gameplay Rules
                DisplayGameplayRules();
                break;

            case 4:
                System.Environment.Exit(0);
                break;

            default:
                System.Console.WriteLine("Invalid option. Please choose again.");
                break;
        }
    }
}
   
public Character ChooseCharacter() {


            Console.Clear();
            Console.WriteLine("*******************************");
            Console.WriteLine("          SUPER BATTLE         ");
            Console.WriteLine("*******************************");
            Console.WriteLine("1. \u001b[32mMario\u001b[0m"); 
            Console.WriteLine("2. \u001b[31mBowser\u001b[0m"); 
            Console.WriteLine("3. \u001b[33mDonkey Kong\u001b[0m"); 
            Console.WriteLine("4. Exit");
            Console.WriteLine("*******************************");
            Console.Write("Choose your character: ");

    int characterChoice;
    while (!int.TryParse(System.Console.ReadLine(), out characterChoice) || characterChoice < 1 || characterChoice > 3)
    {
        System.Console.WriteLine("Invalid choice. Please enter a valid number.");
        System.Console.Write("Choose a character: ");
    }

    switch (characterChoice)
    {
        case 1:
            return new Mario();

        case 2:
            return new Bowser();

        case 3:
            return new DonkeyKong();

        default:
            return null;
    }
}
      
        public void Battle(Character attacker, Character defender)
        {
            System.Console.WriteLine($"Attacker: {attacker.name} and Defender: {defender.name} are battling");

            // display stats
            attacker.GetCharacterStats();
            defender.GetCharacterStats();

            while (attacker.health > 0 && defender.health > 0)
            {
                // Attacker's turn
                attacker.PerformAttack(defender);

                // Check if defender is still alive
                if (defender.health <= 0)
                {
                    System.Console.WriteLine($"{defender.name} has been defeated!");
                    break;
                }

                // Switch roles for the next round
                Character temp = attacker;
                attacker = defender;
                defender = temp;
            }

            System.Console.WriteLine($"{attacker.name} wins the battle!");
            attacker.GetCharacterStats();
            defender.GetCharacterStats();

            Console.Beep();
        }

        private void DisplayCharacterStats(Character character)
        {
            System.Console.WriteLine($"=== {character.name} Stats ===");
            character.GetCharacterStats();
            System.Console.WriteLine("=======================");
        }

        private void DisplayGameplayRules()
        {
            System.Console.WriteLine("=== Gameplay Rules ===");
            System.Console.WriteLine("1. Choose your attacker and defender.");
            System.Console.WriteLine("2. Characters take turns attacking and defending until one wins.");
            System.Console.WriteLine("3. Each attack is based on the character's attack behavior and type bonus.");
            System.Console.WriteLine("4. Special combinations (e.g., Mario vs. Bowser) get a type bonus.");
            System.Console.WriteLine("5. Enjoy the battle and have fun!");
            System.Console.WriteLine("=====================");
        }
    }
}
