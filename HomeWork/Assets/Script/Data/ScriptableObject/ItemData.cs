using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ItemState
{
    public int ItemDamage;
    public int ItemDefense;
    public int ItemHp;

}


[CreateAssetMenu(fileName = "ItemData", menuName = "SO/ItemData")]
public class ItemData : ScriptableObject
{
    public string itemName;
    public Sprite itemIcon;

    public GameObject equipPrefab;

    [SerializeField] public ItemState itemstate;
    //public ItemType itemType;
}
