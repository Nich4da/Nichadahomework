class Program{
    static void Main(string[] args) {
        Console.WriteLine("hahaha password :");
        int nicha = int.Parse(Console.ReadLine());
        Console.WriteLine("Agency :");
        string Agency = Console.ReadLine();
        int nicha100000 = nicha / 100000;
        int nicha10000 = (nicha / 10000) % 10;
        int nicha1000 = (nicha / 1000) % 10;
        int nicha100 = (nicha / 100) % 10;
        int nicha10 = (nicha / 10) % 10;
        int nicha1 = nicha % 10;
    if(Agency == "CIA"){
        if(nicha1 % 3 == 0 && nicha10 != 1 && nicha10 != 3 && nicha10 != 5 && nicha1000 >= 6 && nicha1000 != 8){
            
            Console.WriteLine("True");
        }
        else{
            Console.WriteLine("False");
        }
    }
    if(Agency == "FBI"){  
            if(nicha100000 >= 4 && nicha100000 <= 7 && nicha100 % 2 == 0 && nicha100 != 6 && nicha10000 % 2 == 1){
            Console.WriteLine("True");
        }
        else{
            Console.WriteLine("False");
        }
    }
    if(Agency == "NSA"){  
            if(30 % nicha1 == 0 && nicha100 % 3 == 0 && nicha100 % 2 != 0 && (nicha1 == 7 || nicha10 == 7 || nicha100 == 7 || nicha1000 == 7 || nicha10000 == 7 || nicha100000 == 7)){
            Console.WriteLine("True");
        }
        else{
            Console.WriteLine("False");
        }
    }
}
}
