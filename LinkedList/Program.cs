namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList
                .PushBack("DarkSoul")
                .PushBack("DarkSoul2")
                .PushBack("DarkSoul3")
                .PushFront("BloodBorne");
            linkedList.PrintAll();
        }
    }
}
