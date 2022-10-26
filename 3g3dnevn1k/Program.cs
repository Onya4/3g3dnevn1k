using _3g3dnevn1k;

menu m = new menu();
m.dat = new DateTime(2022, 10, 21);

Console.SetCursorPosition(10, 0);
Console.WriteLine(m.dat.ToString("dd.MM.yyyy"));
Console.SetCursorPosition(3, 1);
Console.WriteLine("Режима сна.");

int pos1 = 0;
int pos2 = 0;

Console.SetCursorPosition(pos1, pos2);
Console.WriteLine("->");
while (true)
{

    ConsoleKeyInfo kay = Console.ReadKey();
    if (kay.Key == ConsoleKey.LeftArrow)
    {
        pos1--;
        if (pos1 < 0)
            pos1 = 0;
    }
    else if (kay.Key == ConsoleKey.RightArrow)
    {
        pos1++;
        if (pos1 > 4)
            pos1 = 4;
    }
    Console.Clear();
    if (pos1 == 0)
    {
        m.dat = new DateTime(2022, 10, 21);
        Console.SetCursorPosition(10, 0);
        Console.WriteLine(m.dat.ToString("dd.MM.yyyy"));
        Console.SetCursorPosition(3, 1);
        Console.WriteLine("Режима сна.");
        if (kay.Key == ConsoleKey.Enter)
        {
            string opisanie = ("Bосстанавливаем режим сна.");
            Console.WriteLine("Описание:" + opisanie);
            m.dat = new DateTime(2022, 11, 7);
            Console.WriteLine("Дата выполнения:" + m.dat.ToString("dd.MM.yyyy"));
        }
    }
    else if (pos1 == 1)
    {
        m.dat = new DateTime(2022, 10, 24);
        Console.SetCursorPosition(10, 0);
        Console.WriteLine(m.dat.ToString("dd.MM.yyyy"));
        Console.SetCursorPosition(3, 1);
        Console.WriteLine("Чтение книг.");
        if (kay.Key == ConsoleKey.Enter)
        {
            string opisanie = ("Начать читать книги, хотя бы по страниц 20 в день.");
            Console.WriteLine("Описание:" + opisanie);
            m.dat = new DateTime(2022, 11, 14);
            Console.WriteLine("Дата выполнения:" + m.dat.ToString("dd.MM.yyyy"));
        }
    }
    else if (pos1 == 2)
    {
        m.dat = new DateTime(2022, 10, 26);
        Console.SetCursorPosition(10, 0);
        Console.WriteLine(m.dat.ToString("dd.MM.yyyy"));
        Console.SetCursorPosition(3, 1);
        Console.WriteLine("Birthday!!!");
        if (kay.Key == ConsoleKey.Enter)
        {
            string opisanie = ("Провести этот день по особенному!");
            Console.WriteLine("Описание:" + opisanie);
            List<string> friends = new List<string>() { "Arseniy", "Mark", "Artemiy", "Dasha", "Irina" };
            foreach (string Person in friends)
            {
                Console.WriteLine("Пригласительный для:" + Person);
            }
            m.dat = new DateTime(2022, 12, 13);
            Console.WriteLine("Дата выполнения:" + m.dat.ToString("dd.MM.yyyy"));
        }
    }
    else if (pos1 == 3)
    {
        m.dat = new DateTime(2022, 11, 01);
        Console.SetCursorPosition(10, 0);
        Console.WriteLine(m.dat.ToString("dd.MM.yyyy"));
        Console.SetCursorPosition(3, 1);
        Console.WriteLine("Поход в кино");
        if (kay.Key == ConsoleKey.Enter)
        {
            string opisanie = ("Сходить на Жизнь Пармы");
            Console.WriteLine("Описание:" + opisanie);
            m.dat = new DateTime(2022, 11, 4);
            Console.WriteLine("Дата выполнения:" + m.dat.ToString("dd.MM.yyyy"));
        }
    }
    else if (pos1 == 4)
    {
        m.dat = new DateTime(2022, 10, 30);
        Console.SetCursorPosition(10, 0);
        Console.WriteLine(m.dat.ToString("dd.MM.yyyy"));
        Console.SetCursorPosition(3, 1);
        Console.WriteLine("Днюха друга");
        if (kay.Key == ConsoleKey.Enter)
        {
            string opisanie = ("С Арсением и Тёмой купить пиццу и газировку и вломиться к Марку домой");
            Console.WriteLine("Описание:" + opisanie);
            m.dat = new DateTime(2022, 11, 23);
            Console.WriteLine("Дата выполнения:" + m.dat.ToString("dd.MM.yyyy"));
        }
    }
    Console.SetCursorPosition(pos1, pos2);
    Console.WriteLine("->");

}