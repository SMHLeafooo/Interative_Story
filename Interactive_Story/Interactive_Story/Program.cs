
Console.WriteLine("Hello, what is your name?");

string name = Console.ReadLine();

string val = "";

if (name == "Hugo")
{
    Console.WriteLine("Hugo the Maidenless, Welcome coward, press any key to continue");
}

else if (name == "Leonard")
{
    Console.WriteLine("Leonard the rainbow mane lion squishmallow, Welcome brave hero,press any key to continue");
}

else if (name == "Alex")
{
    Console.WriteLine("Alex Gino, Welcome brave hero, press any key to continue");
}

else
{
    Console.WriteLine($"Welcome {name} you worthless nobody, press any key to continue");
}
Console.ReadLine();

Console.WriteLine($"{name}, You arrive at a small village and get confronted by a villager. You have been chosen to save the Kingdom of Nothingness great hero, will you start out on your journey towards the capital, yes or no?");

val = Console.ReadLine();

if (val == "yes")
{
    Console.WriteLine("You venture out on your long journey, on your way there you are approached by 3 bandits, they surround you. What will you do? 1. Use your sword and shield to attack the bandits.  2. Use your fire magic to burn the bandits to a crisp.  3. Offer the bandits your money in exchange for letting you go.");
    val = Console.ReadLine();

}

else if (val == "no")
{
    Console.WriteLine("You have chosen the way of the cowards. The villagers surround you and stab you to death with their pitchforks");
    val = Console.ReadLine();
}

if (val == "1")
{
    Console.WriteLine("You unsheate your sword and remove your shield from your back, the bandits take out their knives and the first one swings at you, you masterfully dodge it and stab him killing him instantly, the second one runs at you and you block his stab with your shield, a loud kling echoes as his knife flies out of his hand and you slash him across his chest, you charge the third one before he can react and shield slam him into the ground and he loses consciousness instantly. You proceed onwards hero. ");
    Console.WriteLine($"{name} you have finally arrived at the gate of the castle after a really long journey, you are now faced with 3 possibilites. Which will you choose? a. Singlehandedly invade the castle and crown yourself Emperor over the Kingdom.  b. Enter the castle and kneel before the king to accept the mission of saving the kingdom from evil.  c. Go home after a long journey and let the world burn around you. ");

    val = Console.ReadLine();
}
else if (val == "2")
{
    Console.WriteLine("As you masterfully prepare your fire magic you see a small red glow start emerging from your hand, it quickly turns into a small flame and the bandits start backing off visibly frightened, the small flame in your hand grows to the size of a big fireball as you prepare to throw it, you now realize you never knew how to wield fire magic and end up reversing the fireball in your own face. You die.");
    val = Console.ReadLine();
}
else if (val == "3")
{
    Console.WriteLine("You drop down to your knees begging for mercy and offering the bandits all your gold, they laugh and attack you stabbing you to death as you scream like a little coward.");
    val = Console.ReadLine();
}


if (val == "a")
{
    Console.WriteLine($"You rush into the castle, attacking every guard in your way and killing them, upon reaching the throne room you charge at the emperor doing a backflip over the guard charging you and chopping the emperor's head off, the people accept you as a new worthy emperor, you steal the old emperor's wife and live your life out with her. Congratulations {name} the Emperor");
    val = Console.ReadLine();
}
else if (val == "b")
{
    Console.WriteLine("You enter the castle, he shouts for you to enter the great hall. You hear the big old doors begin to creak as they start opening, there he is, the Emperor. He is a frail man with small bits of gray hair and a long gray beard, he sits in the middle of the room, the pathway towards him is surrounded by guards. He orders you to approach him and you reluctantly listen, he asks you to become his knight and seek out the feared Storm Dragon. Your true journey begins now.");
    val = Console.ReadLine();
}
else if (val == "c")
{
    Console.WriteLine("So you decide to end your journey right as you were about to reach your goal. You have fought battles and made tough choices, you settle down to live out the rest of your life in peace. You watch as the outside world does down in flames when the Storm Dragon attacks but you sip your coffee.");
    val = Console.ReadLine();
}