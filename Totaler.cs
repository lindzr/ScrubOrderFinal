using System.Collections.Generic;

class Totaler : Listmaker
{
    // It creates new student objects and 
    // fills in the information for each student with a method. When no more
    // objects are added, order summation method will total the quantities of 
    // tops and bottoms of every size

    List<Student> students = new List<Student>();
    
    List<string> wtopS = new List<string>();
    List<string> wtopM = new List<string>();
    List<string> wtopL = new List<string>();
    
    List<string> mtopS = new List<string>();
    List<string> mtopM = new List<string>();
    List<string> mtopL = new List<string>();

    List<string> wpantSpetite = new List<string>();
    List<string> wpantMpetite = new List<string>();
    List<string> wpantLpetite = new List<string>();
    
    List<string> wpantSregular = new List<string>();
    List<string> wpantMregular = new List<string>();
    List<string> wpantLregular = new List<string>();
    
    List<string> wpantStall = new List<string>();
    List<string> wpantMtall = new List<string>();
    List<string> wpantLtall = new List<string>();
    
    List<string> mpantSshort = new List<string>();
    List<string> mpantMshort = new List<string>();
    List<string> mpantLshort = new List<string>();
    
    List<string> mpantSregular = new List<string>();
    List<string> mpantMregular = new List<string>();
    List<string> mpantLregular = new List<string>();
    
    List<string> mpantStall = new List<string>();
    List<string> mpantMtall = new List<string>();
    List<string> mpantLtall = new List<string>();


    public void NewStudent()
    {
        string newStudent = "y";

        while (newStudent == "y" || newStudent == "yes")
        {
            Console.WriteLine("");
            Console.Write("What is the gender (m/f)? ");
            string gender = Console.ReadLine()??"";
            Console.Write("What is the size of the top (s/m/l)? ");
            string topSz = Console.ReadLine()??"";
            Console.Write("How many tops are on the order? ");
            int topQuantity = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is the size of the pants (s/m/l)? ");
            string pantSz = Console.ReadLine()??"";
            Console.Write("What is the pant length (female: petite/regular/tall, male: short/regular/tall)? ");
            string pantLength = Console.ReadLine()??"";
            Console.Write("How many pants are on the order? ");
            int pantQuantity = Convert.ToInt32(Console.ReadLine());

            Student student = new Student(gender , topSz, topQuantity, pantSz, pantLength, pantQuantity);
            student.MakeList();
            
            // for testing purposes. Make sure the attributes and lists for each student are built correctly
                // Console.WriteLine(student.gender);
                // Console.WriteLine(student.topSz);
                // Console.WriteLine(student.topQuantity);
                // Console.WriteLine(student.pantSz);
                // Console.WriteLine(student.pantLength);
                // Console.WriteLine(student.pantQuantity);
                // foreach (string i in student.topSize)
                //     {Console.WriteLine(i);}
                // foreach (string i in student.pantSizeLength)
                //     {Console.WriteLine(i);}

            students.Add(student);
            
            Console.WriteLine("");
            Console.Write("Is there another order? ");
            newStudent = Console.ReadLine()??"";
            Console.WriteLine("");
        }
    }

    public void MakeList()
    {
        foreach (Student student in students)
        {
            if (student.gender == "f" || student.gender == "female")
            {
                if (student.topSz == "s")
                {
                    foreach(string i in student.topSize)
                    {
                        wtopS.Add(".");
                    }
                }
                else if (student.topSz == "m")
                {
                    foreach(string i in student.topSize)
                    {
                        wtopM.Add(".");
                    }
                }
                else if (student.topSz == "l")
                {
                    foreach(string i in student.topSize)
                    {
                        wtopL.Add(".");
                    }
                }
            }
            if (student.gender == "f" || student.gender == "female")
            {
                if (student.pantSz == "s" && student.pantLength == "p")
                {
                    foreach(string i in student.pantSizeLength)
                    {
                        wpantSpetite.Add(".");
                    }
                }
                else if (student.pantSz == "s" && student.pantLength == "r")
                {
                    foreach(string i in student.pantSizeLength)
                    {
                        wpantSregular.Add(".");
                    }
                }
                else if (student.pantSz == "s" && student.pantLength == "t")
                {
                    foreach(string i in student.pantSizeLength)
                    {
                        wpantStall.Add(".");
                    }
                }
                else if (student.pantSz == "m" && student.pantLength == "p")
                {
                    foreach(string i in student.pantSizeLength)
                    {
                        wpantMpetite.Add(".");
                    }
                }
                else if (student.pantSz == "m" && student.pantLength == "r")
                {
                    foreach(string i in student.pantSizeLength)
                    {
                        wpantMregular.Add(".");
                    }
                }
                else if (student.pantSz == "m" && student.pantLength == "t")
                {
                    foreach(string i in student.pantSizeLength)
                    {
                        wpantMtall.Add(".");
                    }
                }
                else if (student.pantSz == "l" && student.pantLength == "p")
                {
                    foreach(string i in student.pantSizeLength)
                    {
                        wpantLpetite.Add(".");
                    }
                }
                else if (student.pantSz == "l" && student.pantLength == "r")
                {
                    foreach(string i in student.pantSizeLength)
                    {
                        wpantLregular.Add(".");
                    }
                }
                else if (student.pantSz == "l" && student.pantLength == "t")
                {
                    foreach(string i in student.pantSizeLength)
                    {
                        wpantLtall.Add(".");
                    }
                }
            }
            if (student.gender == "m" || student.gender == "male")
            {
                if (student.topSz == "s")
                {
                    foreach(string i in student.topSize)
                    {
                        mtopS.Add(".");
                    }
                }
                else if (student.topSz == "m")
                {
                    foreach(string i in student.topSize)
                    {
                        mtopM.Add(".");
                    }
                }
                else if (student.topSz == "l")
                {
                    foreach(string i in student.topSize)
                    {
                        mtopL.Add(".");
                    }
                }
            }
            if (student.gender == "m" || student.gender == "male")
            {
                if (student.pantSz == "s" && student.pantLength == "s")
                {
                    foreach(string i in student.pantSizeLength)
                    {
                        mpantSshort.Add(".");
                    }
                }
                else if (student.pantSz == "s" && student.pantLength == "r")
                {
                    foreach(string i in student.pantSizeLength)
                    {
                        mpantSregular.Add(".");
                    }
                }
                else if (student.pantSz == "s" && student.pantLength == "t")
                {
                    foreach(string i in student.pantSizeLength)
                    {
                        mpantStall.Add(".");
                    }
                }
                else if (student.pantSz == "m" && student.pantLength == "s")
                {
                    foreach(string i in student.pantSizeLength)
                    {
                        mpantMshort.Add(".");
                    }
                }
                else if (student.pantSz == "m" && student.pantLength == "r")
                {
                    foreach(string i in student.pantSizeLength)
                    {
                        mpantMregular.Add(".");
                    }
                }
                else if (student.pantSz == "m" && student.pantLength == "t")
                {
                    foreach(string i in student.pantSizeLength)
                    {
                        mpantMtall.Add(".");
                    }
                }
                else if (student.pantSz == "l" && student.pantLength == "s")
                {
                    foreach(string i in student.pantSizeLength)
                    {
                        mpantLshort.Add(".");
                    }
                }
                else if (student.pantSz == "l" && student.pantLength == "r")
                {
                    foreach(string i in student.pantSizeLength)
                    {
                        mpantLregular.Add(".");
                    }
                }
                else if (student.pantSz == "l" && student.pantLength == "t")
                {
                    foreach(string i in student.pantSizeLength)
                    {
                        mpantLtall.Add(".");
                    }
                }
            }
        }
    }

    public void PrintCount()
    {
        int womenTopCountS = 0;
        int womenTopCountM = 0;
        int womenTopCountL = 0;

        int womenPantCountSPetite = 0;
        int womenPantCountMPetite = 0;
        int womenPantCountLPetite = 0;

        int womenPantCountSRegular = 0;
        int womenPantCountMRegular = 0;
        int womenPantCountLRegular = 0;

        int womenPantCountSTall = 0;
        int womenPantCountMTall = 0;
        int womenPantCountLTall = 0;
        
        int menTopCountS = 0;
        int menTopCountM = 0;
        int menTopCountL = 0;

        int menPantCountSShort = 0;
        int menPantCountMShort = 0;
        int menPantCountLShort = 0;

        int menPantCountSRegular = 0;
        int menPantCountMRegular = 0;
        int menPantCountLRegular = 0;

        int menPantCountSTall = 0;
        int menPantCountMTall = 0;
        int menPantCountLTall = 0;

        foreach (string i in wtopS)
        {
            womenTopCountS += 1;
        }
        foreach (string i in wtopM)
        {
            womenTopCountM += 1;
        }
        foreach (string i in wtopL)
        {
            womenTopCountL += 1;
        }
        foreach (string i in wpantSpetite)
        {
            womenPantCountSPetite += 1;
        }
        foreach (string i in wpantSregular)
        {
            womenPantCountSRegular += 1;    
        }
        foreach (string i in wpantStall)
        {
            womenPantCountSTall += 1;
        }
        foreach (string i in wpantMpetite)
        {
            womenPantCountMPetite += 1;
        }
        foreach (string i in wpantMregular)
        {
            womenPantCountMRegular += 1;
        }
        foreach (string i in wpantMtall)
        {
            womenPantCountMTall += 1;
        }
        foreach (string i in wpantLpetite)
        {
            womenPantCountLPetite += 1;
        }
        foreach (string i in wpantLregular)
        {
            womenPantCountLRegular += 1;
        }
        foreach (string i in wpantLtall)
        {
            womenPantCountLTall += 1;
        }

        foreach (string i in mtopS)
        {
            menTopCountS += 1;
        }
        foreach (string i in mtopM)
        {
            menTopCountM += 1;
        }
        foreach (string i in mtopL)
        {
            menTopCountL += 1;
        }
        foreach (string i in mpantSshort)
        {
            menPantCountSShort += 1;
        }
        foreach (string i in mpantSregular)
        {
            menPantCountSRegular += 1;
        }
        foreach (string i in mpantStall)
        {
            menPantCountSTall += 1;
        }
        foreach (string i in mpantMshort)
        {
            menPantCountMShort += 1;
        }
        foreach (string i in mpantMregular)
        {
            menPantCountMRegular += 1;
        }
        foreach (string i in mpantMtall)
        {
            menPantCountMTall += 1;
        }
        foreach (string i in mpantLshort)
        {
            menPantCountLShort += 1;
        }
        foreach (string i in mpantLregular)
        {
            menPantCountLRegular += 1;
        }
        foreach (string i in mpantLtall)
        {
            menPantCountLTall += 1;
        }

        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Final order quantities:");
        Console.WriteLine("");

        if (womenTopCountS > 0)
        {Console.WriteLine($"Women\'s top size small {womenTopCountS}");}
        if (womenTopCountM > 0)
        {Console.WriteLine($"Women\'s top size medium {womenTopCountM}");}
        if (womenTopCountL > 0)
        {Console.WriteLine($"Women\'s top size large {womenTopCountL}");}
        
        if (womenPantCountSPetite > 0)
            {Console.WriteLine($"Women\'s pants size small petite {womenPantCountSPetite}");}
        if (womenPantCountSRegular > 0)
            {Console.WriteLine($"Women\'s pants size small regular {womenPantCountSRegular}");}
        if (womenPantCountSTall> 0)
            {Console.WriteLine($"Women\'s pants size small tall {womenPantCountSTall}");}

        if (womenPantCountMPetite > 0)
            {Console.WriteLine($"Women\'s pants size medium petite {womenPantCountMPetite}");}
        if (womenPantCountMRegular > 0)
            {Console.WriteLine($"Women\'s pants size medium regular {womenPantCountMRegular}");}
        if (womenPantCountMTall > 0)
            {Console.WriteLine($"Women\'s pants size medium tall {womenPantCountMTall}");}

        if (womenPantCountLPetite > 0)
            {Console.WriteLine($"Women\'s pants size large petite {womenPantCountLPetite}");}
        if (womenPantCountLRegular > 0)
            {Console.WriteLine($"Women\'s pants size large regular {womenPantCountLRegular}");}
        if (womenPantCountLTall > 0)
            {Console.WriteLine($"Women\'s pants size large tall {womenPantCountLTall}");}

        if (menTopCountS > 0)
            {Console.WriteLine($"Men\'s top size small {menTopCountS}");}
        if (menTopCountM > 0)
            {Console.WriteLine($"Men\'s top size medium {menTopCountM}");}
        if (menTopCountL > 0)
            {Console.WriteLine($"Men\'s top size large {menTopCountL}");}
        
        if (menPantCountSShort > 0)
        {Console.WriteLine($"Men\'s pants size small short {menPantCountSShort}");}
        if (menPantCountSRegular > 0)
        {Console.WriteLine($"Men\'s pants size small regular {menPantCountSRegular}");}
        if (menPantCountSTall > 0)
        {Console.WriteLine($"Men\'s pants size small tall {menPantCountSTall}");}

        if (menPantCountMShort > 0)
        {Console.WriteLine($"Men\'s pants size medium short {menPantCountMShort}");}
        if (menPantCountMRegular > 0)
        {Console.WriteLine($"Men\'s pants size medium regular {menPantCountMRegular}");}
        if (menPantCountMTall > 0)
        {Console.WriteLine($"Men\'s pants size medium tall {menPantCountMTall}");}

        if (menPantCountLShort > 0)
        {Console.WriteLine($"Men\'s pants size large short {menPantCountLShort}");}
        if (menPantCountLRegular > 0)
        {Console.WriteLine($"Men\'s pants size large regular {menPantCountLRegular}");}
        if (menPantCountLTall > 0)
        {Console.WriteLine($"Men\'s pants size large tall {menPantCountLTall}");}

        Console.WriteLine("");
    }
}
