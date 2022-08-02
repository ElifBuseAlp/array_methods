// ----------------- array methodları --------------------------

int[] dizi = { 23,89,54,6,7,1,13,45};

//-------sırasız dizi---------

foreach (var sayi in dizi)
{
    Console.WriteLine(sayi);
}

//-----sıralı dizi----------
Console.WriteLine("------------------sıralı dizi-------------");


Array.Sort(dizi);

foreach (var sayi in dizi)
{
    Console.WriteLine(sayi);
}

Console.WriteLine("------------------array clear------------");

Array.Clear( dizi, 2, 3);

foreach (var sayi in dizi)
{
    Console.WriteLine(sayi);
}


Console.WriteLine("------------------array reverse------------");

Array.Reverse(dizi);

foreach (var sayi in dizi)
{
    Console.WriteLine(sayi);
}

Console.WriteLine("------------------array IndexOf------------");

Console.WriteLine(Array.IndexOf(dizi,6));

Console.WriteLine("------------------array resize------------");

Array.Resize<int>(ref dizi, 9);
dizi[8] = 89;

foreach (var sayi in dizi)
{
    Console.WriteLine(sayi);
}


int a  =  dizi.GetLength(0);

Console.WriteLine("Bu dizi: " + a  + " elemanlıdır.");
Console.ReadLine();


Array.Resize<int>(ref dizi, 3);

foreach (var sayi in dizi)
{
    Console.WriteLine(sayi);
}