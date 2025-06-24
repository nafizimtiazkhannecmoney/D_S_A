// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Declaration and initialization
int[] a = new int[6]; 

// Declare then Initialization
int[] b;
b = new int[9];

string[] s = { "a", "b" };

int[] numbers = { 999, 888, 777, 555, 666 };

Console.WriteLine(numbers[0]);
Console.WriteLine(numbers[2]);
Console.WriteLine(numbers[4]);

numbers[0] = 1000;
numbers[2] = 778;
numbers[4] = 667;

Console.WriteLine("After Update");
Console.WriteLine(numbers[0]);
Console.WriteLine(numbers[2]);
Console.WriteLine(numbers[4]);

string[] colors = { "Red", "Green", "Blue", "Yellow" };
Console.WriteLine("accessing Blue:");
Console.WriteLine(colors[2]);

Console.WriteLine("Change Yellow To Purple:");
colors[3] = "Purple";
Console.WriteLine(colors[3]);

int[] numbersToIterate = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
for (int i = 0; i < numbersToIterate.Length; i++)
{
    Console.WriteLine($"Element at {i} is : {numbersToIterate[i]}");
}

string[] names = { "Alice", "Bob", "Charlie", "Diana" };
foreach (var item in names)
{
    Console.WriteLine(item);
}

double[] dailyTemperatures = { 25.5, 27.0, 24.8, 26.1, 28.5 };
for (int i = 0; i < dailyTemperatures.Length; i++)
{
    Console.WriteLine($"Day {i+1} Temperature {dailyTemperatures[i]} Dergree " );
}

foreach (var temp in dailyTemperatures)
{
    Console.WriteLine($"Temperature : {temp}");
}

// 2x3 Matrix
int[,] matrix = new int[2, 3];

int[,] matrix2 = {
    {1, 2, 3},
    {4, 5, 6}
};

int[,] ticTacToeBoard = {
    { 1, 2, 3},
    { 4, 5, 6},
    { 7, 8, 9}
};
Console.WriteLine(ticTacToeBoard[1,1]);
Console.WriteLine(ticTacToeBoard[2,2]);
Console.WriteLine(ticTacToeBoard[0,2]);
Console.WriteLine(ticTacToeBoard[1,2]);
Console.WriteLine(ticTacToeBoard[2,1]);

// Jagged Array three rows of different lengths
int[][] toyCollections = new int[3][];

//declare the row sizes
toyCollections[0] = new int[4]; // first row has 4 elements
toyCollections[1] = new int[2]; // second row has 2 elements
toyCollections[2] = new int[3]; // third row has 3 elements

toyCollections[0][0] = 1;
toyCollections[0][1] = 2;
toyCollections[0][2] = 3;
toyCollections[0][3] = 4;

toyCollections[1][0] = 5;
toyCollections[1][1] = 6;

toyCollections[2][0] = 7;
toyCollections[2][1] = 8;
toyCollections[2][2] = 9;

Console.WriteLine("-----------------------");

for (int i = 0; i < toyCollections.Length; i++)
{
    Console.Write($"Box {i+1} : ");
    for (int j = 0; j < toyCollections[i].Length; j++)
    {
        Console.Write(toyCollections[i][j]);
    }
    Console.WriteLine();
}
int[][] toyCollections2 = new int[][]
{
    new int [] { 1, 2, 3, 4 }, // first row has 4 elements
    new int [] { 5, 6},     // second row has 2 elements
    new int [] { 7, 8, 9}  // third row has 3 elements
};

int[][] teamGoals = new int[3][];

// Number of games by each team
teamGoals[0] = new int[5]; // Team 1 played 5 games
teamGoals[1] = new int[3]; // Team 2 played 3 games
teamGoals[2] = new int[1]; // Team 3 played 1 games

// Assigning goals for each game
teamGoals[0][0] = 2; // Team 1, Game 1, 2 goals
teamGoals[0][1] = 1; // Team 1, Game 2, 1 goal
teamGoals[0][2] = 3; // Team 1, Game 3, 3 goals
teamGoals[0][3] = 0; // Team 1, Game 4, 0 goals
teamGoals[0][4] = 2; // Team 1, Game 5, 2 goals

teamGoals[1][0] = 1; // Team 2, Game 1, 1 goal
teamGoals[1][1] = 2; // Team 2, Game 2, 2 goals
teamGoals[1][2] = 0; // Team 2, Game 3, 0 goals

teamGoals[2][0] = 4; // Team 3, Game 1, 4 goals
Console.WriteLine("-----------------------");
Console.WriteLine("Goals scored by each team in their games:");

for (int i = 0; i <teamGoals.Length; i++)
{
    Console.Write($"Team {i + 1} goals: |");
    for (int j = 0; j< teamGoals[i].Length; j++)
    {
        Console.Write(teamGoals[i][j] + "|");
    }
    Console.WriteLine();
}

// Kid and sncaks example
string[][] kid = new string[3][];

kid[0] = new string[3]; // First kid has 3 snacks
kid[1] = new string[2]; // Second kid has 2 snacks
kid[2] = new string[1]; // Third kid has 1 snacks


kid[0][0] = "Apple"; // First kid's first snack
kid[0][1] = "Banana"; // First kid's second snack
kid[0][2] = "Orange"; // First kid's third snack

kid[1][0] = "Chips"; // Second kid's first snack
kid[1][1] = "Chocolate"; // Second kid's second snack

kid[2][0] = "Gummy Bears"; // Third kid's first snack

for(int i = 0; i< kid.Length; i++)
{
    Console.Write($"Kid {i+1} Snack: |");
    for(int j = 0; j < kid[i].Length; j++)
    {
        Console.Write(kid[i][j] + "|");
    }
    Console.WriteLine();
}



