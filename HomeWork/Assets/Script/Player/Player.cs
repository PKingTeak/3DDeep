using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private CharacterData PlayerData;
    [SerializeField] private PlayerInfoUI playerInfoUI;

    [Header("ItemTestData")]
    public ItemData Item;
    public ItemData Item1;
   


    private Character player;
    private Inventory inventory;
    public Inventory Inventory { get { return inventory; } }
    private void Awake()
    {
        
    }

    private void Start()
    {
        GameManager.instance.Player = this;
        player = new Character();
        player.InitCharacter(PlayerData);
        inventory = new Inventory();


        Item adItem = new Item();
        adItem.ItemInit(Item);
        Debug.Log($"아이템 생성 완료 {Item.name}");

        Item adItem2 = new Item();
        adItem2.ItemInit(Item1);
        Debug.Log($"아이템 생성 완료 {Item1.name}");
        inventory.AddItem(0,adItem);
        inventory.AddItem(1, adItem2);

        playerInfoUI.BindPlayer(player);


    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            player.AddExp(10);
        }
    }

    public void ApplyItem(Item item)
    {
        ItemData data = item.GetItemData(); //값이 들어오나
        player.ApplyState(data.itemstate.ItemDamage, data.itemstate.ItemDefense, data.itemstate.ItemHp);
        
    }


    public void RemoveItem(Item item)
    {

        ItemData data = item.GetItemData();
        player.RejectState(data.itemstate.ItemDamage, data.itemstate.ItemDefense, data.itemstate.ItemHp);

    }

    public Character GetPlayer()
    {
        return player;    
    }
    public int GetCurGold()
    {
        return player.Gold;
    }
    public void AddPlayerGold(int gold)
    {
        player.AddGold(gold);
    }

}
