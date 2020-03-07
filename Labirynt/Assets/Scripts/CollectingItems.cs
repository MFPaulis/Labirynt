using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectingItems : MonoBehaviour
{
    public int howManyItems;
    bool[] itemArray;

    void Awake()
    {
        if (howManyItems < 1) howManyItems = 1;
        itemArray = new bool[howManyItems];
    }

    public void ItemCollected(int count)
    {
        if (count<howManyItems)
        {
            itemArray[count] = true;
        }
    }

    public bool IfAllCollected()
    {
        foreach (bool item in itemArray)
        {
           // Debug.Log("item");
            if (item == false) return false;
        }
        return true;
    }

}
