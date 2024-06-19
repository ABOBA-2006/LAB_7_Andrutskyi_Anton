namespace Lab7;

class Program
{
    static void Main()
    {
        LinkedList myLinkedList = new LinkedList();
        myLinkedList.Add('a');
        myLinkedList.Add('b');
        myLinkedList.Add('!');
        myLinkedList.Add('c');
        myLinkedList.Add('d');
        
        Console.WriteLine("The first index of exclamation mark in your linked list is: " 
                          + myLinkedList.ExclamationMarkFind());
        Console.WriteLine("The sum of elements more than symbol ! is: " 
                          + myLinkedList.SumOfElementsMoreThan('!'));

        LinkedList newList = myLinkedList.NewListAfterExclamationMark();
        Console.WriteLine("The length of new linked list: " + newList.Length);
        
        myLinkedList.DeleteBeforeExclMark();
        Console.WriteLine("The length of my linked list: " + myLinkedList.Length);
    }
}