// See https://aka.ms/new-console-template for more information

int[] array = { 1, 2, 3, 4, 5 };
int cem = 0;
for(int i=0; i<array.Length; i++)
{
    if (array[i] % 2 != 0)
    {
        cem += array[i];
    }

}   
  Console.WriteLine("cem = "+ cem);