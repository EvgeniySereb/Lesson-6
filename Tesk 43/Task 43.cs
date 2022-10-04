void input (string [] a , double[] mass )
{
    int i =0;
    
    
for ( i = 0; i < a.Length; i++ )
{
    Console.Write("Введите "  + a[i] + " ");
    mass[i] = double.Parse(Console.ReadLine());
}
}


void schet(double [] mass)
{
    if (mass[0] != mass[1])
    {

double x = (mass[3] - mass[2])/ (mass[0] - mass[1]);
double y = mass[0] * (mass[3] - mass[2]) / (mass[0] - mass[1]) + mass[2];
Console.WriteLine($"({x } ; {y })");
    }
else if (mass [2] == mass [3] && mass[0] == mass[1])
{
    Console.WriteLine("Прямые совпадают");

}
else
{
    Console.WriteLine("Прямые параллельные");
}


}





string[] str = {"k1" ,"k2", "b1", "b2"};
double[] m = new double[4];

input(str , m);
schet(m);