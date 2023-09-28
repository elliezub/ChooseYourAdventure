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

void Beach()
{
    Console.WriteLine("As you walk along the shoreline you spot a ship on the horizon. As its black sails billow in the wind, suddenly the once sunny day begins to turn dark. You realize the ship is getting uncomfortably close and the the people... no, the pirates on board are pointing in your direction!");
    Console.WriteLine($"What will you do, {player.Name}?");
    Console.WriteLine("1) Stand your ground and confront them");
    Console.WriteLine("2) Run away into the nearby forest");
    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            player.AddBraveryPoints(15);
            Console.WriteLine($"You decide to stand your ground, {player.Name}. You have shown true bravery, but what will become of you?!");
            ChallengePirates();
            break;
        case 2:
            Console.WriteLine($"You've decided to run into the forest, {player.Name}. Hopefully the pirates won't be able to find you here!");
            Forest();
            break;
        default:
            Console.WriteLine("Invalid choice.");
            Beach();
            break;
    }
}

void Forest()
{
    Console.WriteLine("As you venture into the forest, you begin to hear an unusual sound. Following it, you discover a small clearing. In the center, you're surprised to find a baby dragon with an injured wing. It looks up, showing a mix of curiosity and concern");
    Console.WriteLine($"What will you do, {player.Name}?");
    Console.WriteLine("1) Offer to help the dragon");
    Console.WriteLine("2) Capture the dragon so you can sell it on the black market");
    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            player.AddKindnessPoints(15);
            Console.WriteLine($"You slowly approach, extending a hand to show you mean no harm. At first, the dragon pulls back, hesitant and wary. But sensing your genuine intent, it allows you to come closer. With patience and care, you manage to tend to its injured wing using some herbs and bandages.");
            becomeDragonFriend();
            break;
        case 2:
            Console.WriteLine($"Seeing an opportunity for riches, you attempt to capture the young dragon. But looks can be deceiving. Despite its size, it's fierce and full of fire. In a swift motion, the dragon releases a burst of flame, engulfing the surroundings. You realize your grave mistake too late as the inferno consumes you, ending your journey abruptly in the heart of the forest.");
            End();
            break;
        default:
            Console.WriteLine("Invalid choice.");
            Forest();
            break;
    }
}

