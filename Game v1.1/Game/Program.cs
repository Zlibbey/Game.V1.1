using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    //This is the class that will contain the methods for all the rooms that are used in this game.
    public class Rooms
    {
        //#region allows you to make a section that you can name and collapse.
        //Example would be #region Name
        //At the end of the section you put #endregion this lets visual studio know that is where
        //the end of your region is and then you can click next to the #region on the minus symbol to 
        //collapse the code inbetween making your code easier to navigate.
        #region Room 1&1B&1C
        //This is the method for room1 and defines what will happen in room1.
        #region Room 1
        public static void room1()
        {
            // string rp1 is a Console.ReadLine() so that it will take what ever the user inputs and try to match it to the cases.
            string write;
            write = " That is not a valid response. Try writing help.";
            string rp1 = Console.ReadLine();
            switch (rp1)
            {
                //starts the cases for the switch statement rp1 the cases are based off of the commands input by the user.
                //This is where the readline comes in if the user entered help it will go to this case if not it will continue
                //checking the other cases.
                //Notice that at the end of the cases it recalls the method Rooms.room1();
                //This is so that the application doesn't end after one command. So instead of ending it just puts you back at
                //the beginning of the method.
                case "help":
                    write = " Commands: help, look around, open door, look for window, check the dresser, check the man, sleep, eat, kill, \n" +
                        "look under the bed.";
                    Console.WriteLine(write);
                    Rooms.room1();
                    break;
                case "look around":
                    write = " You are in the middle of the room. In front of you is a wood door that seems old but looks like it is sturdy.\n" +
                        " There is a window to the right of the door but it is covered with a reflective material.\n" +
                        " There is a dresser to the left side of the door that seems as though it is going to fall through the floor.\n" +
                        " There is an old bed in the back right corner of the room that seems to be riddled with bugs.\n" +
                        " In the back left corner of the room there is a large spider that is fused with the torso of a man\n" +
                        " not sure if the creature is dead or sleeping but still best to leave it alone.\n";
                    Console.WriteLine(write);
                    Rooms.room1();
                    break;
                case "open door":
                    write = " Door is locked. Maybe there is a key around here.";
                    Console.WriteLine(write);
                    Rooms.room1();
                    break;
                case "look for window":
                    write = " The window is covered with a material all you can see is your own reflection";
                    Console.WriteLine(write);
                    Rooms.room1();
                    break;
                case "kill":
                    write = " You had always been told that there was no place for your blood lust in this world.\n " +
                        " Due to your inablility to just not kill something you turn on yourself.\n " +
                        " Its actually pretty talented what you did, not many people can disembowl themselves.\n";
                    Console.WriteLine(write);
                    Console.WriteLine("Would you like to try again?");
                    string tryagain;
                    tryagain = Console.ReadLine();
                    switch (tryagain)
                    {
                        case "yes":
                            write = "Returning you to the beginning.";
                                Console.WriteLine(write);
                            Rooms.room1();
                            break;
                        case "no":
                            write = "Better luck next time! Goodbye.";
                            Console.WriteLine(write);
                            break;
                        default:
                            write = "Better luck next time! Goodbye.";
                            Console.WriteLine(write);
                            break;
                    }
                    break;
                case "escape":
                    write = "Really? A game that easy? This isn't Dark Souls......";
                    Console.WriteLine(write);
                    Rooms.room1();
                    break;
                //This has the program write the Console.WriteLine if the user input the check the dresser command.
                //Then it has the program ask the user if they would like to continue and then goes to a
                //switch statement for what the user inputs for the command which is yes or no.
                case "check the dresser":
                    Console.WriteLine(" You look at the dresser and find a note in the first drawer it reads:\n " +
                        " Dont touch the solution. It changes you. I can feel the hunger growing and consuming me.\n " +
                        " I'm still not getting used to the webs. I need help, I can't fix this. If you find me after I change\n" +
                        " don't touch me..... Make sure I don't find you.");
                    Console.WriteLine("Do you want to continue? Type yes or no.");
                    string check1;
                    check1 = Console.ReadLine();
                    switch (check1)
                    {
                        case "yes":
                            write = " You look in the second drawer and find a bunch of old clothes that are rotting.";
                            Console.WriteLine(write);
                            Rooms.room1();
                            break;
                        case "no":
                            write = " You shut the drawer a little more afraid after reading the note.";
                            Console.WriteLine(write);
                            Rooms.room1();
                            break;
                        default:
                            write = "You shut the drawer a little more afraid after reading the note.";
                            Console.WriteLine(write);
                            Rooms.room1();
                            break;
                    }
                    break;
                case "check the man":
                    write = " You look at the half spider half man creature. You dont see any rise or fall of its chest. You believe that it is dead. You search the creature to see if it has the key.\n " +
                        " During your search the creature wakes up. You try to run in terror however you have no where to go. You are locked in the room.\n " +
                        " You turn around to see the venom dripping from its mouth while it looks at you hungrily.\n " +
                        " Your last thoughts are of your family as you are consumed by the mouth of the unnatural creature.\n " +
                        " You then pass into the void.";
                    Console.WriteLine(write);
                    Console.WriteLine("Would you like to try again?");
                    tryagain = Console.ReadLine();
                    switch (tryagain)
                    {
                        case "yes":
                            write = "Returning you to the beginning.";
                            Console.WriteLine(write);
                            Rooms.room1();
                            break;
                        case "no":
                            write = "Better luck next time! Goodbye.";
                            Console.WriteLine(write);
                            break;
                        default:
                            write = "Better luck next time! Goodbye.";
                            Console.WriteLine(write);
                            break;
                    }
                    break;
                // Default case so that if a response is entered that isn't one of the choices then the programs just recalls the method.
                default:
                    write = "Invalid response try typing help for a list of commands.";
                    Console.WriteLine(write);
                    Rooms.room1();
                    break;
                case "sleep":
                    write = "You lay down in the bug riddled bed to sleep. You never wake up,\n" +
                        "because you are eaten alive by the bugs.";
                    Console.WriteLine(write);
                    Console.WriteLine("Would you like to try again?");
                    tryagain = Console.ReadLine();
                    switch (tryagain)
                    {
                        case "yes":
                            write = "Returning you to the beginning.";
                            Console.WriteLine(write);
                            Rooms.room1();
                            break;
                        case "no":
                            write = "Better luck next time! Goodbye.";
                            Console.WriteLine(write);
                            break;
                        default:
                            write = "Better luck next time! Goodbye.";
                            Console.WriteLine(write);
                            break;
                    }
                    break;
                case "eat":
                    write = "You have nothing to eat.";
                    Console.WriteLine(write);
                    Rooms.room1();
                    break;
                case "look under the bed":
                    write = "You look under the bed and see nothing at first. Then after looking at the bottom of the bed you see something shiny.\n" +
                        "Would you like to investigate it?\n";
                    Console.WriteLine(write);
                    string check2;
                    check2 = Console.ReadLine();
                    switch (check2)
                    {
                        case "yes":
                            write = "Upon closer investigation you find that it is the key! You hurry and grab it.";
                            Console.WriteLine(write);
                            Rooms.room1b();
                            break;
                        case "no":
                            write = "You hurry and get out from under the bed and away from it before the bugs eat you.\n";
                            Console.WriteLine(write);
                            Rooms.room1();
                            break;
                        default:
                            write = "You hurry and get out from under the bed and away from it before the bugs eat you.";
                            Console.WriteLine(write);
                            Rooms.room1();
                            break;
                    }
                    break;
            }
        }
        #endregion
        #region Room 1B
        public static void room1b()
        {
            //This method is used for when the user has the key to open the door because the writeline for the door will change.
            string write;
            write = " That is not a valid response. Try writing help.";
            string rp1 = Console.ReadLine();
            switch (rp1)
            {
                //starts the cases for the switch statement rp1 the cases are based off of the commands input by the user.
                case "help":
                    write = " Commands: help, look around, open door, look for window, check the dresser, check the man, sleep, eat, kill, \n" +
                        "look under the bed.";
                    Console.WriteLine(write);
                    Rooms.room1b();
                    break;
                case "look around":
                    write = " You are in the middle of the room. In front of you is a wood door that seems old but looks like it is sturdy.\n" +
                        " There is a window to the right of the door but it is covered with a reflective material.\n" +
                        " There is a dresser to the left side of the door that seems as though it is going to fall through the floor.\n" +
                        " There is an old bed in the back right corner of the room that seems to be riddled with bugs.\n" +
                        " In the back left corner of the room there is a large spider that is fused with the torso of a man\n" +
                        " not sure if the creature is dead or sleeping but still best to leave it alone.\n";
                    Console.WriteLine(write);
                    Rooms.room1b();
                    break;
                case "open door":
                    write = " You put the key into the lock. The key sticks in the lock but the door swings open";
                    Console.WriteLine(write + " and you proceed into the next room.\n");
                    //Notice that this case returns the Rooms.room2() method. To the user this will appear as though they have
                    //made it to the next or second room in the game.
                    Rooms.room2();
                    break;
                case "look for window":
                    write = " The window is covered with a material all you can see is your own reflection";
                    Console.WriteLine(write);
                    Rooms.room1b();
                    break;
                case "kill":
                    write = " You had always been told that there was no place for your blood lust in this world.\n " +
                        " Due to your inablility to just not kill something you turn on yourself.\n " +
                        " Its actually pretty talented what you did, not many people can disembowl themselves.\n";
                    Console.WriteLine(write);
                    Console.WriteLine("Would you like to try again?");
                    string tryagain;
                    tryagain = Console.ReadLine();
                    switch (tryagain)
                    {
                        case "yes":
                            write = "Returning you to the beginning.";
                            Console.WriteLine(write);
                            Rooms.room1();
                            break;
                        case "no":
                            write = "Better luck next time! Goodbye.";
                            Console.WriteLine(write);
                            break;
                        default:
                            write = "Better luck next time! Goodbye.";
                            Console.WriteLine(write);
                            break;
                    }
                    break;
                case "escape":
                    write = "Really? A game that easy? This isn't Dark Souls......";
                    Console.WriteLine(write);
                    Rooms.room1b();
                    break;
                //This has the program write the Console.WriteLine if the user input the check the dresser command.
                //Then it has the program ask the user if they would like to continue and then goes to a
                //switch statement for what the user inputs for the command which is yes or no.
                case "check the dresser":
                    Console.WriteLine(" You look at the dresser and find a note in the first drawer it reads:\n " +
                        " Dont touch the solution. It changes you. I can feel the hunger growing and consuming me.\n " +
                        " I'm still not getting used to the webs. I need help, I can't fix this. If you find me after I change\n" +
                        " don't touch me..... Make sure I don't find you.");
                    Console.WriteLine("Do you want to continue? Type yes or no.");
                    string check1;
                    check1 = Console.ReadLine();
                    switch (check1)
                    {
                        case "yes":
                            write = " You look in the second drawer and find a bunch of old clothes that are rotting.";
                            Console.WriteLine(write);
                            Rooms.room1b();
                            break;
                        case "no":
                            write = " You shut the drawer a little more afraid after reading the note.";
                            Console.WriteLine(write);
                            Rooms.room1b();
                            break;
                        default:
                            write = "You shut the drawer a little more afraid after reading the note.";
                            Console.WriteLine(write);
                            Rooms.room1b();
                            break;
                    }
                    break;
                case "check the man":
                    write = " You look at the half spider half man creature. You dont see any rise or fall of its chest. You believe that it is dead. You search the creature to see if it has the key.\n " +
                        " During your search the creature wakes up. You try to run in terror however you have no where to go. You are locked in the room.\n " +
                        " You turn around to see the venom dripping from its mouth while it looks at you hungrily.\n " +
                        " Your last thoughts are of your family as you are consumed by the mouth of the unnatural creature.\n " +
                        " You then pass into the void.";
                    Console.WriteLine(write);
                    Console.WriteLine("Would you like to try again?");
                    tryagain = Console.ReadLine();
                    switch (tryagain)
                    {
                        case "yes":
                            write = "Returning you to the beginning.";
                            Console.WriteLine(write);
                            Rooms.room1();
                            break;
                        case "no":
                            write = "Better luck next time! Goodbye.";
                            Console.WriteLine(write);
                            break;
                        default:
                            write = "Better luck next time! Goodbye.";
                            Console.WriteLine(write);
                            break;
                    }
                    break;
                // Default case so that if a response is entered that isn't one of the choices then the programs just recalls the method.
                default:
                    write = "Invalid response try typing help for a list of commands.";
                    Console.WriteLine(write);
                    Rooms.room1b();
                    break;
                case "sleep":
                    write = "You lay down in the bug riddled bed to sleep. You never wake up,\n" +
                        "because you are eaten alive by the bugs.";
                    Console.WriteLine(write);
                    Console.WriteLine("Would you like to try again?");
                    tryagain = Console.ReadLine();
                    switch (tryagain)
                    {
                        case "yes":
                            write = "Returning you to the beginning.";
                            Console.WriteLine(write);
                            Rooms.room1();
                            break;
                        case "no":
                            write = "Better luck next time! Goodbye.";
                            Console.WriteLine(write);
                            break;
                        default:
                            write = "Better luck next time! Goodbye.";
                            Console.WriteLine(write);
                            break;
                    }
                    break;
                case "eat":
                    write = "You have nothing to eat.";
                    Console.WriteLine(write);
                    Rooms.room1b();
                    break;
                case "look under the bed":
                    write = "There is nothing under the bed.\n";
                    Console.WriteLine(write);
                    Rooms.room1b();
                    break;
            }
        }
        #endregion
        #region Room 1C
        public static void room1c()
        {
            //This method is used for when the user has the key to open the door because the writeline for the door will change.
            string write;
            write = " That is not a valid response. Try writing help.";
            string rp1 = Console.ReadLine();
            switch (rp1)
            {
                //starts the cases for the switch statement rp1 the cases are based off of the commands input by the user.
                case "help":
                    write = " Commands: help, look around, next room, look for window, check the dresser, check the man, sleep, eat, kill, \n" +
                        "look under the bed, fight the man, break the window.";
                    Console.WriteLine(write);
                    Rooms.room1c();
                    break;
                case "look around":
                    write = " You are in the middle of the room. In front of you is a wood door that seems old but looks like it is sturdy.\n" +
                        " There is a window to the right of the door but it is covered with a reflective material.\n" +
                        " There is a dresser to the left side of the door that seems as though it is going to fall through the floor.\n" +
                        " There is an old bed in the back right corner of the room that seems to be riddled with bugs.\n" +
                        " In the back left corner of the room there is a large spider that is fused with the torso of a man\n" +
                        " not sure if the creature is dead or sleeping but still best to leave it alone.\n";
                    Console.WriteLine(write);
                    Rooms.room1c();
                    break;
                case "next room":
                    write = "You go back through the door into the next room.";
                    Console.WriteLine(write);
                    Rooms.room2b();
                    break;
                case "look for window":
                    write = " The window is covered with a material all you can see is your own reflection";
                    Console.WriteLine(write);
                    Rooms.room1c();
                    break;
                case "kill":
                    write = " You had always been told that there was no place for your blood lust in this world.\n " +
                        " Due to your inablility to just not kill something you turn on yourself.\n " +
                        " Its actually pretty talented what you did, not many people can disembowl themselves.\n";
                    Console.WriteLine(write);
                    Console.WriteLine("Would you like to try again?");
                    string tryagain;
                    tryagain = Console.ReadLine();
                    switch (tryagain)
                    {
                        case "yes":
                            write = "Returning you to the beginning.";
                            Console.WriteLine(write);
                            Rooms.room1();
                            break;
                        case "no":
                            write = "Better luck next time! Goodbye.";
                            Console.WriteLine(write);
                            break;
                        default:
                            write = "Better luck next time! Goodbye.";
                            Console.WriteLine(write);
                            break;
                    }
                    break;
                case "escape":
                    write = "Really? A game that easy? This isn't Dark Souls......";
                    Console.WriteLine(write);
                    Rooms.room1c();
                    break;
                //This has the program write the Console.WriteLine if the user input the check the dresser command.
                //Then it has the program ask the user if they would like to continue and then goes to a
                //switch statement for what the user inputs for the command which is yes or no.
                case "check the dresser":
                    Console.WriteLine(" You look at the dresser and find a note in the first drawer it reads:\n " +
                        " Dont touch the solution. It changes you. I can feel the hunger growing and consuming me.\n " +
                        " I'm still not getting used to the webs. I need help, I can't fix this. If you find me after I change\n" +
                        " don't touch me..... Make sure I don't find you.");
                    Console.WriteLine("Do you want to continue? Type yes or no.");
                    string check1;
                    check1 = Console.ReadLine();
                    switch (check1)
                    {
                        case "yes":
                            write = " You look in the second drawer and find a bunch of old clothes that are rotting.";
                            Console.WriteLine(write);
                            Rooms.room1c();
                            break;
                        case "no":
                            write = " You shut the drawer a little more afraid after reading the note.";
                            Console.WriteLine(write);
                            Rooms.room1c();
                            break;
                        default:
                            write = "You shut the drawer a little more afraid after reading the note.";
                            Console.WriteLine(write);
                            Rooms.room1c();
                            break;
                    }
                    break;
                case "check the man":
                    write = " You look at the half spider half man creature. You dont see any rise or fall of its chest. You believe that it is dead. You search the creature to see if it has the key.\n " +
                        " During your search the creature wakes up. You try to run in terror however you have no where to go. You are locked in the room.\n " +
                        " You turn around to see the venom dripping from its mouth while it looks at you hungrily.\n " +
                        " Your last thoughts are of your family as you are consumed by the mouth of the unnatural creature.\n " +
                        " You then pass into the void.";
                    Console.WriteLine(write);
                    Console.WriteLine("Would you like to try again?");
                    tryagain = Console.ReadLine();
                    switch (tryagain)
                    {
                        case "yes":
                            write = "Returning you to the beginning.";
                            Console.WriteLine(write);
                            Rooms.room1();
                            break;
                        case "no":
                            write = "Better luck next time! Goodbye.";
                            Console.WriteLine(write);
                            break;
                        default:
                            write = "Better luck next time! Goodbye.";
                            Console.WriteLine(write);
                            break;
                    }
                    break;
                    break;
                // Default case so that if a response is entered that isn't one of the choices then the programs just recalls the method.
                default:
                    write = "Invalid response try typing help for a list of commands.";
                    Console.WriteLine(write);
                    Rooms.room1c();
                    break;
                case "sleep":
                    write = "You lay down in the bug riddled bed to sleep. You never wake up,\n" +
                        "because you are eaten alive by the bugs.";
                    Console.WriteLine(write);
                    Console.WriteLine("Would you like to try again?");
                    tryagain = Console.ReadLine();
                    switch (tryagain)
                    {
                        case "yes":
                            write = "Returning you to the beginning.";
                            Console.WriteLine(write);
                            Rooms.room1();
                            break;
                        case "no":
                            write = "Better luck next time! Goodbye.";
                            Console.WriteLine(write);
                            break;
                        default:
                            write = "Better luck next time! Goodbye.";
                            Console.WriteLine(write);
                            break;
                    }
                    break;
                case "eat":
                    write = "You have nothing to eat.";
                    Console.WriteLine(write);
                    Rooms.room1c();
                    break;
                case "look under the bed":
                    write = "There is nothing under the bed.\n";
                    Console.WriteLine(write);
                    Rooms.room1c();
                    break;
                case "fight the man":
                    write = "You attempt to kill the man with the hammer that you have found. He is faster and deadlier than you thought.\n" +
                        "You were unable to kill him and you have been devoured by the man.";
                    Console.WriteLine(write);
                    Console.WriteLine("Would you like to try again?");
                    tryagain = Console.ReadLine();
                    switch (tryagain)
                    {
                        case "yes":
                            write = "Returning you to the beginning.";
                            Console.WriteLine(write);
                            Rooms.room1();
                            break;
                        case "no":
                            write = "Better luck next time! Goodbye.";
                            Console.WriteLine(write);
                            break;
                        default:
                            write = "Better luck next time! Goodbye.";
                            Console.WriteLine(write);
                            break;
                    }
                    break;
                case "break the window":
                    write = "You use the hammer to shatter the glass of the window. As the glass falls you see sunlight shine through the opening.\n" +
                        "You use this opening to climb out and escape.";
                    Console.WriteLine(write);
                    Console.WriteLine("Congratulations you have escaped!!");
                    break;
                    #endregion
            }
        }
        #endregion
        #region Room 2&2B
        //This is the method for room2b and defines what will happen in room2.
        #region Room 2b
        public static void room2b()
        {
            //This is the method for the second room used in the game.
            string write;
            write = " That is not a valid response. Try writing help.";
            string rp1 = Console.ReadLine();
            switch (rp1)
            {
                case "go back":
                    write = "you go back into the first room.";
                    Console.WriteLine(write);
                    Rooms.room1c();
                    break;
                case "look around":
                    write = "You start looking at the new room starting to your left, you see a cabinet with glass doors,\n" + 
                        "except the glass is shattered.The shelves of the cabinet are disarrayed and it is leaning slumped to the right.\n" +
                        "further down the wall to your left you see a gray entertainment stand that is also slumped to the right,\n" +
                        "on the entertainment stand is an old box tv whose screen is still intact but wires are sticking out of the top through \n" +
                        "a hole that has been ripped into it. On the far wall across from you there are large jagged claw marks cutting\n" +
                        "into the wood that is the wall. The claw marks sink about half an inch into the wall and are black like the claws that\n" +
                        "made them were burning. Your eyes move to the right wall which has bookshelf against it toward the far wall, the\n" +
                        "bookshelf still has some disarrayed books on it but most of the books have fallen to the floor around the base of the \n" + 
                        "shelf. Next to the bookshelf is a door that has light shining through the cracks of it, the light flickers like its\n" + 
                        "source is a flame. The rest of the wall on the right coming toward you is just wallpaper that is torn and falling off.\n" +
                        "In the middle of the room facing the entertainment stand is a couch that has claw marks ripped into the back of it.\n" + 
                        "The couch is sagging with age and does not look like it could support the weight of a person.\n" + 
                        "Next to the couch is a black night stand with a lamp shattered around its base.\n" +
                        "The stand has a drawer in it and its base is cutting into the floor like it once held a great weight.\n";
                    Console.WriteLine(write);
                    Rooms.room2b();
                    break;
                case "check the cabinet":
                    write = "Upon closer inspection of the cabinet you find some broken dishes in the bottom of it. Other than that there is nothing in or around the cabinet.\n";
                    Console.WriteLine(write);
                    Rooms.room2b();
                    break;
                case "check the entertainment stand":
                    write = "Looking through the entertainment stand you open the drawers but all you find is mouse droppings.\n";
                    Console.WriteLine(write);
                    Rooms.room2b();
                    break;
                case "check the tv":
                    write = "Upon closer inspection of the tv you look at the hole through which the wires are sticking out through the top, the whole looks like \n" +
                          "it was made by the same creature that caused the claw marks. Inside the tv is blackend and burned other than that the tv is useless.";
                    Console.WriteLine(write);
                    Rooms.room2b();
                    break;
                default:
                    write = "That is an invalid response. Try something else.";
                    Console.WriteLine(write);
                    Rooms.room2b();
                    break;
                case "look behind the entertainment stand":
                    write = "There is nothing there.";
                    Console.WriteLine(write);
                    break;
                case "open door":
                    write = "As you touch the handle going into the door to the next room it feels hot to the touch.";
                    Console.WriteLine(write);
                    Console.WriteLine("Do you want to continue?");
                    string check2;
                    string tryagain;
                    check2 = Console.ReadLine();
                    switch (check2)
                    {
                        case "yes":
                            write = "You continue to open the door into the next room despise the handle being hot to the touch.\n" +
                                "Upon opening the door you are met by a flaming demon. The demon opens his maw and expels fire from his mouth.\n" +
                                "The fire incinerates you instantly leaving nothing but a pile of ash.";
                            Console.WriteLine(write);
                            Console.WriteLine("Would you like to try again?");
                            tryagain = Console.ReadLine();
                            switch (tryagain)
                            {
                                case "yes":
                                    write = "Returning you to the beginning.";
                                    Console.WriteLine(write);
                                    Rooms.room1();
                                    break;
                                case "no":
                                    write = "Better luck next time! Goodbye.";
                                    Console.WriteLine(write);
                                    break;
                                default:
                                    write = "Better luck next time! Goodbye.";
                                    Console.WriteLine(write);
                                    break;
                            }
                            break;
                        case "no":
                            write = "The heat of the handle is unsettling to you. You take your hand off the handle and back away from the door.\n" +
                                "You turn away from the door with you back to it, leaving it for later.";
                            Console.WriteLine(write);
                            Rooms.room2b();
                            break;
                    }
                    break;
                case "check the nightstand":
                    write = "You open up the nightstand and are met with disappointment when you find nothing.";
                    Console.WriteLine(write);
                    Rooms.room2b();
                    break;
                case "search the couch":
                    write = "You go through the couch to see if you can find anything and your efforts have failed(probably again).";
                    Console.WriteLine(write);
                    Rooms.room2b();
                    break;
                case "sit on the couch":
                    write = "You sit down on the couch and for a moment you enjoy yourself before the couch collapses under your weight.\n" +
                        "Brushing the dust off yourself you stand up and decide you must continue searching the room. After you get off the couch" +
                        "it bends back to its original position.";
                    Console.WriteLine(write);
                    Rooms.room2b();
                    break;
                case "check the bookshelf":
                    write = "You rummage through the bookshelf trying desperately to find something to help you escape but your efforts are fruitless.";
                    Console.WriteLine(write);
                    Rooms.room2b();
                    break;
                case "move the bookshelf":
                    write = "You try to pull the bookshelf away from the wall to see if there is something behind the bookshelf.\n" +
                        "In your attempt to move the bookshelf it falls forward crushing you.";
                    Console.WriteLine(write);
                    Console.WriteLine("Would you like to try again?");
                    tryagain = Console.ReadLine();
                    switch (tryagain)
                    {
                        case "yes":
                            write = "Returning you to the beginning.";
                            Console.WriteLine(write);
                            Rooms.room1();
                            break;
                        case "no":
                            write = "Better luck next time! Goodbye.";
                            Console.WriteLine(write);
                            break;
                        default:
                            write = "Better luck next time! Goodbye.";
                            Console.WriteLine(write);
                            break;
                    }
                    break;
                case "help":
                    write = "Commands: move the bookshelf, check the bookshelf, sit on the couch, search the couch, check the nightstand, \n" +
                        "open door, look behind the entertainment stand, check the entertainment stand, check the tv, check the cabinet, \n" +
                        "look around, go back.";
                    Console.WriteLine(write);
                    Rooms.room2b();
                    break;
            }
        }
        #endregion
        #region Room 2
        public static void room2()
        {
            //This is the method for the second room used in the game.
            string write;
            write = " That is not a valid response. Try writing help.";
            string rp1 = Console.ReadLine();
            switch (rp1)
            {
                case "go back":
                    write = "you go back into the first room.";
                    Console.WriteLine(write);
                    Rooms.room1b();
                    break;
                case "look around":
                    write = "You start looking at the new room starting to your left, you see a cabinet with glass doors,\n" +
                       "except the glass is shattered.The shelves of the cabinet are disarrayed and it is leaning slumped to the right.\n" +
                       "further down the wall to your left you see a gray entertainment stand that is also slumped to the right,\n" +
                       "on the entertainment stand is an old box tv whose screen is still intact but wires are sticking out of the top through \n" +
                       "a hole that has been ripped into it. On the far wall across from you there are large jagged claw marks cutting\n" +
                       "into the wood that is the wall. The claw marks sink about half an inch into the wall and are black like the claws that\n" +
                       "made them were burning. Your eyes move to the right wall which has bookshelf against it toward the far wall, the\n" +
                       "bookshelf still has some disarrayed books on it but most of the books have fallen to the floor around the base of the \n" +
                       "shelf. Next to the bookshelf is a door that has light shining through the cracks of it, the light flickers like its\n" +
                       "source is a flame. The rest of the wall on the right coming toward you is just wallpaper that is torn and falling off.\n" +
                       "In the middle of the room facing the entertainment stand is a couch that has claw marks ripped into the back of it.\n" +
                       "The couch is sagging with age and does not look like it could support the weight of a person.\n" +
                       "Next to the couch is a black night stand with a lamp shattered around its base.\n" +
                       "The stand has a drawer in it and its base is cutting into the floor like it once held a great weight.\n";
                    Console.WriteLine(write);
                    Rooms.room2();
                    break;
                case "check the cabinet":
                    write = "Upon closer inspection of the cabinet you find some broken dishes in the bottom of it. Other than that there is nothing in or around the cabinet.\n";
                    Console.WriteLine(write);
                    Rooms.room2();
                    break;
                case "check the entertainment stand":
                    write = "Looking through the entertainment stand you open the drawers but all you find is mouse droppings.\n";
                    Console.WriteLine(write);
                    Rooms.room2();
                    break;
                case "check the tv":
                    write = "Upon closer inspection of the tv you look at the hole through which the wires are sticking out through the top, the whole looks like \n" +
                          "it was made by the same creature that caused the claw marks. Inside the tv is blackend and burned other than that the tv is useless.";
                    Console.WriteLine(write);
                    Rooms.room2();
                    break;
                default:
                    write = "That is an invalid response. Try something else.";
                    Console.WriteLine(write);
                    Rooms.room2();
                    break;
                case "look behind the entertainment stand":
                    write = "You look behind the entertainment stand and find a hammer laying on the floor.\n" +
                        "Would you like to take it?";
                    Console.WriteLine(write);
                    string checkresp = Console.ReadLine();
                    switch (checkresp)
                    {
                        case "yes":
                            write = "You take the hammer and continue your search for a way out.";
                            Console.WriteLine(write);
                            Rooms.room2b();
                            break;
                        case "no":
                            write = "You leave the hammer where it is and continue your search for a way out.";
                            Console.WriteLine(write);
                            Rooms.room2();
                            break;
                    }
                    break;
                case "open door":
                    write = "As you touch the handle going into the door to the next room it feels hot to the touch.";
                    Console.WriteLine(write);
                    Console.WriteLine("Do you want to continue?");
                    string check2;
                    string tryagain;
                    check2 = Console.ReadLine();
                    switch (check2)
                    {
                        case "yes":
                            write = "You continue to open the door into the next room despise the handle being hot to the touch.\n" +
                                "Upon opening the door you are met by a flaming demon. The demon opens his maw and expels fire from his mouth.\n" +
                                "The fire incinerates you instantly leaving nothing but a pile of ash.";
                            Console.WriteLine(write);
                            Console.WriteLine("Would you like to try again?");
                            tryagain = Console.ReadLine();
                            switch (tryagain)
                            {
                                case "yes":
                                    write = "Returning you to the beginning.";
                                    Console.WriteLine(write);
                                    Rooms.room1();
                                    break;
                                case "no":
                                    write = "Better luck next time! Goodbye.";
                                    Console.WriteLine(write);
                                    break;
                                default:
                                    write = "Better luck next time! Goodbye.";
                                    Console.WriteLine(write);
                                    break;
                            }
                            break;
                        case "no":
                            write = "The heat of the handle is unsettling to you. You take your hand off the handle and back away from the door.\n" +
                                "You turn away from the door with you back to it, leaving it for later.";
                            Console.WriteLine(write);
                            Rooms.room2();
                            break;
                    }
                    break;
                case "check the nightstand":
                    write = "You open up the nightstand and are met with disappointment when you find nothing.";
                    Console.WriteLine(write);
                    Rooms.room2();
                    break;
                case "search the couch":
                    write = "You go through the couch to see if you can find anything and your efforts have failed(probably again).";
                    Console.WriteLine(write);
                    Rooms.room2();
                    break;
                case "sit on the couch":
                    write = "You sit down on the couch and for a moment you enjoy yourself before the couch collapses under your weight.\n" +
                        "Brushing the dust off yourself you stand up and decide you must continue searching the room. After you get off the couch" +
                        "it bends back to its original position.";
                    Console.WriteLine(write);
                    Rooms.room2();
                    break;
                case "check the bookshelf":
                    write = "You rummage through the bookshelf trying desperately to find something to help you escape but your efforts are fruitless.";
                    Console.WriteLine(write);
                    Rooms.room2();
                    break;
                case "move the bookshelf":
                    write = "You try to pull the bookshelf away from the wall to see if there is something behind the bookshelf.\n" +
                        "In your attempt to move the bookshelf it falls forward crushing you.";
                    Console.WriteLine(write);
                    Console.WriteLine("Would you like to try again?");
                    tryagain = Console.ReadLine();
                    switch (tryagain)
                    {
                        case "yes":
                            write = "Returning you to the beginning.";
                            Console.WriteLine(write);
                            Rooms.room1();
                            break;
                        case "no":
                            write = "Better luck next time! Goodbye.";
                            Console.WriteLine(write);
                            break;
                        default:
                            write = "Better luck next time! Goodbye.";
                            Console.WriteLine(write);
                            break;
                    }
                    break;
                case "help":
                    write = "Commands: move the bookshelf, check the bookshelf, sit on the couch, search the couch, check the nightstand, \n" +
                        "open door, look behind the entertainment stand, check the entertainment stand, check the tv, check the cabinet, \n" +
                        "look around, go back.";
                    Console.WriteLine(write);
                    Rooms.room2();
                    break;
            }
        }
        #endregion
        #endregion
        #region Class Person
        public class Person
        {
            // Field
            public string name;
            // Constructor that takes no arguments.
            public Person()
            {
                name = "unknown";
            }
            // Constructor that takes one argument
            public Person(string nm)
            {
                name = nm;
            }
            // Method
            public void SetName(string newName)
            {
                name = newName;
            }
        }
        #endregion
        #region Program(Main)
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Hello and welcome to the House.(Now with more questions!)");
                Console.WriteLine("Press the Enter key to continue or press the exit button at the top of the screen to leave.");
                // Console.ReadKey(); will keep the console window open while debugging.
                // This use of the Console.ReadKey(); just gives the user a option to continue or leave.
                // Note if the user presses a character key then the command will input the key they pressed
                // infront of the next output.
                Console.ReadKey();
                Console.WriteLine("So you have chosen to continue. Well then may we have your name?");
                // This line uses the Person constructor in the Person class to create a new method named person1.
                // person1 is then uses the SetName method and the Console.ReadLine command to allow the user
                // to imput their name and for the program to store it for use.
                Person person1 = new Person();
                person1.SetName(Console.ReadLine());
                Console.WriteLine("Hello " + person1.name + " this is a game of survival. You are stuck in a house, use commands to find your way out.");
                Console.WriteLine("The commands are Case Sensitive, for quick reference none of the commands use capital letters.\n" +
                   "If you need more information try typing help.\n");
                Console.WriteLine("So what do you want to do?");
                Rooms rm = new Rooms();
                Rooms.room1();
            }
        }
        #endregion
    }
}