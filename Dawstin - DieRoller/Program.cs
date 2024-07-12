
using Dawstin___DieRoller;

Die myDie = new Die(); // When the die is created, a random FaceValue should be set
byte currentValue = myDie.FaceValue;
myDie.Roll();
myDie.Roll();
myDie.Roll();

Console.ReadKey();