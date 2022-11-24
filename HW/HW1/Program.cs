class Program
{
    static void Main(string[] args)
    {
        CircularLinkedList<char> Flower_Ring = new CircularLinkedList<char>();
        Console.WriteLine("1.J = Jasmine");
        Console.WriteLine("2.G = Amaranth");
        Console.WriteLine("3.O = Orchid");
        Console.WriteLine("4.R = Rose");
        while(true){
            Flower_Ring.Add(char.Parse(Console.ReadLine()));
            int range = Flower_Ring.GetLength() - 1;
            if(Flower_Ring.Get(Flower_Ring.GetLength()-1) != 'J' && Flower_Ring.Get(Flower_Ring.GetLength()-1) != 'G' 
            && Flower_Ring.Get(Flower_Ring.GetLength()-1) != 'O' && Flower_Ring.Get(Flower_Ring.GetLength()-1) != 'R'){
                Flower_Ring.Remove(Flower_Ring.GetLength()-1);

                for (int i =0 ;i<Flower_Ring.GetLength(); i++){
                Console.Write(Flower_Ring.Get(i));
                }
                break;
            }
            else if (Flower_Ring.Get(range) == 'R'){
                    if (Flower_Ring.Get(range-1)==Flower_Ring.Get(0)){
                            Console.WriteLine("Wrong pattern");
                            Flower_Ring.Remove(range);
                    }
            }
            else if (Flower_Ring.GetLength() <= 2){
                if (Flower_Ring.Get(range) == 'R'){
                    if(Flower_Ring.Get(0) == Flower_Ring.Get(range-1)){
                        Console.WriteLine("Wrong pattern");
                        Flower_Ring.Remove(range);
                    }
                    else if(Flower_Ring.Get(range -1) == Flower_Ring.Get(range) && Flower_Ring.Get(range -1) == Flower_Ring.Get(range)){
                        Console.WriteLine("Wrong pattern");
                        Flower_Ring.Remove(range);
                    }
                }
                else if (Flower_Ring.Get(range - 1) == 'R'){
                    if (Flower_Ring.Get(range) == Flower_Ring.Get(range - 2)){
                    Console.WriteLine("Wrong pattern");
                    Flower_Ring.Remove(range);
                    }
                }
            }
            else if(Flower_Ring.GetLength() >= 3){
                if (Flower_Ring.Get(range) == 'R'){
                    if(Flower_Ring.Get(range -1) == Flower_Ring.Get(range)){
                        Console.WriteLine("Wrong pattern");
                        Flower_Ring.Remove(range);
                    }
                }
                else if (Flower_Ring.Get(range - 1) == 'R'){
                    if (Flower_Ring.Get(range) == Flower_Ring.Get(range - 2)){
                    Console.WriteLine("Wrong pattern");
                    Flower_Ring.Remove(range);
                    }
                }
                if(Flower_Ring.Get(range) == 'G'){
                    if(Flower_Ring.Get(range) == Flower_Ring.Get(0) 
                    && Flower_Ring.Get(range) == Flower_Ring.Get(1) 
                    && Flower_Ring.Get(range) == Flower_Ring.Get(2)){
                        Console.WriteLine("Wrong pattern");
                        Flower_Ring.Remove(range);
                    }
                    else if (Flower_Ring.Get(range) == Flower_Ring.Get(range -1) 
                    && Flower_Ring.Get(range) == Flower_Ring.Get(range -2) 
                    && Flower_Ring.Get(range) == Flower_Ring.Get(range -3)){
                        Console.WriteLine("Wrong pattern");
                        Flower_Ring.Remove(range);
                    }
                    else if (Flower_Ring.Get(range) == Flower_Ring.Get(range -1) 
                    && Flower_Ring.Get(range) == Flower_Ring.Get(range -2) 
                    && Flower_Ring.Get(range) == Flower_Ring.Get(0)){
                        Console.WriteLine("Wrong pattern");
                        Flower_Ring.Remove(range);
                    }
                    else if (Flower_Ring.Get(range) == Flower_Ring.Get(1) 
                    && Flower_Ring.Get(range) == Flower_Ring.Get(0) 
                    && Flower_Ring.Get(range) == Flower_Ring.Get(range -1)){
                        Console.WriteLine("Wrong pattern");
                        Flower_Ring.Remove(range);
                    }
                    else if (Flower_Ring.Get(range - 1) == 'R'){
                        if (Flower_Ring.Get(range) == Flower_Ring.Get(range - 2)){
                            Console.WriteLine("Wrong pattern");
                            Flower_Ring.Remove(range);
                        }
                    }
                }
            }
        }
    }
}