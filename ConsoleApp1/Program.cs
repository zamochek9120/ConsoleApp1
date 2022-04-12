using System;


class fff
{
    public static void Main()
    {
        string[,] hostel = new string[,] {
  { "101 ", "102", "103","201", "202", "203","301", "302", "303" },
  {"1","1","1","2","2","2","3","3","3"} ,
  { "0", "4", "3","0", "0", "3","5", "2", "1" },
  {"Shevchenko","Petrov","Ivanov"        , "Kovalenko","Samara"      ,"Masenko",null,"Shevchenko","Sarancha"},
  {"Semerenko" ,null    ,"Semerenko"     ,"Samara"    ,"Shevchenko"  ,"Samara" ,null,"Kovalenko" ,null},
  {"Ivanov"    ,null    ,null            ,"Ivanov"    ,"Kovalenko"   ,null     ,null,"Samara"    ,null},
  {"Kovalenko" ,null    ,null            ,"Shevchenko","Petrenko"    ,null     ,null,null        ,null},
  {"Petrenko"  ,null    ,null            ,"Petrenko"  ,"Sarancha"    ,null     ,null,null        ,null}
  };


        void Poisk(string[,] a, string f)
        {
            int rows = a.GetUpperBound(0) + 1;
            int columns = a.Length / rows;
            int count = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (a[i, j] == f)
                    {
                        Console.Write(f + " jivet na  " + a[1, j] + " etaje" + " v " + a[0, j] + " komnate ");

                        Console.WriteLine();
                        count += 1;
                    }
                }

            }
            if (count == 0)
            {
                Console.Write(f + " tut ne jivet");
                Console.WriteLine();
            }
        }
        void Svobodno(string[,] a)
        {
            int rows = a.GetUpperBound(0) + 1;
            int columns = a.Length / rows;
            for (int k = 5; k > 0; k--)
            {
                for (int o = columns - 1; o >= 0; o--)
                {
                    string p = k.ToString();
                    if (a[2, o] == p)
                    {
                        Console.Write("v  " + a[0, o] + " svobodno " + a[2, o] + " mest");
                        Console.WriteLine();
                    }
                }
            }

        }
        void Dobavlenie(string[,] a, int f, string k)
        {
            int rows = a.GetUpperBound(0) + 1;
            int columns = a.Length / rows;

            string l = f.ToString();
            for (int i = 0; i < rows; i++)
            {

                if (a[1, i] == l && a[2, i] != "0")
                {
                    for (int j = 0; j < columns - 1; j++)
                    {

                        if (a[j, i] == null)
                        {
                            a[j, i] = k;
                            int n = int.Parse(a[2, i]) - 1;
                            a[2, i] = n.ToString();
                            return;

                        }
                        Console.WriteLine();
                    }
                }
            }


        }
        void Udalenie(string[,] a, string f, int k)
        {
            string l = k.ToString();
            int j = 0;
            int rows = a.GetUpperBound(0) + 1;
            int columns = a.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                if (a[0, i] == l)
                {
                    j = i;
                    break;
                }
            }
            for (int i = 0; i < columns - 1; i++)
            {

                if (a[i, j] == f)
                {

                    a[i, j] = null;

                    return;
                }
            }
        }


        Poisk(hostel, "Bondarev");
        Dobavlenie(hostel, 3, "Bondarev");
        Poisk(hostel, "Bondarev");
        Udalenie(hostel, "Bondarev", 301);
        Poisk(hostel, "Bondarev");
        Console.WriteLine();

    }
}
