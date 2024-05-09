
class Program
{
    static void Main(string[] args)
    {
        // DemoHashSet();
        //  DemoLinkedList();
        DemoList();
    }

    static void DemoHashSet()
    {
        HashSet<string> Games = new HashSet<string>();
        Games.Add("Liên minh huyền thoại");
        Games.Add("Genshin impact");
        Games.Add("CSO");
        Games.Add("GTA 5");
        Games.Add("GTA 5"); // phần tử này sẽ không được thêm vào hashset vì nó đã tồn tại

        foreach (string item in Games)
        {
            Console.WriteLine("Games item: " + item);
        }
        Console.WriteLine("tổng phần tử trong Games: " + Games.Count);

        HashSet<string> GamingS = new HashSet<string>() { "CSO", "GTA 5", "PUPG", "C#" };
        foreach (string item in GamingS)
        {
            Console.WriteLine("GamingS item: " + item);
        }
        Console.WriteLine("tổng phần tử trong GamingS: " + GamingS.Count);
    }

    static void DemoLinkedList()
    {
        // sử dụng LinkedList
        LinkedList<string> linkedList = new LinkedList<string>();
        linkedList.AddLast("Liên minh huyền thoại");
        linkedList.AddLast("Genshin impact");
        linkedList.AddLast("CSO");
        linkedList.AddLast("GTA 5");
        linkedList.AddLast("Gunny");

        ShowLogLinkedList(linkedList);

        // xóa phần tử đầu tiên
        linkedList.Remove(linkedList.First);
        ShowLogLinkedList(linkedList);

        // xóa phần tử có tên là Gunny
        linkedList.Remove("Gunny");
        ShowLogLinkedList(linkedList);

        // xóa phần tử đầu tiên
        linkedList.RemoveFirst();
        ShowLogLinkedList(linkedList);

        // xóa toàn bộ phần tử 
        linkedList.Clear();
        ShowLogLinkedList(linkedList);

    }
    static void ShowLogLinkedList(LinkedList<string> list)
    {
        foreach (string item in list)
        {
            Console.WriteLine("item: " + item);
        }
        Console.WriteLine("tổng số phần tử của list: " + list.Count);
    }
    static void DemoList()
    {
        List<string> listTxt = new List<string>();
        listTxt.Add("Liên minh huyền thoại");
        listTxt.Add("Genshin impact");
        listTxt.Add("CSO");
        listTxt.Add("GTA 5");
        //listTxt.Add("GTA 5");
        //listTxt.Insert(1, "Java");
        //listTxt.Remove("GTA 5");
        listTxt.Sort();

        Console.WriteLine(listTxt.Contains("CSO")); // true or false
        foreach (string item in listTxt)
        {
            Console.WriteLine(item); Console.WriteLine();
        }
    }
}