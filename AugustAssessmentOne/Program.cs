// Assessment One:

// 1. Prompt the user to choose between a triangle or a rectangle.

//		a. Account for exeception handling for the input. 

// 2. If the user chooses triangle, prompt the user to choose between a right aligned triangle or a left aligned triangle.

//		a. Account for exception handling the input.

// 3. Prompt the user to enter the height of the triangle.

//		a. Display the triangle to the console.

// 4. If the user chooses rectangle, prompt the user to enter the height and width of the rectangle.

//		a. Account for the exception handling for the input/data type.
//		b. Display the rectangle on the console.

// 5. Create a loop for all exception/error handling.

//		a. Triangle or rectangle.
//		b. Left aligned or right aligned.
//		c. Height for the triangle.
//		d. Height and width for the rectangle.


bool invalidInput = true;

while (invalidInput)
{
	Console.WriteLine("Please select either a 'triangle' or a 'rectangle.'\n");
	Console.WriteLine("To select a triangle, please input either '1' to the console.\n");
	Console.WriteLine("To select a rectangle, please input either '2' to the console.\n");
	string userSelection = Console.ReadLine().ToLower();
	Console.WriteLine();
	if (int.TryParse(userSelection, out int validSelection))
	{
		if (validSelection == 1)
		{
			Console.WriteLine("You have selected triangle.\n");
			Console.WriteLine("Please determine if the given triangle should be either right-aligned or left-aligned: \n");
			string triAlign = Console.ReadLine().ToLower();
			Console.WriteLine();
			if (triAlign == "left")
			{
				Console.WriteLine("You have selected a left alignment. \n");
				Console.WriteLine("Please enter the height of the triangle to then display it visually to the console: \n");
				int triHeight = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine();
				int a, b;
				for (a = 0; a < triHeight; a++)
				{
					Console.WriteLine(" ");
					for (b = 0; b <= a; b++)
					{
						Console.Write("*");
					}
				}

			}
			else if (triAlign == "right")
			{
				Console.WriteLine("You have selected a right alignment. \n");
				Console.WriteLine("Please enter the height of the triangle to then display it visually to the console: \n");
				int triHeight = Convert.ToInt32(Console.ReadLine());
				int a, b, c;
				for (a = triHeight; a >= 1; a--)
				{
					for (b = 1; b <= a; b++)
					{
						Console.Write("  ");
					}
					for (c = triHeight; c >= a; c--)
					{
						Console.Write("* ");
					}
					Console.WriteLine();
				}
			}
			else
			{
				Console.WriteLine("That is not a valid alignment. Please select either right or left: \n");
				invalidInput = true;
			}
		}
		else if (validSelection == 2)
		{
			Console.WriteLine("You have selected rectangle.\n");
			Console.WriteLine("Please enter the height and width of the rectangle to then display it visually to the console: \n");
			Console.WriteLine("Please enter the height of the rectangle: \n");
			int recHeight = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine();
			Console.WriteLine("Please enter the width of the rectangle: \n");
			Console.WriteLine();
			int recWidth = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine();

			for (int i = 0; i < recHeight; i++)
			{
				for (int j = 0; j < recWidth; j++)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			}
		}
		else
		{
			Console.WriteLine("Please select an alloted input.\n");
			invalidInput = true;
		}
	}
	else
	{
		Console.WriteLine("Error: That is not a valid input.");
		invalidInput = true;
	}

}




