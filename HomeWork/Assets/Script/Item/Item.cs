using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Item 
{
    private string ItemName;
    private Sprite ItemIcon;

    private bool isEquiment;
    public bool IsEquiment{ get{ return isEquiment; }}
    //Testing
    public void ItemInit(ItemData data)
    {
        
        this.data = data;

        ItemName = data.name;

        ItemIcon = data.itemIcon;
        isEquiment = false; //모든 아이템은 착용되어 있지 않다. 

        
    }

    [SerializeField] private ItemData data;

    
    public ItemData GetItemData()
    {
        return data;

    }

    public void ToggleEquip()
    {
        isEquiment = !isEquiment;
    }


    

}
