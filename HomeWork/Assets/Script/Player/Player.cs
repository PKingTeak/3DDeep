using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private CharacterData PlayerData;

    [Header("ItemTestData")]
    public ItemData Item;
    public ItemData Item1;
    public ItemData Item2;




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

        inventory.AddItem(0, Item);
        inventory.AddItem(1, Item1);
        inventory.AddItem(2, Item2);

    }

    public Character GetPlayer()
    {
        return player;    
    }

}
