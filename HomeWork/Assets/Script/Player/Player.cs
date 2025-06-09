using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private CharacterData PlayerData;

    [Header("ItemTestData")]
    public ItemData Item;
    public ItemData Item1;
   


    private Character player;
    private Inventory inventory;
    public Inventory Inventory { get { return inventory; } }
    private void Awake()
    {
        player = new Character();
        player.InitCharacter(PlayerData);
    }

    private void Start()
    {
        inventory = new Inventory();

        Item adItem = new Item();
        adItem.ItemInit(Item);

        Item adItem2 = new Item();
        adItem2.ItemInit(Item1);

        inventory.AddItem(0,adItem);
        inventory.AddItem(1, adItem2);
      
    }

    public Character GetPlayer()
    {
        return player;    
    }

}
