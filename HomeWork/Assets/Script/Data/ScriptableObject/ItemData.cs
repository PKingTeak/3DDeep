using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemData", menuName = "SO/ItemData")]
public class ItemData : ScriptableObject
{
    public string itemName;
    public Sprite itemIcon;

    public GameObject equipPrefab;
    //public ItemType itemType;
}
