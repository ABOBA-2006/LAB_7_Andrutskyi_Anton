using System.Text;

namespace Lab7;

public class LinkedListNode(char value, LinkedListNode next)
{
    public readonly char Value = value;

    public int Index;

    public readonly LinkedListNode Next = next;
}


public class LinkedList
{
    private LinkedListNode _head;
    private int _length = 0;

    public int Length => _length;

    public void Add(char value)
    {
        // creating new node
        var currentElement = _head;
        _head = new LinkedListNode(value, currentElement);
        _length++;

        // setting up indexes 
        currentElement = _head;
        for (var i = 0; i < _length; i++)
        {
            currentElement.Index = i;
            currentElement = currentElement.Next;
        }
    }

    public int ExclamationMarkFind()
    {
        const char exclamationMark = '!';
        
        var currentElement = _head;
        
        while (currentElement != null)
        {
            if (currentElement.Value == exclamationMark)
            {
                break;
            }
            currentElement = currentElement.Next;
        }

        if (currentElement != null)
        {
            return currentElement.Index;
        }

        return -1;
    }

    public int SumOfElementsMoreThan(char element)
    {
        var currentElement = _head;
        int sum = 0;
        
        while (currentElement != null)
        {
            if (currentElement.Value > element)
            {
                sum += (int)(currentElement.Value);
            }
            currentElement = currentElement.Next;
        }

        return sum;
    }

    public LinkedList NewListAfterExclamationMark()
    {
        const char exclamationMark = '!';
        var currentElement = _head;
        LinkedList newList = new LinkedList();

        bool isExclMarkFound = false;
        while (currentElement != null)
        {
            if (isExclMarkFound)
            {
                newList.Add(currentElement.Value);
            }
            
            if (currentElement.Value == exclamationMark)
            {
                isExclMarkFound = true;
            }
            
            currentElement = currentElement.Next;
        }

        return newList;
    }

    public void DeleteBeforeExclMark()
    {
        const char exclamationMark = '!';
        var currentElement = _head;
        int counter = 0;
        
        while (currentElement != null)
        {
            if (currentElement.Value == exclamationMark)
            {
                _head = currentElement;
                _length -= counter;
                
                currentElement = _head;
                for (var i = 0; i < _length; i++)
                {
                    currentElement.Index = i;
                    currentElement = currentElement.Next;
                }
                
                break;
            }
            counter++;
            currentElement = currentElement.Next;
        }
    }
}