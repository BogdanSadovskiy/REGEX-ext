

namespace mySpace;

class programm
{
    static public void Main(string[] args)
    {
        Exersice exersice = new Exersice();
        Console.WriteLine("Is Email valid ------------ 1");
        Console.WriteLine("Is Ukrainian number valid - 2");
        Console.WriteLine("Is Password valid --------- 3");
        string menu = Console.ReadLine();
        int menu_= 0;
        try
        {
            menu_ = Int32.Parse(menu);
        }
        catch { Console.WriteLine("Wrong input"); }
        Console.Clear();   
        if(menu_ == 1) {
            exersice.IsEmailValid();
        }
        else if (menu_ == 2)
        {
            exersice.IsUkrainianNumberValid();
        }
        else if(menu_==3)
        {
            exersice.IsPassWordValid();
        }

    }
}