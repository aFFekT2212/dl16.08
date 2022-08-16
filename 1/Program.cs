int m = Int32.Parse(Console.ReadLine());

int count = 0;
for (int i = 0; i < m; i++)
    if (Int32.Parse(Console.ReadLine()) > 0) count ++;

Console.WriteLine(count);
