// Exercise 1
// Name
// 1 or 2
// Fictional universe (ie - Neverland, Fantasia, etc.)
// Item within reach
// Fear
// Drink
// Desire

#region Adventure inputs

Console.WriteLine("Hello, stranger. What is your name?");
var userName = Console.ReadLine();

Console.WriteLine($"Hello, {userName}. Please choose 1 or 2.");
var optionChoice = Console.ReadLine();

Console.WriteLine($"Death match {optionChoice} confirmed. Please identify a fictional universe.");
var uniVerse = Console.ReadLine();

Console.WriteLine("Thank you. Please identify one object in your immediate surroundings.");
var weaponChoice = Console.ReadLine();

Console.WriteLine($"A {weaponChoice}...interesting. Please identify a person/animal/thing of fear (no places).");
var userFear = Console.ReadLine();

Console.WriteLine("You may regret that. Tell me. What is the ultimate refreshment?");
var userDrink = Console.ReadLine();

Console.WriteLine($"No, {userName}! Alas, there is no going back. You have made your choice. Finally, what is the object of your deepest desire?");
var userDesire = Console.ReadLine();

#endregion 

Console.WriteLine($"Thank you, {userName}. Total Recall now initiating...");

Console.WriteLine("...Loading...");

Console.WriteLine($"Hello, {userName}. You are in death match {optionChoice}, the Nega-{uniVerse}. As per your request, here is the {weaponChoice}, your weapon of choice. This world is being ravaged by {userFear}. We do not know whether this evil can be slain but right now you are all that's left. Along with your {weaponChoice}, you have one draft of {userDrink} to replenish your strength should you need it. Although what you hope to accomplish with a {weaponChoice} and {userDrink} is beyond our understanding. Honestly, who hears 'death match {optionChoice}' and chooses a {weaponChoice} and {userDrink}? Nonetheless you are our only hope, {userName}. Slay this monstrosity and your ultimate desire, {userDesire} will be yours. I hope such a prize is worth your life. Fail and we're all doomed. Oh, and a certificate. We'll give you a certificate! Yes, now hop to it {userName}. You are not the only adventurer I will watch die...err, I mean witness greatness from today. Good luck and farewell, {userName}.");