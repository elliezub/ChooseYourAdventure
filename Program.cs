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



// pirate path
void ChallengePirates()
{
    Console.WriteLine("As you stand your ground on the beach, the pirate ship comes to a halt, and a rowboat swiftly approaches the shore. A tall figure with a rugged beard, wearing a feathered hat, disembarks with a few of his crew. This is unmistakably the pirate captain.");
    Console.WriteLine("Captain:\"Why are you treading on my beach, landlubber?\" he bellows, his voice echoing across the shoreline. Before you can muster a response, he tosses a sword at your feet. \"Pick it up! Let's see if you can defend your right to be here.\"");
    Console.WriteLine("Without hesitation, you pick up the sword, and the two of you lock into a fierce duel. Your blades clash, and with every move, you hold your ground against the captain. After an intense standoff, the two of you pause, catching your breath.");
    Console.WriteLine("Impressed, the captain smirks, \"You've got skills. Ever thought of joining a pirate crew?\"");
    Console.WriteLine("1) Join the crew");
    Console.WriteLine("2) Refuse to join");
    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            becomeAPirate = true;
            Console.WriteLine($"Captain: \"Well we are happy to have ya, {player.Name}. You are now an honerary member of our crew!");
            EnjoyPirateLife();
            break;
        case 2:
            Console.WriteLine($"The captain's face darkens. \"Very well,\" he says coldly. \"If you won't join us by choice, you can join the depths of the sea. Walk the plank!\"");
            End();
            break;
        default:
            Console.WriteLine("Invalid choice.");
            ChallengePirates();
            break;
    }
}


// pirate path
void EnjoyPirateLife() // in progress, will update this path later
{
    Console.WriteLine("Choosing to join the pirates, you quickly adapt to the tumultuous life on the high seas. Over the years, your bravery, cunning, and leadership abilities shine. You're involved in raids on merchant ships, discovering hidden treasures, and navigating treacherous waters. The crew comes to respect and trust you, often turning to you for guidance during challenging times.");
    Console.WriteLine("The old captain, a man of fierce reputation but aging quickly, took you under his wing. From him, you learn the intricacies of commanding a ship and leading a crew. You also hear tales of his younger days, the battles he's fought, and the many seas he's sailed.");
    Console.WriteLine("However, fate has its own plans. During an assault on a heavily fortified merchant ship, the battle grows intense. Cannons roar, muskets fire, and the air is thick with smoke and chaos. Amid the skirmish, the captain leads a boarding party, with you by his side. As both crews clash with steel and fury, an enemy marksman takes aim, and the captain is grievously wounded, sacrificing himself to shield a young crew member from a fatal blow.");
    Console.WriteLine("The battle is won, but at a heavy cost. As the smoke clears, the crew gathers, mourning the loss of their fearless leader. It's the quartermaster who breaks the silence. \"He was a legend, but he believed in you,\" he says, pointing towards you. \"We've seen your strength, your wisdom, and your bravery. The crew needs a captain. We believe you're the one.\"");
    Console.WriteLine("Memories of your village, the life you left behind, flood your mind. The streets you once roamed, the faces of childhood friends, the tranquility of a simpler life—they all beckon. But you must make a decision.");
    Console.WriteLine("1) Become Captain");
    Console.WriteLine("2) Decide to go back home");
    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.WriteLine($"{player.Name}: \"For the captain, for the crew, I'll lead us to greatness! Let the world remember our name!\"");
            pirateEnding();
            break;
        case 2:
            Console.WriteLine($"{player.Name}: \"I've lived a life on the edge with you all, faced storms and battles. But now, my heart calls me back to the place I once called home.\"");
            Retire();
            break;
        default:
            Console.WriteLine("Invalid choice.");
            EnjoyPirateLife();
            break;
    }
}


void pirateEnding()
{
    Console.WriteLine("Embracing the title of captain, you steer your crew through countless adventures on the high seas, becoming a legend whispered about in every corner of the world. The years are marked with plunder, freedom, and the fierce loyalty of your crew. Yet, the unpredictable nature of the sea eventually catches up. In a climactic battle against a formidable rival, amidst roaring cannons and raging waves, you meet your end with unparalleled valor, sealing your legacy as one of the most revered pirates in history.");
    End();
}

// general retirement path
void Retire()
{
    if (becomeAPirate)
    {
        Console.WriteLine("As you step foot into your village, a surprising sight greets you. Flags flutter in the breeze, children run around with makeshift wooden swords pretending to be pirates, and the sound of celebratory drums fills the air.");
        Console.WriteLine("Word of your exploits on the high seas has reached the village long before you did. While you were a pirate on the seas, here, you are a legend. Elders speak of your bravery, and youngsters aspire to have adventures like yours.");
        Console.WriteLine("Familiar faces approach, embracing you and laughing. They've prepared a feast in your honor. As the night falls, you're surrounded by friends and family, sharing tales of the open sea, treasures, and daring escapes.");
        Console.WriteLine("While you left as an adventurer, you returned as a hero.");
    }
    else if (joinedTheDragons)
    {
        Console.WriteLine("As you step foot into your village, holding the dragon's pendant close to your heart, the atmosphere is electric. Your dramatic exit and even more astonishing return on the back of a dragon have turned you into a living legend.");
        Console.WriteLine("Elders, who once shared stories of faraway places and magical creatures, now turn to you for tales of the dragon land. Young ones gaze at the pendant in awe, dreaming of their own adventures. The pendant serves not just as a memento of your journey, but also as a beacon of hope and wonder, forever changing the fabric of stories in your village.");
    }
    else
    {
        Console.WriteLine("As you make your way into the village, you're met with warm smiles and tight embraces. The life you left behind seems unchanged, like a preserved memory.");
        Console.WriteLine("Children, curious and excited, gather around, eager to hear stories from the world beyond. Elders nod in appreciation, respecting your choice to return to your roots.");
        Console.WriteLine("The night is filled with nostalgia as you reconnect with old friends, reminisce about shared memories, and make plans for the future.");
        Console.WriteLine("While the seas might have called to you, home is where your heart truly lies.");
    }
    End();
}

// default end
void End()
{
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
        Console.WriteLine($"{Name}'s Final Stats:"); 
        Console.WriteLine($"Health: {Health}");
        Console.WriteLine($"Kindness Points: {KindnessPoints}");
        Console.WriteLine($"Evil Points: {EvilPoints}");
    }
}



