// See https://aka.ms/new-console-template for more information


void changeB(ref int b)
{
	b++;
}
int multiply(int a)
{
	var b = 0;
	changeB(ref b);
	return a * b;
}

int min()
{
	Console.WriteLine(multiply(3));
	return 0;
}

min();
 