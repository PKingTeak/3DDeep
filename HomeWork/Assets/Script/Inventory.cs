using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//플레이어 내부에서 직접 동적으로 생성하여 사용할까 고민중
public class Inventory : MonoBehaviour
{
    public event Action OnChangeInventory;




    Dictionary<int, Item> itemDictionary = new Dictionary<int, Item>();
    //인덱스로 저장하여 해당 아이템을 저장할 것이다. 


    public void AddItem(int index, Item itme)
    {
        if (!itemDictionary.ContainsKey(index))
        {
            itemDictionary.Add(index, itme);
            
        }
        else
        {
            Debug.LogWarning("Item already exists at this index: " + index);
        }
    }


    public void RemvoveItem(int index)
    {
        if (itemDictionary.ContainsKey(index))
        {
            itemDictionary.Remove(index);
          
        }
        else
        {
            Debug.LogWarning("No item found at this index: " + index);
        }


    }


    public Dictionary<int, Item> GetAllItems()
    {
        return itemDictionary;

    }


    public Item GetItem(int index)
    {
        if (itemDictionary.ContainsKey(index))
        {

            return itemDictionary[index];
        }
        else
        {
            Debug.Log("해당 아이템은 없습니다");
            return null;

        }

    }


    //빈곳 찾기
    public int FindEmptySlot()
    {
        for (int i = 0; i < itemDictionary.Count; i++)
        {
            if (itemDictionary[i] == null)
            {

                return i;
            }

        }

        Debug.Log("빈곳이 없습니다.");
        return -1;
     }

}
