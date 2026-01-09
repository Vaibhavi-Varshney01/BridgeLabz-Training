using System;
using System.Collections.Generic;

class MyHashMap
{
    private const int SIZE = 10;
    private LinkedList<(int key, int value)>[] table;

    public MyHashMap()
    {
        table = new LinkedList<(int, int)>[SIZE];
        for (int i = 0; i < SIZE; i++)
            table[i] = new LinkedList<(int, int)>();
    }

    private int Hash(int key)
    {
        return key % SIZE;
    }

    public void Put(int key, int value)
    {
        int index = Hash(key);

        foreach (var pair in table[index])
        {
            if (pair.key == key)
            {
                table[index].Remove(pair);
                break;
            }
        }
        table[index].AddLast((key, value));
    }

    public int Get(int key)
    {
        int index = Hash(key);

        foreach (var pair in table[index])
        {
            if (pair.key == key)
                return pair.value;
        }
        return -1;
    }

    public void Remove(int key)
    {
        int index = Hash(key);

        foreach (var pair in table[index])
        {
            if (pair.key == key)
            {
                table[index].Remove(pair);
                return;
            }
        }
    }
}
