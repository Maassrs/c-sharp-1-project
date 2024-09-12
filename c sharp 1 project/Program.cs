namespace c_sharp_1_project;

class Program
{
    static void Main(string[] args)
    {
        //this is a comment. use me

        // variables
        int age = 15;

        string name = "Maas";
        string input;
       


        //A way to write stuff to screen
        Console.WriteLine("hello my name is " + name);
        Console.WriteLine("My age is " + age);
        Console.WriteLine("The wizard " + name + " is super strong and he wants to take over the world with his power.");
        Console.WriteLine("1=win    2=lose");
        Console.WriteLine();
        input = Console.ReadLine(); //100000000


        if (input == "1")
        {
            Console.WriteLine("he takes over the world and now is every one hes slave.");
        }
        else if (input == "2")
        {
            Console.WriteLine("he got beated by MR BIBS and he got smashed in to the ground and he died.");
        }
        else
        {
            Console.WriteLine("error put 1 or 2");
        }






        Console.WriteLine();
            Console.WriteLine("the wizard " + name + " was a good man but the whole world exploded and there are some aliens who revive him and now is he getting revenge");
        Console.WriteLine(" 1=takes epic revange    2=he gets a hard attack and dies");
        Console.WriteLine();
        input = Console.ReadLine();


        if (input == "1") 
        {
            Console.WriteLine("he destroys universe.");
        }
        else if (input == "2")
        {
            Console.WriteLine("he gets hard attack.");
        }
        else
        {
            Console.WriteLine("error put 1 or 2");
        }


       






        Console.WriteLine("Press enter to exit.");
        Console.ReadLine();
    }
}

