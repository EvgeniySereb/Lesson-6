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
    

double x = (mass[3] - mass[2])/ (mass[0] - mass[1]);
double y = mass[0] * (mass[3] - mass[2]) / (mass[0] - mass[1]) + mass[2];
Console.WriteLine($"({x} ; {y})");
}





string[] str = {"k1" ,"k2", "b1", "b2"};
double[] m = new double[4];
//double x = (b2 - b1) / (k1 - k2) ;
//double y  = k1 * (b2 - b1)/ (k1 - k2) + b1;
//Console.WriteLine($"({x};{y}) ");
input(str , m);
schet(m);