using System;

namespace FPsetul1probleme
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Buna ziua si va multumesc pentru atentie!\n\n" +
                "Ma numesc Josanu Ion, student anul I la Facutlatea de Informatica si Stiinte a Univsersitatii din Oradea, specializarea Informatica.\n\n" +
                "Acesta este primul set de probleme rezolvate la disciplina Fundamentele Programarii.\n\n" +
                "Va rog sa introduceti numarul problemei(1-21) pentru verificare :");

            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1: Console.WriteLine("Conditia : Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare. "); P1(); break;
                case 2: Console.WriteLine("Conditia : Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibile."); P2(); break;
                case 3: Console.WriteLine("Conditia : Determinati daca n se divide cu k, unde n si k sunt date de intrare."); P3(); break;
                case 4: Console.WriteLine("Conditia : Detreminati daca un an y este an bisect."); P4(); break;
                case 5: Console.WriteLine("Conditia : Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga. "); P5(); break;
                case 6: Console.WriteLine("Conditia : Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi."); P6(); break;
                case 7: Console.WriteLine("Conditia : (Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor. "); P7(); break;
                case 8: Console.WriteLine("Conditia : (Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare.\n" +
                    "Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare."); P8(); break;
                case 9: Console.WriteLine("Conditia : Afisati toti divizorii numarului n. "); P9(); break;
                case 10: Console.WriteLine("Conditia : Test de primalitate: determinati daca un numar n este prim."); P10(); break;
                case 11: Console.WriteLine("Conditia : Afisati in ordine inversa cifrele unui numar n."); P11(); break;
                case 12: Console.WriteLine("Conditia : Determinati cate numere integi divizibile cu n se afla in intervalul [a, b]."); P12(); break;
                case 13: Console.WriteLine("Conditia : Determianti cati ani bisecti sunt intre anii y1 si y2."); P13(); break;
                case 14: Console.WriteLine("Conditia : Determianti daca un numar n este palindrom. (un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321."); P14(); break;
                case 15: Console.WriteLine("Conditia : Se dau 3 numere. Sa se afiseze in ordine crescatoare. "); P15(); break;
                case 16: Console.WriteLine("Conditia : Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri)"); P16(); break;
                case 17: Console.WriteLine("Conditia : Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. Folositi algoritmul lui Euclid."); P17(); break;
                case 18: Console.WriteLine("Conditia : Afisati descompunerea in factori primi ai unui numar n.  De ex. pentru n = 1176 afisati 2^3 x 3^1 x 7^2. "); P18(); break;
                case 19: Console.WriteLine("Conditia : Determinati daca un numar e format doar cu 2 cifre care se pot repeta. De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt. "); P19(); break;
                case 20: Console.WriteLine("Conditia : Afisati fractia m/n in format zecimal, cu perioada intre paranteze (daca e cazul). Exemplu: 13/30 = 0.4(3)."); P20(); break;
                case 21: Console.WriteLine("Conditia : Ghiciti un numar intre 1 si 1024 prin intrebari de forma 'numarul este mai mare sau egal decat x ? '. "); P21(); break;
            }


        }

        private static void P21()
        {
            Random rnd = new Random();
            int x = rnd.Next(1, 1024);
            Console.WriteLine($"random={x}"); //dezactivati comentariul pentru a observa daca programul functioneaza corect
            int n = 0;
            int NrIntrebare = 0;
            while (n !=x && NrIntrebare!=2)
            {
                Console.Write("Intrebari:\n" +
                    "1='Numarul este mai mic sau decat x?'\n" +
                    "2='Numarul este mai egal cu x?'\n" +
                    "3='Numarul este mai mare sau egal de cit x?'\n" +
                    "Introduceti o cifra corespunzatoare unei intrebari:");
                NrIntrebare = int.Parse(Console.ReadLine());
                Console.Write("Introduceti numarul ghicit de dumnea voastra, adica x : ");
                 n = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (NrIntrebare)
                {
                    case 1:
                        Console.WriteLine($"Intrebare: Numarul este mai mic sau egal de cit {n}?");
                        if (x<=n)
                        {
                            Console.WriteLine("Raspuns: DA, sunteti pe calea cea dreapta!");
                        }
                        else
                        {
                            Console.WriteLine("Raspuns: NU, mai incercati!");
                        }
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine($"Intrebare: Numarul este egal cu {n}?");
                        if (n == x)
                        {
                            Console.WriteLine("Raspuns: DA. Felicitari, ati ghicit numarul!!!!!!");
                        }
                        else
                        {
                            Console.WriteLine("Raspuns: NU, mai incercati!");
                        }
                        break;
                    case 3:
                        Console.WriteLine($"Intrebare: Numarul este mai mare sau egal de cit {n}?");
                        if (x>=n)
                        {
                            Console.WriteLine("Raspuns: DA, sunteti pe calea cea drepta!");
                        }
                        else
                        {
                            Console.WriteLine("Raspuns: NU, mai incercati!");
                        }
                        Console.ReadKey();
                        break;
                }

            }
        }

        private static void P20()
        {
            Console.Write("Introduceti numaratorul fractiei :  ");
            double  m = double.Parse(Console.ReadLine());
            Console.Write("Introduceti numitorul fractiei : ");
            double n = double.Parse(Console.ReadLine());

            

            if (m%n==0)
            {
                Console.WriteLine($"{m}/{n}={m/n}");
            }
            else
            {
                double z = m / n;
                Console.WriteLine(z);
                Console.Write($"{Math.Truncate(z)},");
                double pz = z - Math.Truncate(z);
                pz = pz * 10;
                while( (Math.Truncate(pz)%10) != null)
                {
                    if (Math.Truncate(pz)%10==Math.Truncate(pz*10)%10)
                    {
                        Console.Write("({0})",Math.Truncate(pz)%10);
                        break;
                    }
                    else if (Math.Truncate(pz*10) % 100 == Math.Truncate(pz * 1000) % 100)
                    {
                        Console.Write("({0})", Math.Truncate(pz*10) % 100);
                        break;
                    }
                    else
                    {
                        Console.Write(Math.Truncate(pz)%10);
                    }
                    pz = pz * 10;

                }


            }
        }

        private static void P19()
        {
            Console.Write("Introduceti un numar format din mai mult de 2 cifre : ");
            int n = int.Parse(Console.ReadLine());
            int v1, v2, p=-1;
            v1 = n % 10;
            n = n / 10;
            p = v1;
            while(n>0 && p==v1)
            {
                p = n % 10;
                n = n / 10;
            }
            v2 = p;
            if (n > 0)
            {
                while (n > 0 && (p == v1 || p == v2))
                {
                    p = n % 10;
                    n = n / 10;
                }
            }
            if (p!=v1||p!=v2)
            {
                Console.WriteLine("Numarul introdus este format din mai mult de 2 cifre");
            }
            if (p==v2)
            {
                Console.WriteLine($"Numarul introdus  este format di cifrele : {v1} si {v2}");
            }

        }

        private static void P18()
        {
            Console.Write("introduceti un numar n : ");
            int n = int.Parse(Console.ReadLine());
            int d = 2;
            int p;
            if (n==1)
            {
                Console.WriteLine(1);
            }
            if (n>1)
            {
                Console.WriteLine($"Descompunerea in factori primi a numarului {n} : ");
            }
            while (n>1)
            {
                p = 0;
                while (n % d == 0)
                {
                    p++;
                    n /= d;
                }
                if (p>=1)
                {
                    Console.WriteLine(d + " x " + p);
                }
               d++;
                if (n > 1 && d * d > n)
                {
                    d = n; 
                }
            }

        }

        private static void P17()
        {
            Console.Write( " Introduceti primul numar : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write(" Introduceti al doilea numar : ");
            int b = int.Parse(Console.ReadLine());
            int n = a;
            int m = b;
            while (n!=m)
            {
                if (n>m)
                {
                    n = n - m;
                }
                else
                {
                    m = m - n;
                }
            }
            Console.WriteLine("Cel mai mare divizor comun este: {0}",n);
            int cmmmc = (a * b) / n;
            Console.WriteLine("Cel mai mic multiplu comun este : {0}",cmmmc);

        }

        private static void P16()
        {
            Console.Write("Introduceti primul numar : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Introduceti al 2-lea numar : ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Introduceti al 3-lea numar : ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Introduceti al 4-lea numar : ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("Introduceti al 5-lea numar : ");
            int e = int.Parse(Console.ReadLine());
            int x1 =0, x2 =0, x3 = 0, x4 = 0, x5 = 0;

            if(a>b&&a>c&&a>d&&a>e)
            {
                x5=a;
                if (b>c && b > d && b > e)
                {
                    x4 = b;
                    if (c>d&&c>e)
                    {
                        x3 = c;
                        if (d > e)
                        {
                            x2 = d;
                            x1 = e;
                        }
                        else
                        {
                            x2 = e;
                            x1 = d;
                        }
                    }
                    if (d>c&&d>e)
                    {
                        x3 = d;
                        if (c>e)
                        {
                            x2 = c;
                            x1 = e;
                        }
                        else 
                        {
                            x2 = e;
                            x1 = c;
                        }

                    }
                    if (e>c&&e>d)
                    {
                        x3 = e;
                        if (c > d)
                        {
                            x2 = c;
                            x1 = d;
                        }
                        else 
                        {
                            x2 = d;
                            x1 = c;
                        }
                    }
                }

                if (c>b&&c>d&&c>e)
                {
                    x4 = c;
                    if (b>d&&b>e)
                    {
                        x3 = b;
                        if (d > e)
                        {
                            x2 = d;
                            x1 = e;
                        }
                        else
                        {
                            x2 = e;
                            x1 = d;
                        }
                    }
                    if (d > b && d > e)
                    {
                        x3 = d;
                        if (b>e)
                        {
                            x2 = b;
                            x1 = e;
                        }
                        else
                        {
                            x2 = e;
                            x1 = b;
                        }
                    }
                    if (e>b&&e>d)
                    {
                        x3 = d;
                        if (b>d)
                        {
                            x2 = b;
                            x1 = d;
                        }
                        else
                        {
                            x2 = d;
                            x1 = b;
                        }
                    }
                }

                if (d>b&&d>c&&d>e)
                {
                    x4 = d;
                    if (b>c&&b>e)
                    {
                        x3 = b;
                        if (c>e)
                        {
                            x2 = c;
                            x1 = e;
                        }
                        else
                        {
                            x2 = e;
                            x1 = c;
                        }

                    }
                    if (c>b&&c>e)
                    {
                        x3 = c;
                        if (b > e)
                        {
                            x2 = b;
                            x1 = e;
                        }
                        else
                        {
                            x2 = e;
                            x1 = b;
                        }
                    }
                    if (e>b&&e>d)
                    {
                        x3 = e;
                        if (b > d)
                        {
                            x2 = b;
                            x1 = d;
                        }
                        else
                        {
                            x2 = d;
                            x1 = b;
                        }

                    }

                }

                if (e>b&&e>c&&e>d)
                {
                    if (b>c&&b>d)
                    {
                        x3 = b;
                        if (c > d)
                        {
                            x2 = c;
                            x1 = d;
                        }
                        else
                        {
                            x2 = d;
                            x1 = c;
                        }
                    }
                    if (c>b&&c>d)
                    {
                        x3 = c;
                        if (b > d)
                        {
                            x2 = b;
                            x1 = d;
                        }
                        else
                        {
                            x2 = d;
                            x1 = b;
                        }

                    }
                    if (d>b&&d>c)
                    {
                        x3 = d;
                        if (b>c)
                        {
                            x2 = b;
                            x1 = c;
                        }
                        else
                        {
                            x2 = c;
                            x1 = b;
                        }
                    }
                   
                }
            }
            if(b>a&&b>c&&b>d&&b>e)
            {
                x5 = b;
                if (a>c&&a>d&&a>e)
                {
                    x4 = a;
                    if(c>d&&c>e)
                    {
                        x3 = c;
                        if (d > e)
                        {
                            x2 = d;
                            x1 = e;
                        }
                        else
                        {
                            x2 = e;
                            x1 = d;
                        }
                    }
                    if (d>c&&d>e)
                    {
                        x3 = d;
                        if (c > e)
                        {
                            x2 = c;
                            x1 = e;
                        }
                        else
                        {
                            x2 = e;
                            x1 = c;
                        }
                    }
                    if (e>c&&e>d)
                    {
                        x3 = e;
                        if (c > d)
                        {
                            x2 = c;
                            x1 = d;
                        }
                        else
                        {
                            x2 = d;
                            x1 = c;
                        }
                    }
                }
                if (c>a&&c>d&&c>e)
                {
                    x4 = c;
                    if (a>d&&a>e)
                    {
                        x3 = a;
                        if (d > e)
                        {
                            x2 = d;
                            x1 = e;
                        }
                        else
                        {
                            x2 = e;
                            x1 = d;
                        }


                    }
                    if (d>a&&d>e)
                    {
                        x3 = d;
                        if (a>e)
                        {
                            x2 = a;
                            x1 = e;
                        }
                        else
                        {
                            x2 = e;
                            x1 = a;
                        }
                    }
                    if (e>a&&e>d)
                    {
                        x3 = e;
                        if (a>d)
                        {
                            x2 = a;
                            x1 = d;

                        }
                        else
                        {
                            x2 = d;
                            x1 = a;
                        }

                    }

                }
                if (d>a&&d>c&&d>e)
                {
                    x4 = d;
                    if (a>c&&a>e)
                    {
                        x3 = a;
                        if (c > e)
                        {
                            x2 = c;
                            x1 = e;
                        }
                        else
                        {
                            x2 = e;
                            x1 = c;
                        }
                    }
                    if (c>a&&c>e)
                    {
                        x3 = c;
                        if (a > e)
                        {
                            x2 = a;
                            x1 = e;
                        }
                        else
                        {
                            x2 = e;
                            x1 = a;
                        }
                    }
                    if (e>a&&e>c)
                    {
                        x3 = e;
                        if (a > c)
                        {
                            x2 =a;
                            x1 = c;
                        }
                        else
                        {
                            x2 = c;
                            x1 = a;
                        }
                    }
                }
                if (e>a&&e>c&&e>d)
                {
                    x4 = e;
                    if (a>c&&a>d)
                    {
                        x3 = a;
                        if (c > d)
                        {
                            x2 = c;
                            x1 = d;
                        }
                        else
                        {
                            x2 = d;
                            x1 = c;
                        }
                    }
                    if (c>a&&c>d)
                    {
                        x3 = c;
                        if (a > d)
                        {
                            x2 = a;
                            x1 = d;

                        }
                        else
                        {
                            x2 = d;
                            x1 = a;
                        }
                    }
                    if (d>a&&d>c)
                    {
                        x3 = d;
                        if (a > c)
                        {
                            x2 = a;
                            x1 = c;
                        }
                        else
                        {
                            x2 = c;
                            x1 = a;
                        }
                    }
                }
            }
            if(c > a && c > b && c > d && c > e)
            {
                x5 = c;
                if (a>b&&a>d&&a>e)
                {
                    x4 = a;
                    if (b>d&&b>e)
                    {
                        x3 = b;
                        if (d > e)
                        {
                            x2 = d;
                            x1 = e;
                        }
                        else
                        {
                            x2 = e;
                            x1 = d;
                        }
                    }
                    if (d>b&&d>e)
                    {
                        x3 = d;
                        if (b > e)
                        {
                            x2 = b;
                            x1 = e;
                        }
                        else
                        {
                            x2 = e;
                            x1 = b;
                        }
                    }
                    if (e>b&&e>d)
                    {
                        x3 = e;
                        if (b > d)
                        {
                            x2 = b;
                            x1 = d;
                        }
                        else
                        {
                            x2 = d;
                            x1 = b;
                        }
                    }
                }
                if (b>a&&b>d&&b>e)
                {
                    x4 = b;
                    if (a>d&&a>e)
                    {
                        x3 = a;
                        if (d > e)
                        {
                            x2 = d;
                            x1 = e;
                        }
                        else
                        {
                            x2 = e;
                            x1 = d;
                        }
                    }
                    if (d>a&&d>e)
                    {
                        x3 = d;
                        if (a > e)
                        {
                            x2 = a;
                            x1 = e;
                        }
                        else
                        {
                            x2 = e;
                            x1 = a;
                        }
                    }
                    if (e > a && e > d)
                    {
                        x3 = e;
                        if (a > d)
                        {
                            x2 = a;
                            x1 = d;
                        }
                        else
                        {
                            x2 = d;
                            x1 = a;
                        }
                    }

                }
                if (d>a&&d>b&&d>e)
                {
                    x4 = d;
                    if (a>b&&a>e)
                    {
                        x3 = a;
                        if (b > e)
                        {
                            x2 = b;
                            x1 = e;
                        }
                        else
                        {
                            x2 = e;
                            x1 = b;
                        }
                    }
                    if (b>a&&b>e)
                    {
                        x3 = b;
                        if (a > e)
                        {
                            x2 = a;
                            x1 = e;
                        }
                        else
                        {
                            x2 = e;
                            x1 = a;
                        }
                    }
                    if (e>a&&e>b)
                    {
                        x3 = e;
                        if (a > b)
                        {
                            x2 = a;
                            x1 = b;
                        }
                        else
                        {
                            x2 = b;
                            x1 = a;
                        }
                    }
                }
                if (e>a&&e>b&&e>d)
                {
                    x4 = e;
                    if (a>b&&a>d)
                    {
                        x3 = a;
                        if (b > d)
                        {
                            x2 = b;
                            x1 = d;
                        }
                        else
                        {
                            x2 = d;
                            x1 = b;
                        }
                    }
                    if (b>a&&b>d)
                    {
                        x3 = b;
                        if (a > d)
                        {
                            x2 = a;
                            x1 = d;
                        }
                        else
                        {
                            x2 = d;
                            x1 = a;
                        }
                    }
                    if (d>a&&d>b)
                    {
                        x3 = d;
                        if (a > b)
                        {
                            x2 = a;
                            x1 = b;
                        }
                        else
                        {
                            x2 = b;
                            x1 = a;
                        }
                    }
                }
            }
            if (d>a&&d>b&&d>c&&d>e)
            {
                x5 = d;
                if (a>b&&a>c&&a>e)
                {
                    x4 = a;
                    if (b>c&&b>e)
                    {
                        x3 = b;
                        if (c > e)
                        {
                            x2 = c;
                            x1 = e;
                        }
                        else
                        {
                            x2 = e;
                            x1 = c;
                        }
                    }
                    if (c>b&&c>e)
                    {
                        x3 = c;
                        if (b > e)
                        {
                            x2 = b;
                            x1 = e;
                        }
                        else
                        {
                            x2 = e;
                            x1 = b;
                        }
                    }
                    if (e>b&&e>c)
                    {
                        x3 = e;
                        if (b > c)
                        {
                            x2 = b;
                            x1 = c;
                        }
                        else
                        {
                            x2 = c;
                            x1 = b;
                        }
                    }
                }

                if (b>a&&b>c&&b>e)
                {
                    x4 = b;
                    if (a>c&&a>e)
                    {
                        x3 = a;
                        if (c > e)
                        {
                            x2 = c;
                            x1 = e;
                        }
                        else
                        {
                            x2 = e;
                            x1 = c;
                        }
                    }
                    if (c>a&&c>e)
                    {
                        x3 = c;
                        if (a > e)
                        {
                            x2 = a;
                            x1 = e;
                        }
                        else
                        {
                            x2 = e;
                            x1 = a;
                        }
                    }
                    if (e>a&&e>c)
                    {
                        x3 = e;
                        if (a > c)
                        {
                            x2 = a;
                            x1 = c;
                        }
                        else
                        {
                            x2 = c;
                            x1 = a;
                        }
                    }
                }

                if (c>a&&c>b&&c>e)
                {
                    x4 = c;
                    if (a>b&&a>e)
                    {
                        x3 = a;
                        if (b > e)
                        {
                            x2 = b;
                            x1 = e;
                        }
                        else
                        {
                            x2 = e;
                            x1 = b;
                        }
                    }
                    if (b>a&&b>e)
                    {
                        x3 = b;
                        if (a > e)
                        {
                            x2 = a;
                            x1 = e;
                        }
                        else
                        {
                            x2 = e;
                            x1 = a;
                        }
                    }
                    if (e>a&&e>b)
                    {
                        x3 = e;
                        if (a > b)
                        {
                            x2 = a;
                            x1 = b;
                        }
                        else
                        {
                            x2 = b;
                            x1 = a;
                        }
                    }
                }

                if (e>a&&e>b&&e>c)
                {
                    x4 = e;
                    if (a>b&&a>c)
                    {
                        x3 = a;
                        if (b > c)
                        {
                            x2 = b;
                            x1 = c;
                        }
                        else
                        {
                            x2 = c;
                            x1 = b;
                        }
                    }
                    if (b>a&&b>c)
                    {
                        x3 = b;
                        if (a > c)
                        {
                            x2 = a;
                            x1 = c;
                        }
                        else
                        {
                            x2 = c;
                            x1 = a;
                        }
                    }
                    if (c>a&&c>b)
                    {
                        x3 = c;
                        if (a > b)
                        {
                            x2 = a;
                            x1 = b;
                        }
                        else
                        {
                            x2 = b;
                            x1 = a;
                        }
                    }
                }
            }

            if (e>a&&e>b&&e>c&&e>d)
            {
                x5 = e;
                if (a>b&&a>c&&a>d)
                {
                    x4 = a;
                    if (b>c&&b>d)
                    {
                        x3 = b;
                        if (c > d)
                        {
                            x2 = c;
                            x1 = d;
                        }
                        else
                        {
                            x2 = d;
                            x1 = c;
                        }
                    }
                    if (c>b&&c>d)
                    {
                        x3 = c;
                        if (b > d)
                        {
                            x2 = b;
                            x1 = d;
                        }
                        else
                        {
                            x2 = d;
                            x1 = b;
                        }
                    }
                    if (d>b&&d>c)
                    {
                        x3 = d;
                        if (b > c)
                        {
                            x2 = b;
                            x1 = c;
                        }
                        else
                        {
                            x2 = c;
                            x1 = b;
                        }
                    }
                }
                if (b>a&&b>c&&b>d)
                {
                    x4 = b;
                    if (a>c&&a>d)
                    {
                        x3 = a;
                        if (c > d)
                        {
                            x2 = c;
                            x1 = d;
                        }
                        else
                        {
                            x2 = d;
                            x1 = c;
                        }
                    }
                    if (c>a&&c>d)
                    {
                        x3 = c;
                        if (a > d)
                        {
                            x2 = a;
                            x1 = d;
                        }
                        else
                        {
                            x2 = d;
                            x1 = a;
                        }
                    }
                    if (d>a&&d>c)
                    {
                        x3 = d;
                        if (a > c)
                        {
                            x2 = a;
                            x1 = c;
                        }
                        else
                        {
                            x2 = c;
                            x1 = a;
                        }
                    }
                }
                if (c>a&&c>b&&c>d)
                {
                    x4 = c;
                    if (a>b&&a>d)
                    {
                        x3 = a;
                        if (b > d)
                        {
                            x2 = b;
                            x1 = d;
                        }
                        else
                        {
                            x2 = d;
                            x1 = b;
                        }
                    }
                    if (b>a&&b>d)
                    {
                        x3 = b;
                        if (a > d)
                        {
                            x2 = a;
                            x1 = d;
                        }
                        else
                        {
                            x2 = d;
                            x1 = a;
                        }
                    }
                    if (d>a&&d>b)
                    {
                        x3 = d;
                        if (a > b)
                        {
                            x2 = a;
                            x1 = b;
                        }
                        else
                        {
                            x2 = b;
                            x1 = a;
                        }
                    }
                }
                if (d>a&&d>b&&d>c)
                {
                    x4 = d;
                    if (a>b&&a>c)
                    {
                        x3 = a;
                        if (b > c)
                        {
                            x2 = b;
                            x1 = c;
                        }
                        else
                        {
                            x2 = c;
                            x1 = b;
                        }
                    }
                    if (b>a&&b>c)
                    {
                        x3 = b;
                        if (a > c)
                        {
                            x2 = a;
                            x1 = c;
                        }
                        else
                        {
                            x2 = c;
                            x1 = a;
                        }
                    }
                    if (c>a&&c>b)
                    {
                        x3 = c;
                        if (a > b)
                        {
                            x2 = a;
                            x1 = b;
                        }
                        else
                        {
                            x2 = b;
                            x1 = a;
                        }
                    }

                }
            }
            Console.WriteLine("Numerele in ordine crescatoare sunt: {0} {1} {2} {3} {4}", x1, x2, x3, x4, x5);

        }

        private static void P15()
        {
            Console.Write("Introduceti primul numar : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Introduceti al doilea numar : ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Introduceti al treilea numar : ");
            int c = int.Parse(Console.ReadLine());
            int maxim=0, mijloc=0, minim=0;
            if (a > b && a > c) 
            {
                maxim=a;
                if (b > c)
                {
                    mijloc = b;
                    minim = c;
                }
                else 
                {
                    mijloc = c;
                    minim = b;
                }
            }

            if (b > a && b > c)
            {
                maxim = b;
                if (a > c)
                {
                    mijloc = a;
                    minim = c;
                }
                else
                {
                    mijloc = c;
                    minim = a;
                }
            }

            if (c > a && c > b)
            {
                maxim = c;
                if (a > b)
                {
                    mijloc = a;
                    minim = b;
                }
                else
                {
                    mijloc = b;
                    minim = a;
                }
            }
            Console.WriteLine("Numerele in odine crescatoare sunt : {0}, {1}, {2}", minim, mijloc, maxim);
        }

        private static void P14()
        {
            Console.WriteLine("Introduceti un numar n : ");
            int n = int.Parse(Console.ReadLine());
            int oglindit = 0;
            int local;
            int m = n;
            while (m != 0)
            {
                local = m % 10;
                oglindit = oglindit * 10 + local;
                m = m / 10;
            }
            
            if (oglindit == n)
            {
                Console.WriteLine("Numarul {0} este palindrom.", n);
            }
            else { Console.WriteLine("Numarul {0} NU este palindrom.", n); }
            
        }
        
        private static void P13()
        {
            int y1, y2, nr=0;

            Console.Write("Introduceti primul an : ");
            y1=int.Parse(Console.ReadLine());
            Console.Write("Introduceti al doilea an : ");
            y2 = int.Parse(Console.ReadLine());
            for (int i = y1+1; i <y2; i++)
            {
                if (i%4==0 && i%100!=0)
                {
                    nr =nr+1;
                }

            }
            Console.WriteLine("Intre anul {0} si anul {1} sunt {2} ani bisecti.",y1,y2,nr);
        }

        private static void P12()
        {
            Console.WriteLine("Dati un numar n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati primul numar al sirului [a,b]: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati ultimul numar al sirului [a,b]: ");
            int b = int.Parse(Console.ReadLine());
            int v = 0;
            int i=0;
            while (i <= b) { 
            for (i = a; i <= b; i++)
            {
                if (i % n == 0) { v = v + 1; }
            }
        }
            if (v == 0) { Console.WriteLine("In intervalul [{0}, {1}] nu sunt numere intregi divizibile cu {2}", a, b, n); }
            else
            {
                Console.WriteLine("In intervalul [{0}, {1}]  {2} numere intregi sunt divizibile cu {3}", a, b, v, n);
            }
        }

        private static void P11()
        {
            
            Console.Write("Introduceti un nuamr: ");
            int n = int.Parse(Console.ReadLine());
            int invers = 0;
            int x;
            while (n != 0)
            {
                x = n % 10;
                invers = invers * 10 + x;
                n /= 10;
            }
            Console.Write("Numarul inversat: " + invers);
        }

        private static void P10()
        {
            
            Console.Write("Dati un numar n");
            int n = int.Parse(Console.ReadLine());
            int m = n / 2;
            int v = 0;
            for (int i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    Console.Write("Numarul nu este prim");
                    v = 1;
                    break;
                }
            }
            if (v == 0)
                Console.Write("Numarul este prim");
        }

        private static void P9()
        {
            Console.WriteLine("Dati un numar n :");
           int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Divizorii lui {0} sunt :", n);
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    Console.WriteLine("{0}", i);
            }


        }

        private static void P8()
        {
            Console.WriteLine("Dati un numar a :");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati un numar b :");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("a={0}, b={1}", a, b);
            a = a * b;
            b = a / b;
            a = a / b;

            Console.WriteLine("a={0}, b={1}", a, b);
        }

        private static void P7()
        {
            
            Console.WriteLine("Dati un numar a :");
           int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati un numar b :");
           int b = int.Parse(Console.ReadLine());
            Console.WriteLine("a={0}, b={1}", a, b);
            int v;
            v = a;
            a = b;
            b = v;

            Console.WriteLine("a={0}, b={1}", a, b);
        }

        private static void P6()
        {
            Console.WriteLine("Introduceti numarul ntural nenul a:");
            int a =int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numarul ntural nenul b:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numarul ntural nenul c:");
            int c = int.Parse(Console.ReadLine());

            if ((a < b + c) && (b < a + c) && (c < a + b))
            {
                Console.WriteLine("Numerele pot forma un triunghi");
            }
            else { Console.WriteLine("Numerele nu pot forma un triunghi"); }
        }

        private static void P5()
        {
            Console.WriteLine("Dati un numar format din mai multe cifre : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati un numar k, care va reprezenta a cata cifra de la sfirsitul numarului de mai sus vreti sa fie reprezentata :");
            int k = int.Parse(Console.ReadLine());
            int cifra = 0;
            int p = 1;
            int u = 1;
            for (int i = 1; i <=k; i++)
            {
                p = p * 10;
            }
            for (int j = 1; j <k; j++)
            {
                u = u * 10;
            }
            cifra = (n % p) / u;
            Console.WriteLine("A {0}-a cifra de la urma numarului {1} este {2}",k,n,cifra);
        }

        private static void P4()
        {
            Console.WriteLine("Introduceti un an dupa Hristos:");
            int y = int.Parse(Console.ReadLine());
            if(y%4==0 && y%100!=0)
            { Console.WriteLine("Anul {0} este bisect",y); }
            else { Console.WriteLine("Anul {0} nu este bisect", y); }
         

        }

        private static void P3()
        {
            int n, k;
            Console.WriteLine("Dati numarul n:");
           n= int.Parse(Console.ReadLine());
            Console.WriteLine("Dati numarul k:");
            k = int.Parse(Console.ReadLine());
            if (n % k == 0)
            {
                Console.WriteLine("n={0} se divide la k={1}",n,k);
            }
            else { Console.WriteLine("n={0} nu se divide la k={1}", n, k); }
        }

        private static void P2()
        {
            float a, b, c, x1, x2, d;
            Console.WriteLine("Dati coeficientul a :");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Dati coeficientul b :");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Dati coeficientul c :");
            c = float.Parse(Console.ReadLine());
            if (a != 0)
            {
                d = b * b - 4 * a * c;
                if (d < 0)
                    Console.WriteLine("Radacinile sunt complexe");
                else
                {
                    x1 = (float)(-b + Math.Sqrt(d)) / (2 * a);
                    x2 = (float)(-b - Math.Sqrt(d)) / (2 * a);
                    Console.WriteLine("X1={0}", x1);
                    Console.WriteLine("X2={0}", x2);
                }
            }
            else
            {
                if (b != 0)
                {
                    x1 = -c / b;
                    Console.WriteLine("Ecuatia este de gradul 1, solutia X = {0}", x1);
                }
                else
                {
                    if (c == 0)
                        Console.WriteLine("Solutia x poate fi orice numar");
                    else
                        Console.WriteLine("Ecuatia este imposibila");
                }
            }



        }

        private static void P1()
        {
            float a, b, x; 
            Console.WriteLine("Dati coeficientul a:");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Dati coeficientul b:");
            b = float.Parse(Console.ReadLine());
            if (a != 0)
            {
                x = -b / a;
                Console.WriteLine("Solutia x = {0}", x);
            }
            else
            {
                if (b == 0)
                    Console.WriteLine("Solutia x poate fi orice numar / neterminare");
                else
                    Console.WriteLine("Ecuatia este imposibila ");
            }

        }
    }
}
