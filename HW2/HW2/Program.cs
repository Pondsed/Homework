class Program
{
    static void Main(string[] args)
    {
        Queue<char> fruit_Input = new Queue<char>();
        int n = 0;
        while(n == 0){
           char input = char.Parse(Console.ReadLine());     
           if(input == 'L' || input == 'S' || input == 'M' ){
               fruit_Input.Push(input);
               n = 0;
           } 
           else{
            n = 1;
           }
           n = n;; 
        }
        CircularLinkedList<int> fruit_Output  = new CircularLinkedList<int>();
      
        while(true){
            char T = fruit_Input.Pop();
           if(T == 'L'){
            Console.Write("1");
            fruit_Input.Push('M');
            fruit_Input.Push('M');
            fruit_Output.Add(1);
           }
           else if(T == 'M'){
            Console.Write("2");
            fruit_Input.Push('S');
            fruit_Input.Push('S');
            fruit_Input.Push('S');
            fruit_Output.Add(2);
           }
           else if(T == 'S'){
            Console.Write("3");
            fruit_Output.Add(3);
           }
           if(fruit_Input.GetLength() == 0){
            break;
           }

        }
        int N = 0;
        while(true){
            if(N >= fruit_Input.GetLength()){
                break;
            }
            Console.WriteLine(fruit_Input.Get(N));
            N++;
        }
        

    }
}