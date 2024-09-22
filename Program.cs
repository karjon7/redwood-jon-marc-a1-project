// (hurts to write code like this)

bool is_playing = true;

string player_name;
string current_location;

//Inventory
bool has_forest_hut_key = false;
bool has_fishing_hut_key = false;
bool has_graveyard_hut_key = false;


//Intro
Console.WriteLine("What is the name of our protagonist?");

player_name = Console.ReadLine();

Console.WriteLine($"{player_name} awakens on the cold hard ground of a graveyard.");
Console.WriteLine($"{player_name} approaches the front gate but it is guarded by a grotesque creature.");


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
    else
    {
        Console.WriteLine("Unrecognized Input");
    }
}