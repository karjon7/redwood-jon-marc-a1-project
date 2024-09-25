
bool is_playing = true;

string player_name;
string current_location = "GRAVEYARD";
int fishing_hut_code = 8103;
bool fishing_hut_opened = false;
bool creature_killed = false;

//Inventory
bool has_sword = false;
bool has_forest_hut_key = false;
bool has_graveyard_hut_key = false;
bool has_gate_key = false;


//Intro
Console.WriteLine("What is the name of our protagonist?");

player_name = Console.ReadLine();

Console.WriteLine("");
Console.WriteLine($"{player_name} awakens on the cold hard ground of a graveyard.");
Console.WriteLine($"{player_name} approaches the front gate but it is guarded by a grotesque creature, {player_name} heads back to the graveyard.");


// Game loop
// (hurts to write code like this)
while (is_playing)
{
    Console.WriteLine($"\nWhat does {player_name} do?");
    
    string player_input = Console.ReadLine().ToUpper();

    Console.WriteLine("");

    if (player_input == "QUIT")
    {
        is_playing = false;

        Console.WriteLine("Quitting the Game, thanks for playing!");
    }
    else if (player_input == "HELP")
    {
        Console.WriteLine("Commands:");
        Console.WriteLine("\tQuit: Quits the game");
        Console.WriteLine("\tGo: Choose a location to go to");
        Console.WriteLine("\tSearch: Search the area for items");
        Console.WriteLine("\tInventory: Look at inventory");
    }
    else if (player_input == "GO")
    {
        Console.WriteLine("Go where?");

        player_input = Console.ReadLine().ToUpper();

        Console.WriteLine("");

        if (player_input == current_location)
        {
            Console.WriteLine("You are already at this location.");
        }
        else if (player_input == "GRAVEYARD")
        {
            current_location = player_input;

            Console.WriteLine("Heading to the graveyard.");
        }
        else if (player_input == "GRAVEYARD HUT")
        {
            if (has_graveyard_hut_key)
            {
                current_location = player_input;

                Console.WriteLine("Heading to the graveyard hut.");
            }
            else
            {
                Console.WriteLine("The graveyard hut is locked, I need to find the 'GRAVEYARD HUT KEY'.");
            }
        }
        else if (player_input == "GATE")
        {
            if (creature_killed == true && has_gate_key)
            {
                Console.WriteLine($"{player_name} uses the gate key and escapes! Great job!");
                Console.WriteLine($"Thanks for playing!");
                is_playing = false;
            }
            else if (creature_killed == false && has_sword && has_gate_key)
            {
                Console.WriteLine($"{player_name} uses the sword and slays the creature and escapes! Great job!");
                Console.WriteLine($"Thanks for playing!");
                creature_killed = true;
                is_playing = false;
            }
            else if (creature_killed == false && has_sword && has_gate_key == false)
            {
                Console.WriteLine($"{player_name} uses the sword and slays the creature!");
                Console.WriteLine($"But they still need to find the key to escape.");
                creature_killed = true;
            }
            else if (creature_killed == true && has_gate_key == false) 
            {
                Console.WriteLine($"{player_name} can't go to the gate, it's still locked.");
            }
            else
            {
                Console.WriteLine($"{player_name} can't go to the gate, the creature is still there.");
            }
        }
        else if (player_input == "FOREST")
        {
            current_location = player_input;

            Console.WriteLine("Heading to the forest.");
        }
        else if (player_input == "FOREST HUT")
        {
            if (has_forest_hut_key)
            {
                current_location = player_input;

                Console.WriteLine("Heading to the forest hut.");
            }
            else
            {
                Console.WriteLine("The forest hut is locked, I need to find the 'FOREST HUT KEY'.");
            }
            
        }
        else if (player_input == "FISHING HUT")
        {
            if (fishing_hut_opened == false)
            {
                Console.WriteLine("\nThe fishing hut requires a code to be entered to open it.");
                Console.WriteLine("What is the code:");
                
                player_input = Console.ReadLine();

                if (int.Parse(player_input) == fishing_hut_code)
                {
                    fishing_hut_opened = true;
                    Console.WriteLine("The hut is now opened.");

                    current_location = "FISHING HUT";

                    Console.WriteLine("Heading to the fishing hut.");
                }
                else
                {
                    Console.WriteLine("Incorrect code.");
                }
            }
            else
            {
                current_location = player_input;

                Console.WriteLine("Heading to the fishing hut.");
            }
        }
        else
        {
            Console.WriteLine("Not a valid location.");
        }
    }
    else if (player_input == "LOOK")
    {
        Console.WriteLine($"{player_name} looks around the area");

        if (current_location == "GRAVEYARD")
        {
            Console.WriteLine($"{player_name} sees that they are in a errie foggy cemetary filled with rubble and destroyed tombstones.");
            Console.WriteLine($"Coldness settles on {player_name}'s skin like a heavy blanket.");
            Console.WriteLine($"{player_name} sees the 'GATE', a 'FOREST', aswell as a 'GRAVEYARD HUT' they can go to.");
        }
        else if (current_location == "GRAVEYARD HUT")
        {
            Console.WriteLine($"{player_name} examinzes the dingy, run down structure of the hut.");
            Console.WriteLine($"{player_name} feels a small sense of comfort inside but its accompanied with dread of the idea of going back outside.");
            Console.WriteLine($"From inside the hut, {player_name} sees the 'GRAVEYARD' they can go to.");
        }
        else if (current_location == "FOREST")
        {
            Console.WriteLine($"{player_name} looks up at the tall towering evergreen trees slowly sway in the gentle wind.");
            Console.WriteLine($"The blanketing of the trees give {player_name} a sense of fleeting warmth.");
            Console.WriteLine($"Peering through the trees, {player_name} sees the 'GRAVEYARD', 'FOREST HUT, and 'FISHING HUT' they can go to.");
        }
        else if (current_location == "FOREST HUT")
        {
            Console.WriteLine($"{player_name} wanders through the cozy, cabin-like hut. It seems someone was here recently.");
            Console.WriteLine($"A small fire flickers in a small fireplace, casting a warm, shifting glow over the room.");
            Console.WriteLine($"The warm light makes {player_name} relax.");
            Console.WriteLine($"From inside the hut, {player_name} sees the 'FOREST' surrounding the hut they can go to.");
        }
        else if (current_location == "FISHING HUT")
        {
            Console.WriteLine($"{player_name} looks over a still lake from inside the hut with mist wisping of the surface of the water.");
            Console.WriteLine($"The sorrounding fog is so dense {player_name} cannot see the other side.");
            Console.WriteLine($"Looking back through a window on the opposing side, {player_name} sees the 'FOREST' they can go back to.");
        }
        else
        {
            Console.WriteLine("Not much to see here.");
        }
    }
    else if (player_input == "SEARCH")
    {
        if (current_location == "GRAVEYARD")
        {
            Console.WriteLine($"Looking around the graveyard, {player_name} finds a code but unsure what for.");
            Console.WriteLine($"The code is: {fishing_hut_code}");
        }
        else if (current_location == "FOREST" && has_graveyard_hut_key == false)
        {
            Console.WriteLine($"Looking around the forest, {player_name} finds a key for the graveyard hut.");
            Console.WriteLine($"Key added to inventory.");
            has_graveyard_hut_key = true;
        }
        else if (current_location == "GRAVEYARD HUT" && has_forest_hut_key == false)
        {
            Console.WriteLine($"Looking around the graveyard hut, {player_name} finds a key for the forest hut.");
            Console.WriteLine($"Key added to inventory.");
            has_forest_hut_key = true;
        }
        else if (current_location == "FOREST HUT" && has_sword == false)
        {
             Console.WriteLine($"Looking around the forest hut, {player_name} finds a sword to slay the creature at the gate.");
             Console.WriteLine($"Sword added to inventory.");
             has_sword = true;
        }
        else if (current_location == "FISHING HUT" && has_gate_key == false)
        {
            Console.WriteLine($"Looking around the fishing hut, {player_name} finds a key to open the gate and escape!");
            Console.WriteLine($"Key added to inventory.");
            has_gate_key = true;
        }
        else
        {
            Console.WriteLine($"{player_name} searched the area and found nothing.");
        }
    }
    else if (player_input == "INVENTORY")
    {
        Console.WriteLine("You have:");

        if (has_sword)
        {
            Console.WriteLine("\tSword");
        }
        
        if (has_forest_hut_key)
        {
            Console.WriteLine("\tForest Hut Key");
        }
        
        if (has_graveyard_hut_key)
        {
            Console.WriteLine("\tGraveyard Hut Key");
        }
        
        if (has_gate_key)
        {
            Console.WriteLine("\tGate Key");
        }
    }
    else
    {
        Console.WriteLine("Unrecognized Input");
    }
}