// Create Player
Console.WriteLine("Enter your name:");
string playerName = Console.ReadLine();
Player player = new Player(playerName);


// Initial Game Values
bool joinedTheDragons = false;
bool becomeAPirate = false;


Start();

void Start()
{
    Console.WriteLine($"Welcome, {player.Name}! Your adventure begins...");
    Console.Beep();
    Village();
}

void Village()
{
    Console.WriteLine("In the village you have grown tired of your mundane life. As you've read in storybooks you decide to have an adventure of your own. You see two paths ahead one leading to the forest and one leading to the beach. Do you:");
    Console.WriteLine("1) Go to the beach");
    Console.WriteLine("2) Go to the forest");
    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Beach();
            break;
        case 2:
            Forest();
            break;
        default:
            Console.WriteLine("Invalid choice.");
            Village();
            break;
    }
}
