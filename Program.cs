﻿/*

Console.WriteLine("Hello, World!");

// Create simple for loop 
for (int i = 0; i < 15; i++)
{
    Console.WriteLine(i);
}


// data types
int number = 5;//asign int number = 5
number = 10; //now number takes the value of 10 

float bodyTemp = 36.6f; //add f for float
double bodyTemp2 = 36.6;
decimal money = 200.5m; // add m for decimal

bool check = true; //boolean can be only true or false
bool secondCheck = false;

char symbol = '*';

string name = "Gosho";

// example of wrong names: 
int myFirstIntVar = 3;
int myfirstintvar = 8; //the code will work, but it is wrong! 

//calculate 

int a = 5;
int b = 10;
int calc = a + b;
int c = a - b;
int d = a / b;
int e = a * b;

int aa = 11;
int bb = 2;
double res = 11 / 2.0; //we add .0 so the result become double. In double we can have int values.

int numb = 5;
numb++; //will add +1 to the result
numb--; // will remove -1;

//If x % 5 = ? then possible outcome is 0,1,2,3,4;

//If x % 2 = 0 четно ако е 1 е нечетно.

//comparison operators    >, >=, <, <=, ==, != 

Console.WriteLine(calc);


string input = Console.ReadLine(); // reads users input as a string
int num = int.Parse(input); // takes string inoput and converts it to int
double dd = double.Parse(Console.ReadLine());
float ff = float.Parse(Console.ReadLine());
decimal deci = decimal.Parse(Console.ReadLine());

*/
Console.WriteLine("Enter number one:");
int numOne = int.Parse(Console.ReadLine());
Console.WriteLine("Enter number two");
int numTwo = int.Parse(Console.ReadLine());
Console.WriteLine(numOne + numTwo);