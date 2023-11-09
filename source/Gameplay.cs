namespace source
{
    public class Gameplay
    {
            
        public void ShowMenu()
        {
            Console.Clear();
            while (true)
            {
             Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                System.Console.WriteLine("Welcome to SUper Mario Bros (Tip: Turn on sound!)");
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
                Console.ResetColor();  
                        Console.WriteLine("Choose an attacker:");
                        Character attacker = ChooseCharacter();
                        
                        Console.WriteLine("Choose a defender:");
                        Character defender = ChooseCharacter();

                        Battle(attacker, defender);
                        break;

                    case 2:
                    Console.ResetColor();  
                        // Display all character stats
                        DisplayCharacterStats(new Mario());
                        DisplayCharacterStats(new Bowser());
                        DisplayCharacterStats(new DonkeyKong());
                        break;

                    case 3:
                    Console.ResetColor();  
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
                Console.ResetColor();
    }
}
   
public Character ChooseCharacter() {


            Console.Clear();
            Console.WriteLine("*******************************");
            Console.WriteLine("          SUPER BATTLE         ");
            Console.WriteLine("*******************************");
            Console.WriteLine("1. \u001b[32mMario\u001b[0m"); 
            System.Console.WriteLine(@"   _____               .__        
  /     \ _____ _______|__| ____  
 /  \ /  \\__  \\_  __ \  |/  _ \ 
/    Y    \/ __ \|  | \/  (  <_> )
\____|__  (____  /__|  |__|\____/ 
        \/     \/                 ");
            Console.WriteLine("2. \u001b[31mBowser\u001b[0m"); 
            System.Console.WriteLine(@"__________                                  
\______   \ ______  _  ________ ___________ 
 |    |  _//  _ \ \/ \/ /  ___// __ \_  __ \
 |    |   (  <_> )     /\___ \\  ___/|  | \/
 |______  /\____/ \/\_//____  >\___  >__|   
        \/                  \/     \/    ");
            Console.WriteLine("3. \u001b[33mDonkey Kong\u001b[0m"); 
            System.Console.WriteLine(@"________                 __                   ____  __.                     
\______ \   ____   ____ |  | __ ____ ___.__. |    |/ _|____   ____    ____  
 |    |  \ /  _ \ /    \|  |/ // __ <   |  | |      < /  _ \ /    \  / ___\ 
 |    `   (  <_> )   |  \    <\  ___/\___  | |    |  (  <_> )   |  \/ /_/  >
/_______  /\____/|___|  /__|_ \\___  > ____| |____|__ \____/|___|  /\___  / 
        \/            \/     \/    \/\/              \/          \//_____/");
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

public static void StickmanAnimation()
{
    Console.WriteLine("Battle Start!");
    Console.WriteLine();

    for (int i = 0; i < 3; i++)
    {
        Console.Clear();

        Console.WriteLine("  O  ");
        Console.WriteLine(" /|\\ ");
        Console.WriteLine(" / \\ ");
        Console.WriteLine();

        System.Threading.Thread.Sleep(500);

        Console.Clear();

        Console.WriteLine(" \\O/ ");
        Console.WriteLine("  |  ");
        Console.WriteLine(" / \\ ");
        Console.WriteLine();

        System.Threading.Thread.Sleep(500);
    }

    Console.Clear();
    Console.WriteLine("Battle Over!");
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

                StickmanAnimation();

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
