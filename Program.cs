// (hurts to write code like this)

bool is_playing = true;

string player_name;
string current_location = "GRAVEYARD";

//Inventory
bool has_forest_hut_key = false;
bool has_fishing_hut_key = false;
bool has_graveyard_hut_key = false;


//Intro
Console.WriteLine("What is the name of our protagonist?");

player_name = Console.ReadLine();

Console.WriteLine($"{player_name} awakens on the cold hard ground of a graveyard.");
Console.WriteLine($"{player_name} approaches the front gate but it is guarded by a grotesque creature, they head back to the graveyard.");


// Game loop
while (is_playing)
{
    Console.WriteLine($"\nWhat does {player_name} do?");
    
    string player_input = Console.ReadLine().ToUpper();

    if (player_input == "QUIT")
    {
        is_playing = false;

        Console.WriteLine("Quitting the Game, thanks for playing!");
    } 
    else if (player_input == "GO")
    {
        Console.WriteLine("Go where?");
        player_input = Console.ReadLine().ToUpper();

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
            current_location = player_input;

            Console.WriteLine("Heading to the graveyard hut.");
        }
        else if (player_input == "GATE")
        {
            current_location = player_input;

            Console.WriteLine("Heading to the gate.");
        }
        else if (player_input == "FOREST")
        {
            current_location = player_input;

            Console.WriteLine("Heading to the forest.");
        }
        else if (player_input == "FOREST HUT")
        {
            current_location = player_input;

            Console.WriteLine("Heading to the forest hut.");
        }
        else if (player_input == "FISHING HUT")
        {
            current_location = player_input;

            Console.WriteLine("Heading to the forest.");
        } 
        else
        {
            Console.WriteLine("Not a valid location.");
        }
    }
    else
    {
        Console.WriteLine("Unrecognized Input");
    }
}