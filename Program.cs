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

// dragon path
void becomeDragonFriend()
{
    Console.WriteLine("After tending to the baby dragon's injured wing and spending some time together, a mutual trust and understanding form between the two of you. As months pass, the dragon's strength returns, and it flaps its wings, taking tentative flights around the clearing.");
    Console.WriteLine("One evening, as the sun casts a golden hue over the forest, the dragon approaches you with a gleam in its eyes. With gentle nudges and a series of melodious chirps, it communicates a heartfelt invitation: it wants you to follow it to its homeland, the place where dragons reside.");
    Console.WriteLine($"What will you do, {player.Name}?");
    Console.WriteLine("1) Accept the dragon's invitation");
    Console.WriteLine("2) Decline, you've had enough adventure in this lifetime and want to go back home");
    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            joinedTheDragons = true;
            visitDragonLand();
            break;
        case 2:
            Console.WriteLine("Before parting ways, the dragon pauses and lets out a soft, melodic hum. From its scales, it gently plucks a brilliant gemstone that shimmers with an inner fire. It's not just any gemstone, but a dragon's tear - a rare and magical artifact said to possess immense power and wisdom. The dragon places it in your hand, a token of its profound gratitude and a symbol of the bond you two shared.");
            Console.WriteLine("With a final nod and a majestic flap of its wings, the dragon soars into the sky, leaving you with a precious memento and memories that will last a lifetime.");
            Retire();
            break;
        default:
            Console.WriteLine("Invalid choice.");
            becomeDragonFriend();
            break;
    }
}

void visitDragonLand()
{
    Console.WriteLine("Upon arriving in the dragon land, you're met with awe-inspiring vistas of floating islands and shimmering lakes where dragons roam free. A grand feast is held in your honor, celebrating your act of kindness towards the young dragon. After the festivities, the elders offer you a choice: stay and become a part of their world or return to your own with their blessings.");
    Console.WriteLine($"What will you do, {player.Name}?");
    Console.WriteLine("1) Stay");
    Console.WriteLine("2) Leave");
    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.WriteLine("Choosing to embrace this otherworldly realm, you make the dragon land your home. The dragons, in their timeless wisdom, share secrets of their age-old magic, and you find solace in their majestic presence. Time flows differently here, and as the years stretch on, you live a life filled with wonder and camaraderie. Eventually, surrounded by these magnificent creatures and the beauty of their realm, you find a serene resting place, leaving behind a legacy of unity between two worlds.");
            End();
            break;
        case 2:
            Console.WriteLine("With a heavy heart, you decide it's time to go back to your village. The dragons, respecting your decision, prepare for your departure. Before you leave, they bestow upon you a parting gift: a pendant imbued with the essence of their realm, symbolizing the eternal bond you've forged with them. Riding the same dragon that brought you to this magical land, you traverse skies filled with the hues of dawn, eventually reaching your homeland.");
            Retire();
            break;
        default:
            Console.WriteLine("Invalid choice.");
            visitDragonLand();
            break;
    }

}
