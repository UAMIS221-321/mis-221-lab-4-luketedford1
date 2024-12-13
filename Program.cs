// main

using System.Diagnostics;

string input = "0";
while(input != "4"){
    Console.Clear();
    System.Console.WriteLine("Which pizza would you like to see?\n1. Plain\n2. Cheese\n3. Pepperoni\n4. Exit");
    input = Console.ReadLine();
    while(input != "1" && input != "2" && input != "3" && input != "4"){
        Console.Clear();
        System.Console.WriteLine("Invalid input. Press any key to return.");
        Console.ReadKey();
        Console.Clear();
        System.Console.WriteLine("Which pizza would you like to see?\n1. Plain\n2. Cheese\n3. Pepperoni\n4. Exit");
        input = Console.ReadLine();
    }
    if (input != "4"){
        MenuRoute(input);
    }
}

static void MenuRoute(string input){
    switch(input){
        case("1"):
            PlainPizza();
            break;
        case("2"):
            CheesePizza();
            break;
        default:
            PepperoniPizza();
            break;
    }
}

static void PlainPizza(){
    Console.Clear();
    Random random = new Random();
    int size = random.Next(8, 13);
    for(int i = size; i > 0; i --){
        for(int j = i; j > 0; j --){
            Console.Write(" * ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("\nPress any key to return.");
    Console.ReadKey();
}

static void CheesePizza(){
    Console.Clear();
    Random random = new Random();
    int size = random.Next(8, 13);
    for(int i = size; i > 0; i --){
        if(i == size){
            for(int k = 0; k < size; k ++){
                Console.Write(" * ");
            }
            Console.WriteLine("");
        }
        for(int j = i - 1; j > 0; j --){
            if(j == i - 1 || j == 1){
                Console.Write(" * ");
            }
            else{
                Console.Write(" # ");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine("\nPress any key to return.");
    Console.ReadKey();
}

static void PepperoniPizza(){
    Console.Clear();
    Random random = new Random();
    int size = random.Next(8, 13);
    for(int i = size; i > 0; i --){
        if(i == size){
            for(int k = 0; k < size; k ++){
                Console.Write(" * ");
            }
            Console.WriteLine("");
        }
        for(int j = i - 1; j > 0; j --){
            if(j == i - 1 || j == 1){
                Console.Write(" * ");
            }
            else{
                int roni = random.Next(1, 6);
                if(roni > 2){
                    Console.Write(" # ");
                }
                else{
                    Console.Write("[ ]");
                }
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine("\nPress any key to return.");
    Console.ReadKey();
}