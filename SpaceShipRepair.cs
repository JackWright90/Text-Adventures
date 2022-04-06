/**********************************************************************************************************

                                                Space Ship Repair
                                                 by Jackie Wright
                                                   CSC 240-010
                                                   March 2022
                                                 Assignment #2
                     
ABOUT THE GAME:
You are the captain of an interstellar merchant vessel transporting goods from one world to another. 
As you were TOTALLY not sleeping with the ship on autopilot you hear a major crash and the as the
ship's main power goes out, the auxillary power kicks in. However, this will only give the ship
roughly 6 hours of life before it is depleted and you are stranded in space forever, so it is
imperative that you find out what caused the crash and fix the engine. You have your trusty
Hrunting with you, a high grade laser pistol, but you might want to grab a bigger gun...

*************************************************************************************************************/

using System;
class SpaceShipRepair 
{
      // Game variables declaration
      public static bool haveGOverload;                    // Verify if the player has the weapon or not.  Defaulted to no/false.
      public static bool haveStimulant;                    // Verify if the player has health power-up or not. Defaulted to no/false.
      public static bool haveEngineRepairKit;              // Verify if the player has key item Engine Repair Kit or not. Defaulted to no/false.
      public static int GOverloadMaxDamage;                // Set the maximum damage of the G-Overload for randomize purposes. Zero being no damage.
      public static int HruntingMaxDamage;                 // Set the maximum damage of the player's pistol. Zero being no damage.
      public static int playerMaxHealth;                   // Set the maximum health of the player.  This also set the level of difficulty of the game.
      public static int playerMinHealth;                   // Set the minimum health of the player. Falling below this level, the player will die.
      public static int playerCurrentHealth;               // Set player's health to be maximum at the start of the game.
      public static int alienPincerDamage;                 // Set the maximum damage of the alien's pincers for randomize purposes. Zero being no damage. 
      public static int alienMaxHealth;                    // Set the maximum health of the alien.  This also set the level of difficulty of the game.
      public static int alienMinHealth;                    // Set the minimum health of the alien. Falling below this level, the alien will die.
      public static int alienCurrentHealth;                // Set alien's health to be maximum at the start of the game.
      public static string[] inventoryList;                // set inventory to have 10 items max.
      public static int currentInventoryCount;             // reset inventory number of items to zero.


    /////////////////////
    // RESET GAME DATA //
    /////////////////////
    static void resetGameData()
    {
        // Reset game data before restarting the game
        haveGOverload = false;                 // Verify if the player has the weapon or not.  Defaulted to no/false.
        haveStimulant = false;                 // Verify if the player has health power-up or not. Defaulted to no/false.
        haveEngineRepairKit = false;           // Verify if the player has key item Engine Repair Kit or not. Defaulted to no/false.
        GOverloadMaxDamage = 28;               // Set the maximum damage of the G-Overload for randomize purposes. Zero being no damage.
        HruntingMaxDamage = 3;                 // Set the maximum damage of the player's pistol. Zero being no damage.
        playerMaxHealth = 60;                  // Set the maximum health of the player.  This also set the level of difficulty of the game.
        playerMinHealth = 0;                   // Set the minimum health of the player. Falling below this level, the player will die.
        playerCurrentHealth = 50;              // Set player's health to be maximum at the start of the game.
        alienPincerDamage = 8;                 // Set the maximum damage of the alien's claws for randomize purposes. Zero being no damage. 
        alienMaxHealth = 60;                   // Set the maximum health of the alien.  This also set the level of difficulty of the game.
        alienMinHealth = 0;                    // Set the minimum health of the alien. Falling below this level, the alien will die.
        alienCurrentHealth = 60;               // Set alien's health to be maximum at the start of the game.
        inventoryList = new string[10];        // set inventory to have 10 items max.
        currentInventoryCount = 0;             // reset inventory number of items to zero.
    }

  //////////////////
  // MAIN PROGRAM //
  //////////////////
  public static void Main() 
  {
    resetGameData();    // This will does a refresh of the game data.
    theIntroduction();  // This will explain about the game to the player.
    theCockpit();       // This is where your character starts out.
  } // End of Main() 
  
  //////////////////////
  // THE INTRODUCTION //
  //////////////////////
  static void theIntroduction()
  {
	Console.Clear(); // This will clear the screen and move the cursor to the top-left of the screen
	Console.ForegroundColor = ConsoleColor.Yellow;
	Console.WriteLine();
	Console.WriteLine("     _______..______      ___       ______  _______     _______. __    __   __  .______  ");
    Console.WriteLine(@"    /       ||   _  \    /   \     /      ||   ____|   /       ||  |  |  | |  | |   _  \  ");
    Console.WriteLine(@"   |   (----`|  |_)  |  /  ^  \   |  ,----'|  |__     |   (----`|  |__|  | |  | |  |_)  | ");
    Console.WriteLine(@"    \   \    |   ___/  /  /_\  \  |  |     |   __|     \   \    |   __   | |  | |   ___/  ");
    Console.WriteLine(@".----)   |   |  |     /  _____  \ |  `----.|  |____.----)   |   |  |  |  | |  | |  |      ");  
    Console.WriteLine(@"|_______/    | _|    /__/     \__\ \______||_______|_______/    |__|  |__| |__| | _|      ");
    Console.WriteLine("\n");                                                                                   
    Console.WriteLine(".______       _______ .______      ___       __  .______          ");                        
    Console.WriteLine(@"|   _  \     |   ____||   _  \    /   \     |  | |   _  \            ");                     
    Console.WriteLine(@"|  |_)  |    |  |__   |  |_)  |  /  ^  \    |  | |  |_)  |         ");                       
    Console.WriteLine(@"|      /     |   __|  |   ___/  /  /_\  \   |  | |      /             ");                    
    Console.WriteLine(@"|  |\  \----.|  |____ |  |     /  _____  \  |  | |  |\  \----.          ");                  
    Console.WriteLine(@"| _| `._____||_______|| _|    /__/     \__\ |__| | _| `._____|           ");   
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("\n"); 
	Console.WriteLine("by Jackie Wright");  
	Console.WriteLine("CSC 240-010");  	
	Console.WriteLine("Assignment #2");  
	Console.WriteLine();
	Console.WriteLine("---------------------------------------------------------------------------------------------------------");  	
	Console.WriteLine("ABOUT THE GAME:");
	Console.WriteLine("You are the captain of an interstellar merchant vessel transporting goods from one world to another.");
	Console.WriteLine("As you were TOTALLY not sleeping with the ship on autopilot you hear a major crash and the as the");
	Console.WriteLine("ship's main power goes out, the auxillary power kicks in. However, this will only give the ship"); 
	Console.WriteLine("roughly 6 hours of life before it is depleted and you are stranded in space forever, so it is");
	Console.WriteLine("imperative that you find out what caused the crash and fix the engine. You have your trusty");
	Console.WriteLine("Hrunting with you, a high grade laser pistol, but you might want to grab a bigger gun...");
	Console.WriteLine("\nPossible commands: directions (N,S,E,W,NE,NW,SE,SW), take <item>, I/inventory, attack, and others.");
	Console.WriteLine("---------------------------------------------------------------------------------------------------------");  	
	Console.WriteLine();	
    
    // Game rating warning //
	Console.WriteLine("WARNING:");
	Console.WriteLine("This game not rated by the ESRB");

	// Request for the character's name
    Console.Write("Please provide your character's name: ");
    string characterName = Console.ReadLine();
	Console.WriteLine($"\nWelcome {characterName}!");
	
	Console.WriteLine($"\n{characterName},");
	Console.WriteLine("After recovering from the shaking of the ship's crash, you take note of your immediate");
	Console.WriteLine("surroundings to make sure everything is intact.");
	Console.WriteLine("The auxillary power leaves your cockpit dimly lit with an eerie red light. ");
	Console.WriteLine("The only other light comes from the ship's control panel. ");
	Console.WriteLine("\nThe lights give a very faint buzz, but aside from that, there is no sound.");
	Console.WriteLine("You grip your holster containing your laser pistol Hrunting tight as you decide");
	Console.WriteLine("what to do next.");
	Console.WriteLine("\nPress ENTER to continue");
	Console.ReadLine();
  } // End of theIntroduction()
  
  
  /////////////////
  // THE COCKPIT //
  /////////////////
  
  // Describe to the players what the cockpit looks like. //
  static void theCockpitView()
  {
    Console.WriteLine("\n\nThe Cockpit:");
	Console.WriteLine("-----------:");
	Console.WriteLine("You are in the cockpit.  There are red emergency lights on the ceiling giving off a faint buzz and");
	Console.WriteLine("your ship's control panel is the only other light. There are exits leading south-west, south, and south-east...\n");
  } //End of theCockpitView()
  
  // What the players can do when inside the Cockpit. //
  static void theCockpit()
  {
	theCockpitView();

	while (true)
	{
    	Console.Write("\nWhat would you like to do next? ");
    	string playerRespond = Console.ReadLine();
    	switch (playerRespond)
    	{
    	   case "S": case "s": case "go south":
    	        theCrewQuarters();
    	        break;
    	   case "SW": case "sw": case "go south-west":
    	        theCargoBay();
    	        break;
    	   case "SE": case "se": case "go south-east":
    	        theInfirmary();
    	        break;
    	   case "look":
                theCockpitView();
	            break;
  	       case "inventory": case "I": case "i":
	            inventory();
	            break;
    	   default:
    	        Console.WriteLine($"\n''{playerRespond}'' is an invalid command.");
    	        break;
    	} // end Switch
	} // End While
  } // End theCockpit()
  
  
  ///////////////////////
  // THE CREW QUARTERS //
  //////////////////////
    
  // Describe to the players what the crew quarters looks like //
  static void theCrewQuartersView()
  {
    Console.WriteLine("\n\nThe Crew Quarters:");
	Console.WriteLine("---------------:");
	Console.WriteLine("You are in the crew quarters. Your crew seems mostly unharmed, but one informs you");
	Console.WriteLine("that one of the members is injured and needed to go to the infirmary.");
	Console.WriteLine("They all seem too shaken up to be of any other help.");
	Console.WriteLine("There are exits leading north, east, and south.");
  } // End of theCrewQuartersView()
  
  // What the players can do when inside the crew quarters. //
  static void theCrewQuarters()
  {
    theCrewQuartersView();
	
	while (true)
	{
    	Console.Write("\nWhat would you like to do next? ");
    	string playerRespond = Console.ReadLine();
    	switch (playerRespond)
    	{
    	   case "N": case "n": case "go north":
    	        theCockpit();
    	        break;
    	   case "E": case "e": case "go east":
    	        theInfirmary();
    	        break;
    	   case "S": case "s": case "go south":
    	        theCaptainsRoom();
    	        break;
    	   case "look":
                theCrewQuartersView();
	            break;
  	       case "inventory": case "I": case "i":
	            inventory();
	            break;
    	   default:
    	        Console.WriteLine($"\n''{playerRespond}'' is an invalid command.");
    	        break;
    	} 
	}

  }   // End of theCrewQuarters()
  

  ////////////////////
  // THE INFIRMARY //
  //////////////////
  
  // Describe to the players what the infirmary looks like. //
  static void theInfirmaryView()
  {
    Console.WriteLine("\n\nThe Infirmary:");
	Console.WriteLine("-----------:");
	Console.WriteLine("You are in the infirmary. One of your crew members is injured on a treatment table moaning");
	Console.WriteLine("something about pincers while the ship's doctor is treating him. The doctor tells you; ");
	Console.WriteLine("'I have a STIMULANT in the cabinet. Take it if you don't have one already. I think ");
	Console.WriteLine("you'll need it...'");
	Console.Write("There are exits leading west and north-west.\n");
  } // End of theInfirmaryView()
  
  // What the players can do when inside the infirmary. //
  static void theInfirmary()
  {
    theInfirmaryView();
   
 	while (true)
	{
    	Console.Write("\nWhat would you like to do next? ");
    	string playerRespond = Console.ReadLine();
    	switch (playerRespond)
    	{
    	   case "W": case "w": case "go west":
    	        theCrewQuarters();
    	        break;
    	   case "NW": case "nw": case "go north-west":
    	        theCockpit();
    	        break;
    	   case "take stimulant": case "stimulant": case "STIMULANT":
    	        if (haveStimulant==true) //If the empty Stimulant bottle is already in the player's inventory, the player is notified.
    	        {
    	            Console.WriteLine("\nYou look at the empty Stimulant bottle you have pocketed away. Taking another dose can be dangerous...\n");
    	        }
                else // This section will only display once and never again.
                {
                    Console.Write("You open the cabinet and move aside some medicine bottles to take the Stimulant ");  
	                playerMaxHealth+=10;
	                playerCurrentHealth+=10;
	                Console.WriteLine("You use the Stimulant and feel your endurance increase. Max Player Health + 10!");
	                haveStimulant=true;
	                inventoryList[currentInventoryCount]="Stimulant";
                    currentInventoryCount++;
	                // After the player has taken the Stimulant, the section of text will no longer display to the player.
                }
    	        break;
    	   case "look":
    	        theInfirmaryView();
	            break;
  	       case "inventory": case "I": case "i":
	            inventory();
	            break;            
    	   default:
    	        Console.WriteLine($"\n''{playerRespond}'' is an invalid command.");
    	        break;
    	} 
	} // End theInfirmary
  }   // End of theInfirmary()
  
  ////////////////////////
  // THE CAPTAIN'S ROOM //
  ////////////////////////
  
  // Describe to the players what the Captain's room looks like. //
  static void theCaptainsRoomView()
  {
    Console.WriteLine("\n\nThe Captain's Room:");
	Console.WriteLine("-----------:");
    Console.WriteLine("You are in your personal quarters. It looks like a tornado hit it. You assume it was close to the epicenter ");
    Console.WriteLine("of the crash that effected the ship earlier. Your work desk and lounge are both turned over, as well as a CHEST ");
    Console.WriteLine("containing your effects, now spilled on the floor.");
    Console.Write("There is an exit to the north.\n");
  } // End of theCaptainsRoomView()
  
  // What the players can do when inside the Captain's room. //
  static void theCaptainsRoom()
  {
    theCaptainsRoomView();
 	while (true)
	{
    	Console.Write("\nWhat would you like to do next? ");
    	string playerRespond = Console.ReadLine();
    	switch (playerRespond)
    	{
    	   case "N": case "n": case "go north":
    	        theCrewQuarters();
    	        break;
    	   case "CHEST": case "check chest": case "chest": case "check":
    	        if (haveGOverload==true) // If the chest has already been checked, the narrative informs the player.
    	        {
    	            Console.WriteLine("\nThere doesn't seem to be anything else of use here.\n");
    	        }
    	        else // This section will only display once and never again.
    	        {
    	            Console.WriteLine("You examine the spilled contents of the chest. Most of it is various uniforms and ");
    	            Console.WriteLine("personal treasures. But you see the GOverload. It's a massive gun that delivers ");
    	            Console.WriteLine("an electric shock to its target from a fair distance. It's some serious firepower. ");
    	            Console.WriteLine("You take it with you.");
    	            haveGOverload=true;
    	            inventoryList[currentInventoryCount]="GOverload";
                    currentInventoryCount++;
    	        }
                break;
           case "look":
           theCaptainsRoomView();
           break;
  	       case "inventory": case "I": case "i":
	            inventory();
	            break;           
    	   default:
    	        Console.WriteLine($"\n''{playerRespond}'' is an invalid command.");
    	        break;
    	} 
      } // End While

  } // End theCaptainsRoom()

   ///////////////////
  // THE CARGO BAY //
 ///////////////////
  
  // Describe to the players what the Cargo Bay looks like. //
  static void theCargoBayView()
  {
    Console.WriteLine("\n\nThe Cargo Bay:");
	Console.WriteLine("-----------:");
    Console.WriteLine("You are in the Cargo Bay. Here is where the goods your crew transports between planets is kept. ");
    Console.WriteLine("As you look around it at one of the massive storage containers it looks to have been ripped open with ");
    Console.WriteLine("a hole twice the size of a human. You know that a smaller CONTAINER in this room has tools to repair ");
    Console.WriteLine("various pieces of the ship. ");
    Console.Write("There is an exit to the north-east and south.\n");
  } // End of theCargoBayView()
  
  // What the players can do when inside the Cargo Bay. //
  static void theCargoBay()
  {
    theCargoBayView();
 	while (true)
	{
    	Console.Write("\nWhat would you like to do next? ");
    	string playerRespond = Console.ReadLine();
    	switch (playerRespond)
    	{
    	   case "NE": case "ne": case "go north-east":
    	        theCockpit();
    	        break;
    	   case "S": case "s": case "go south":
    	        theEngineRoom();
    	        break;
    	   case "CONTAINER": case "check container": case "container": case "check":
    	        if (haveEngineRepairKit==true) // If the container has already been checked, the narrative informs the player.
    	        {
    	            Console.WriteLine("\nThere doesn't seem to be anything else of use here.\n");
    	        }
    	        else // This section will only display once and never again.
    	        {
    	            Console.WriteLine("You open the smaller container that has various tools, some of which repair the ship. ");
    	            Console.WriteLine("You grab the specific tools that will repair damage to the engine. ");
    	            haveEngineRepairKit=true;
    	            inventoryList[currentInventoryCount]="Engine Repair Kit";
                    currentInventoryCount++;
    	        }
                break;
           case "look":
                theCargoBayView();
                break;
  	       case "inventory": case "I": case "i":
	            inventory();
	            break;           
    	   default:
    	        Console.WriteLine($"\n''{playerRespond}'' is an invalid command.");
    	        break;
    	} 
      } // End While

  } // End theCargoBay()
  
  /////////////////////
  // THE ENGINE ROOM //
  ////////////////////
  
  // Describe to the players what the engine room looks like. //
  static void theEngineRoomView()
  {
    Console.WriteLine("\n\nThe Engine Room:");
	Console.WriteLine("-----------:");
    Console.WriteLine("You are in the engine room and engaging a battle with an alien creature. It will nost let you escape.");
    Console.WriteLine("Your only choice is to fight the creature. An exit leading out, but the beast is blocking your exit.");
  } // End of theEngineRoomView()

  // What the players can do when inside the basement. //
  static void theEngineRoom()
  {
    Console.WriteLine("\n\nThe EngineRoom:");
	Console.WriteLine("------------:");
    Console.WriteLine("You believe you've gotten to the heart of the matter. The stench of... something overwhelms ");
    Console.WriteLine("your senses but you manage to push forward despite that. ");
    Console.WriteLine("Loose cables ripped from your ship's engine spark occassionally along the walls and floor.");
    Console.WriteLine("Besides similar dim red emergency lights like the ones in your ship's cockpit, this is the only ");
    Console.WriteLine("lighting in this dark small room. You spot the creature that has been causing you so much of a headache; ");
    Console.WriteLine("It is a large bug with its torso upraised and its lower half crawling around the floor. It's bottom ");
    Console.WriteLine("half has three sharp-looking long legs on either side that it is scrabbling around with while the top ");
    Console.WriteLine("half is muscular with two arms ending in enormous pincers a little larger than the ones on its face ");
    Console.WriteLine("It stares at you with its beady, glowing-red eyes for a while and then suddenly attacks! ");
    Console.WriteLine("You dodge (barely), but it is already rearing up for a follow-up attack! \n");
   
    Console.WriteLine("The battle to the death is about to begin!\n");
    Console.WriteLine($"Your stats: Player's currrent health = {playerCurrentHealth} out of {playerMaxHealth}");
    
    Console.WriteLine($"Alien's stat: Alien's current health = {alienCurrentHealth} out of {alienMaxHealth}"); 

    if (haveGOverload==true)
       Console.WriteLine("\nThe GOverload will help you a lot more than your Hrunting pistol for this battle. \n");
    else
    {
       Console.WriteLine("\nLooks like you've only got your laser pistol Hrunting for this... A shame you didn't pack more firepower...\n");
       Console.WriteLine("-------------------------------------------------------------------------------------");
    }
    
    // Run the battle scene
    theBattle();
  }  // End of theEngineRoom()
  
  
  // The battle //
  static void theBattle()
  {
    Random rand = new Random();
    int alienDamage;
    int playerDamage;
    string playerRespond;
    bool gameOver = false;

    while (!gameOver)
    {
        alienDamage = rand.Next(0,alienPincerDamage);   // This randomize the damage the alien did to your character.
        if (alienPincerDamage==0)
            Console.WriteLine("\nIt totally missed you.\n");    // This was added for additional dialog.
        else
        {
            Console.Write($"It did {alienPincerDamage} points of pincer damage to you. ");
            playerCurrentHealth = playerCurrentHealth - alienPincerDamage;  // Your health is reduced based on the damage.
            Console.WriteLine($"Your current health is now {playerCurrentHealth}.\n");
        }
        
        if (playerCurrentHealth<playerMinHealth)  // Verify if the health goes below minimum.  If not, continue with the battle.
        {
            gameOver = true;
            conclusionLost();
        }
        Console.WriteLine("-------------------------------------------------------------------------------------");
        
        Console.WriteLine("Press Enter key for your turn to attack! "); // This game is set to auto-fight.  
        
        playerRespond = Console.ReadLine(); // However, this option can be changed to querry for other commands, like retreat.
        if (haveGOverload == true)  // Your character will do more damage with the GOverload
        {
            playerDamage = rand.Next(0,GOverloadMaxDamage); // This will randomize the player's damage to the alien.
            if (playerDamage==0)    
                Console.WriteLine("\nThe alien evaded your attack!\n");
            else
            {
                Console.WriteLine($"\nYou did {playerDamage} damage to the alien."); 
                alienCurrentHealth = alienCurrentHealth- playerDamage; // alien health would be reduced accordingly.
                Console.WriteLine($"The alien's health is now {alienCurrentHealth}.\n");
            }
        }
        else // Player attack alien with his/her pistol.
        {
            playerDamage = rand.Next(0,HruntingMaxDamage); // This will randomize the player's damage to the alien.
            if (playerDamage==0)    
                Console.WriteLine("\nThe alien evaded your attack!\n");
            else
            {
                Console.WriteLine($"\nYou did {playerDamage} damage to the alien."); 
                alienCurrentHealth = alienCurrentHealth - playerDamage; // alien health would be reduced accordingly.
                Console.WriteLine($"The alien's health is now {alienCurrentHealth}.\n");
            }
        }
        
        if (alienCurrentHealth<alienMinHealth) // Verify if the alien's health goes below minimum amount.
        {
            gameOver = true;
            if(haveEngineRepairKit==true) // Nested if statement verifies 2nd or 3rd ending based on Repair Kit in player inventory.
            {
                conclusionWin();
            }
            
            else
            {
                conclusionLost2();
            }
        }
        else
        {
            Console.WriteLine("-------------------------------------------------------------------------------------");
            Console.WriteLine("\nPress Enter key for your the alien's turn to attack! "); // This game is set to auto-fight.  
            playerRespond = Console.ReadLine(); // However, this option can be changed to querry for other commands, like retreat.
        }            
    } // While loop
  } // theBattle
  
  // Conclusion - ENDING 1 - LOSE BATTLE //
  static void conclusionLost()
  {
    Console.WriteLine("\n\nThe alien smashes you with one of his thick, blunt pincers. You almost black out and your ");
    Console.WriteLine("weapon is knocked from your hand. You feebly try to reach for it as the alien proceeds to ");
    Console.WriteLine("crawl towards you with hunger in its eyes...");
    Console.WriteLine("\n\nYou have lost...\n");

    restartOption();
  } // End of conclusionLost()
  
  // Conclusion - ENDING 2 - WIN BATTLE NO REPAIR KIT//
  static void conclusionLost2()
  {
      Console.WriteLine("\n\nYou shoot the alien one last time. It writhes and twitches in its final ");
      Console.WriteLine("death throes. You step over it to the smoking engine. Anxiously, you look ");
      Console.WriteLine("around for a way to fix it, but to no avail. Finally, the lights go out ");
      Console.WriteLine("and you feel yourself starting to black out as the ship's oxygen system fails...");
      Console.WriteLine("\n\nYou have lost...\n");
      
      restartOption();
  }
  // Conclusion - WIN //
  static void conclusionWin()
  {
      Console.WriteLine("\n\nYou shoot the alien one last time. It writhes and twitches in its final ");
      Console.WriteLine("death throes. You step over it to the smoking engine. You take out the ");
      Console.WriteLine("Repair Kit and get to work. Eventually, the normal lights kick on and you ");
      Console.WriteLine("hear the sounds of all the rest of the ship's systems going back to full power ");
      Console.WriteLine("You wipe the sweat off your brow and smile.");
      Console.WriteLine("\n\nYou have won!\n");
    
    restartOption();
  } // End of conclusionWin()
  
  
  /////////////
  // RESTART //
  /////////////
  static void restartOption()
  {
    string playerReady, playerRespond;
      
    Console.Write("\nWould you like to restart this game? ");
    playerRespond = Console.ReadLine(); 
	if ((playerRespond == "Y") || (playerRespond == "y") || (playerRespond == "yes") || (playerRespond == "YES"))
    {
        Console.WriteLine("\n\nPlease press the Enter key to restart the game! ");
        playerReady = Console.ReadLine();
        // Run the Main program
        Main();
    }
    else
    {
        Console.Write("\nThank you for playing the Space Ship Repair!");
        gameCredits();
    }
  }
  
  //////////////////////
  // End game credits //
  //////////////////////
  static void gameCredits()
  {
	Console.WriteLine("\n\n===============================================================================");
	Console.WriteLine("     Space Ship Repair");
	Console.WriteLine("     Designed and developed by Jackie Wright with");
	Console.WriteLine("     special thanks to Professor Pham");
	Console.WriteLine("     for CSC 240-010, Assignment #2");  
	Console.WriteLine("===============================================================================\n\n");    
    Environment.Exit(1); // Safely exit the program
  }

  //////////////////////////////////////////
  //            INVENTORY                 //
  // The players can see their inventory. //
  //////////////////////////////////////////
  static void inventory()
  {
    if (currentInventoryCount==0)
        Console.WriteLine("\nYou currently are not carrying any items.\n");
    else
    {
        Console.WriteLine("\nCurrently you are carrying the folllowing items:\n");
        for (int counter =0; counter < currentInventoryCount; counter++)
            Console.WriteLine(inventoryList[counter]);
    } // else
  } // End of inventory()
} //End of SpaceShipRepair class

  

  
  