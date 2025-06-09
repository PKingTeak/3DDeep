using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
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
    }

    [SerializeField] private ItemData data;

    public void Start()
    {
        isEquiment = false; //모든 아이템은 착용되어 있지 않다. 
    }

    public ItemData GetItemData()
    {
        return data;

    }


}
