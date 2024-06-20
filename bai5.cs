using System;
using System.Collections.Generic;

public class MyStack<T>
{
    private List<T> items;

    public MyStack()
    {
        items = new List<T>();
    }

    public void Push(T item)
    {
        items.Add(item);
    }

    public T Pop()
    {
        if (items.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty");
        }

        T item = items[items.Count - 1];
        items.RemoveAt(items.Count - 1);
        return item;
    }
}

class bai5
{
    static void Main(string[] args)
    {
        // Kiểm tra lớp MyStack với kiểu dữ liệu int
        MyStack<int> intStack = new MyStack<int>();
        intStack.Push(1);
        intStack.Push(2);
        intStack.Push(3);
        Console.WriteLine("Popping from int stack: " + intStack.Pop()); // Output: Popping from int stack: 3

        // Kiểm tra lớp MyStack với kiểu dữ liệu string
        MyStack<string> stringStack = new MyStack<string>();
        stringStack.Push("hello");
        stringStack.Push("world");
        stringStack.Push("anthropic");
        Console.WriteLine("Popping from string stack: " + stringStack.Pop()); // Output: Popping from string stack: anthropic
    }
}