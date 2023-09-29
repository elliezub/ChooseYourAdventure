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
    Console.WriteLine();
    Console.WriteLine($"Welcome, {player.Name}! Your adventure begins...");
    Console.Beep();
    Village();
}

void Village()
{
    Console.WriteLine();
    Console.WriteLine("In the village you have grown tired of your mundane life.");
    Console.WriteLine();
    Console.WriteLine("Hearing the tales of your elders, you decide to have an adventure of your own.");
    Console.WriteLine();
    Console.WriteLine("You see two paths ahead one leading to the forest and one leading to the beach. Do you:");
    Console.WriteLine();
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
            Console.WriteLine();
            Console.WriteLine("Invalid choice.");
            Village();
            break;
    }
}

void Beach()
{
    Console.WriteLine();
    Console.WriteLine("As you walk along the shoreline you spot a ship on the horizon.");
    Console.WriteLine();
    Console.WriteLine("As its black sails billow in the wind, suddenly the once sunny day begins to turn dark.");
    Console.WriteLine();
    Console.WriteLine("You realize the ship is getting uncomfortably close and the the people...");
    Console.WriteLine("no, the pirates on board are pointing in your direction!");
    Console.WriteLine();
    Console.WriteLine($"What will you do, {player.Name}?");
    Console.WriteLine();
    Console.WriteLine("1) Stand your ground and confront them");
    Console.WriteLine("2) Run away into the nearby forest");

    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            player.AddBraveryPoints(15);
            Console.WriteLine();
            Console.WriteLine($"You decide to stand your ground, {player.Name}. You have shown true bravery, but what will become of you?!");
            ChallengePirates();
            break;
        case 2:
            Console.WriteLine();
            Console.WriteLine($"You've decided to run into the forest, {player.Name}. Hopefully the pirates won't be able to find you here!");
            Forest();
            break;
        default:
            Console.WriteLine();
            Console.WriteLine("Invalid choice.");
            Beach();
            break;
    }
}

void Forest()
{
    Console.WriteLine();
    Console.WriteLine("As you venture into the forest, you begin to hear an unusual sound.");
    Console.WriteLine();
    Console.WriteLine("Following it, you discover a small clearing. In the center, you're surprised to find a baby dragon with an injured wing.");
    Console.WriteLine();
    Console.WriteLine("It looks up, showing a mix of curiosity and concern.");
    Console.WriteLine();
    Console.WriteLine($"What will you do, {player.Name}?");
    Console.WriteLine();
    Console.WriteLine("1) Offer to help the dragon");
    Console.WriteLine("2) Capture the dragon so you can sell it on the black market");
    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            player.AddKindnessPoints(15);
            Console.WriteLine();
            Console.WriteLine("You approach the dragon gently, tending to its injured wing.");
            Console.WriteLine();
            Console.WriteLine("Over time, a bond of trust forms between the two of you.");
            becomeDragonFriend();
            break;
        case 2:
            player.AddEvilPoints(70);
            player.DecreaseHealth(100);
            Console.WriteLine();
            Console.WriteLine("Driven by greed, you attempt to capture the dragon.");
            Console.WriteLine();
            Console.WriteLine("It fiercely defends itself with a burst of flame, bringing your adventurous journey to an untimely end.");
            End();
            break;
        default:
            Console.WriteLine();
            Console.WriteLine("Invalid choice.");
            Forest();
            break;
    }
}

// dragon path
void becomeDragonFriend()
{
    Console.WriteLine();
    Console.WriteLine("Having mended its wing, your friendship with the dragon grows.");
    Console.WriteLine();
    Console.WriteLine("As the days pass, it regains its strength and takes to the skies.");
    Console.WriteLine();
    Console.WriteLine("One special evening, the dragon, with a gentle nudge, invites you to explore its mystical homeland.");
    Console.WriteLine();
    Console.WriteLine($"What's next, {player.Name}?");
    Console.WriteLine();
    Console.WriteLine("1) Accept the dragon's invitation");
    Console.WriteLine("2) Decline, you've had enough adventure in this lifetime and want to go back home");

    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            player.AddBraveryPoints(15);
            player.AddKindnessPoints(15);
            joinedTheDragons = true;
            visitDragonLand();
            break;
        case 2:
            player.AddKindnessPoints(15);
            Console.WriteLine();
            Console.WriteLine("Before parting ways, the dragon pauses and lets out a soft, melodic hum. From its scales, it gently plucks a brilliant gemstone that shimmers with an inner fire. It's not just any gemstone, but a dragon's tear - a rare and magical artifact said to possess immense power and wisdom. The dragon places it in your hand, a token of its profound gratitude and a symbol of the bond you two shared.");
            Console.WriteLine("With a final nod and a majestic flap of its wings, the dragon soars into the sky, leaving you with a precious memento and memories that will last a lifetime.");
            Retire();
            break;
        default:
            Console.WriteLine();
            Console.WriteLine("Invalid choice.");
            becomeDragonFriend();
            break;
    }
}

void visitDragonLand()
{
    Console.WriteLine();
    Console.WriteLine("Upon arriving in the dragon land, you're met with awe-inspiring vistas of floating islands and shimmering lakes.");
    Console.WriteLine();
    Console.WriteLine("A grand feast is held in your honor, celebrating your act of kindness towards the young dragon.");
    Console.WriteLine();
    Console.WriteLine("After the festivities, the elders offer you a choice: \nstay and become a part of their world or return to your own with their blessings.");
    Console.WriteLine();
    Console.WriteLine($"What will you do, {player.Name}?");
    Console.WriteLine();
    Console.WriteLine("1) Stay");
    Console.WriteLine("2) Leave");
    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            player.AddBraveryPoints(15);
            player.AddKindnessPoints(35);
            Console.WriteLine();
            Console.WriteLine("Choosing to embrace this otherworldly realm, you make the dragon land your home.");
            Console.WriteLine();
            Console.WriteLine("The dragons, with their timeless wisdom, share secrets of their age-old magic,");
            Console.WriteLine("and you find solace amidst their majestic presence.");
            Console.WriteLine();
            Console.WriteLine("Time has a different pace here. As the years stretch, you live a life of wonder and camaraderie.");
            Console.WriteLine();
            Console.WriteLine("Eventually, amidst these magnificent creatures and the beauty of their realm,");
            Console.WriteLine("you find a serene resting place, forging a legacy of unity between two worlds.");
            End();
            break;
        case 2:
            player.AddKindnessPoints(15);
            Console.WriteLine();
            Console.WriteLine("With a heavy heart, you decide it's time to return to your village.");
            Console.WriteLine();
            Console.WriteLine("The dragons, understanding your choice, prepare for your departure.");
            Console.WriteLine("Before you leave, they gift you a pendant imbued with the essence of their realm,");
            Console.WriteLine("a symbol of the eternal bond you've shared.");
            Console.WriteLine();
            Console.WriteLine("Riding the dragon that first brought you to this mystical place,");
            Console.WriteLine("you soar through skies painted with dawn's hues, eventually arriving at your village.");
            Retire();
            break;
        default:
            Console.WriteLine();
            Console.WriteLine("Invalid choice.");
            visitDragonLand();
            break;
    }

}



// pirate path
void ChallengePirates()
{
    Console.WriteLine();
    Console.WriteLine("On the beach, as you stand firm, the pirate ship anchors and a rowboat nears the shore. \nA distinctive pirate captain disembarks.");
    Console.WriteLine();
    Console.WriteLine("Captain: \"This is my beach!\" he bellows, throwing a sword to your feet. \"Defend yourself!\"");
    Console.WriteLine();
    Console.WriteLine("You quickly grab the sword, clashing blades with the captain. After a fierce duel, both of you pause, breathless.");
    Console.WriteLine();
    Console.WriteLine("Impressed, the captain smirks, \"You've got skills.\"");
    Console.WriteLine("\"Ever thought of joining a pirate crew?\"");
    Console.WriteLine();
    Console.WriteLine("1) Join the crew");
    Console.WriteLine("2) Refuse to join");

    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            becomeAPirate = true;
            player.AddBraveryPoints(15);
            Console.WriteLine();
            Console.WriteLine($"Captain: \"Well we are happy to have ya, {player.Name}. You are now an honerary member of our crew!");
            EnjoyPirateLife();
            break;
        case 2:
            player.DecreaseHealth(100);
            player.AddKindnessPoints(15);
            Console.WriteLine();
            Console.WriteLine($"The captain's face darkens. \"Very well,\" he says coldly. \"If you won't join us by choice, \nyou can join the depths of the sea. Walk the plank!\"");
            End();
            break;
        default:
            Console.WriteLine();
            Console.WriteLine("Invalid choice.");
            ChallengePirates();
            break;
    }
}


// pirate path
void EnjoyPirateLife() // in progress, will update this path later
{
    //Console.WriteLine("Choosing to join the pirates, you quickly adapt to the tumultuous life on the high seas. Over the years, your bravery, cunning, and leadership abilities shine. You're involved in raids on merchant ships, discovering hidden treasures, and navigating treacherous waters. The crew comes to respect and trust you, often turning to you for guidance during challenging times.");
    //Console.WriteLine("The old captain, a man of fierce reputation but aging quickly, took you under his wing. From him, you learn the intricacies of commanding a ship and leading a crew. You also hear tales of his younger days, the battles he's fought, and the many seas he's sailed.");
    //Console.WriteLine("However, fate has its own plans. During an assault on a heavily fortified merchant ship, the battle grows intense. Cannons roar, muskets fire, and the air is thick with smoke and chaos. Amid the skirmish, the captain leads a boarding party, with you by his side. As both crews clash with steel and fury, an enemy marksman takes aim, and the captain is grievously wounded, sacrificing himself to shield a young crew member from a fatal blow.");
    //Console.WriteLine("The battle is won, but at a heavy cost. As the smoke clears, the crew gathers, mourning the loss of their fearless leader. It's the quartermaster who breaks the silence. \"He was a legend, but he believed in you,\" he says, pointing towards you. \"We've seen your strength, your wisdom, and your bravery. The crew needs a captain. We believe you're the one.\"");
    //Console.WriteLine("Memories of your village, the life you left behind, flood your mind. The streets you once roamed, the faces of childhood friends, the tranquility of a simpler life—they all beckon. But you must make a decision.");
    //Console.WriteLine("1) Become Captain");
    //Console.WriteLine("2) Decide to go back home");

    Console.WriteLine();
    Console.WriteLine("Joining the pirates, you adapt to life on the high seas. Your bravery and cunning make you a trusted leader.\nYou partake in raids, treasure hunts, and navigate dangerous waters.");
    Console.WriteLine();
    Console.WriteLine("The old captain, aging but revered, mentors you. You learn ship command and hear tales of his past.");
    Console.WriteLine();
    Console.WriteLine("During a fierce battle against a merchant ship, the atmosphere is chaotic.\nCannons fire, and amidst the conflict, the captain is fatally wounded protecting a crewmate.");
    Console.WriteLine();
    Console.WriteLine("The crew mourns their leader.");
    Console.WriteLine();
    Console.WriteLine("The quartermaster speaks up, \"He believed in you. We've seen your strength and wisdom. We need a captain, and \nwe believe it's you.\"");
    Console.WriteLine();
    Console.WriteLine("Thoughts of your past life emerge. Memories of home beckon. You face a choice.");
    Console.WriteLine();
    Console.WriteLine("1) Become Captain");
    Console.WriteLine("2) Return home");

    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            player.AddBraveryPoints(35);
            player.AddKindnessPoints(15);
            player.DecreaseHealth(30);
            Console.WriteLine();
            Console.WriteLine($"{player.Name}: \"For the captain, for the crew, I'll lead us to greatness! Let the world remember our name!\"");
            pirateEnding();
            break;
        case 2:
            player.AddKindnessPoints(15);
            Console.WriteLine();
            Console.WriteLine($"{player.Name}: \"I've lived a life on the edge with you all, faced storms and battles. But now, my heart calls me back to the place I once called home.\"");
            Retire();
            break;
        default:
            Console.WriteLine();
            Console.WriteLine("Invalid choice.");
            EnjoyPirateLife();
            break;
    }
}


void pirateEnding()
{
    player.DecreaseHealth(100);
    Console.WriteLine();
    Console.WriteLine("Embracing your new title, you captain your crew through endless high-sea adventures,");
    Console.WriteLine();
    Console.WriteLine("becoming a whispered legend from coast to coast. Years are filled with plunder, freedom, and the unyielding loyalty of \nyour crew.");
    Console.WriteLine();
    Console.WriteLine("However, the unpredictable sea has its own plans. In a final, grand battle against a fearsome rival,");
    Console.WriteLine("with cannons roaring and waves crashing, you meet your fate. \nYour unmatched valor cements your legacy as a legendary pirate.");
    Console.WriteLine();
    End();
}

// general retirement path
void Retire()
{
    if (becomeAPirate)
    {
        Console.WriteLine();
        Console.WriteLine("Returning to your village, it's alive with celebration.");
        Console.WriteLine();
        Console.WriteLine("Your sea adventures have transformed you from villager to legend. Children play as pirates while elders share tales of your bravery.");
        Console.WriteLine();
        Console.WriteLine("The night is festive; surrounded by loved ones, you're the heart of the tales of treasure and daring.");
        Console.WriteLine();
        Console.WriteLine("You're not just an adventurer here; you're a hero.");
    }
    else if (joinedTheDragons)
    {
        Console.WriteLine();
        Console.WriteLine("With the dragon's pendant, you step into the village, now a living myth.");
        Console.WriteLine();
        Console.WriteLine("Elders seek tales from you, and children marvel at your pendant. It's a beacon of dreams and the village's new lore.");
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Your village greets you with unchanged warmth and familiarity.");
        Console.WriteLine();
        Console.WriteLine("Children are eager for tales, and elders appreciate your return. The night is about reconnections and memories.");
        Console.WriteLine();
        Console.WriteLine("The call of adventure was strong, but home has always been where your heart is.");
    }
    End();
}

// default end
void End()
{
    Console.WriteLine();
    Console.WriteLine($"Your adventure ends here, {player.Name}.");
    player.DisplayStats();
}

// player stats
public class Player
{
    public string Name { get; private set; }
    public int Health { get; private set; }
    public int KindnessPoints { get; private set; }
    public int EvilPoints { get; private set; }
    public int BraveryPoints { get; private set; }

    public Player(string name)
    {
        Name = name;
        Health = 100;
        KindnessPoints = 0;
        EvilPoints = 0;
        BraveryPoints = 0;
    }

    public void AddKindnessPoints(int points)
    {
        KindnessPoints += points;
    }

    public void AddEvilPoints(int points)
    {
        EvilPoints += points;
    }

    public void DecreaseHealth(int amount)
    {
        Health -= amount;
        if (Health < 0) Health = 0;
    }

    public void AddBraveryPoints(int points)
    {
        BraveryPoints += points;
    }

    public void DisplayStats() // in progress.. updating stats throughout the game/story
    {
        Console.WriteLine();
        Console.WriteLine($"{Name}'s Final Stats:"); 
        Console.WriteLine($"Health: {Health}");
        Console.WriteLine($"Kindness Points: {KindnessPoints}");
        Console.WriteLine($"Evil Points: {EvilPoints}");
        Console.WriteLine($"Bravery Points: {BraveryPoints}");
    }
}



