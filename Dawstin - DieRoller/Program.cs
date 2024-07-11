
using Dawstin___DieRoller;

Die myDie = new Die(); // When the die is created, a random FaceValue should be set
myDie.FaceValue = 6; // Setting face value shouldn't be allowed
byte currentValue = myDie.FaceValue;
Console.ReadKey();