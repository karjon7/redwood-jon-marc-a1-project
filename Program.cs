﻿// (hurts to write code like this)

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

Console.WriteLine("");
Console.WriteLine($"{player_name} awakens on the cold hard ground of a graveyard.");
Console.WriteLine($"{player_name} approaches the front gate but it is guarded by a grotesque creature, {player_name} heads back to the graveyard.");


// Game loop
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

            Console.WriteLine("Heading to the fishing hut.");
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
    }
    else
    {
        Console.WriteLine("Unrecognized Input");
    }
}