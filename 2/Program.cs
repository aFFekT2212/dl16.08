int b1 = int.Parse(Console.ReadLine());
int k1 = int.Parse(Console.ReadLine());

int b2 = int.Parse(Console.ReadLine());
int k2 = int.Parse(Console.ReadLine());

double x = (b1 - b2) / ((k2 - k1) * 1.0);
double y = k2 * x + b2;
Console.WriteLine(x);
Console.WriteLine(y);