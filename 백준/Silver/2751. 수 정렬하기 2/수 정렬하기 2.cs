using System.IO;

int n = int.Parse(Console.ReadLine());
int[] m = new int[n];
for (int i = 0; i < n; i++)
{
    m[i] = int.Parse(Console.ReadLine());
}

Array.Sort(m);
using (var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput())))
{
    sw.WriteLine(string.Join("\n", m));
}
