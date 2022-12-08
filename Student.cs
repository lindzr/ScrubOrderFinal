class Student : ScrubProfile , Listmaker
{
    // class constructs the attributes necessary in each student object and makes lists for the top and bottom
    // orders for each student.

    public Student(string gender_, string topSz_, int topQuantity_, string pantSz_, string pantLength_, int pantQuantity_)
    {
        gender = gender_;
        topSz = topSz_;
        topQuantity = topQuantity_;
        pantSz= pantSz_;
        pantLength = pantLength_;
        pantQuantity = pantQuantity_;
    }

    public new List<string> topSize = new List<string>();
    public new List<string> pantSizeLength = new List<string>();

    // if there is quantity in top or pants, add size (and length in pants) to respective list
    public void MakeList()
    {
        if (topQuantity > 0)
        {
            for (int i = 0; i < topQuantity; i++)
                {topSize.Add(topSz);}
        }

        if (pantQuantity > 0)
        {
            for (int i = 0; i < pantQuantity; i++)
                {pantSizeLength.Add($"{topSz} {pantLength}");}
        }
    }
}
