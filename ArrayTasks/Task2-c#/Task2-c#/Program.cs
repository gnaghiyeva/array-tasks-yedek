// See https://aka.ms/new-console-template for more information
int[] array = { 1, 2, 3, 4, 5 };
int cem = 0;
int edediOrta;

for (int i = 0; i < array.Length; i++)
{
    cem += array[i];

}

edediOrta = cem / array.Length;

Console.WriteLine("ededi orta = " + edediOrta);

