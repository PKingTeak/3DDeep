using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//플레이어 내부에서 직접 동적으로 생성하여 사용할까 고민중
public class Inventory : MonoBehaviour
{

    [Header("Testing")]
    public ItemData item;
    public ItemData item2
    ;
    public ItemData item3;
    


    Dictionary<int, ItemData> itemDictionary = new Dictionary<int, ItemData>();
    //인덱스로 저장하여 해당 아이템을 저장할 것이다. 


    public void AddItem(int index, ItemData itemData)
    {
        if (!itemDictionary.ContainsKey(index))
        {
            itemDictionary.Add(index, itemData);
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


    public Dictionary<int, ItemData> GetAllItems()
    {
        return itemDictionary;

    }
    

    public ItemData GetItem(int index)
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


}
