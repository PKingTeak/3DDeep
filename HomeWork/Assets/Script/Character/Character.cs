using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Character : MonoBehaviour
{
    public string Name { get; private set; }
    public int Level { get; private set; }
    public int MaxHp { get; private set; }
    public int Gold { get; private set; }

    [SerializeField] private CharacterData data;

    [SerializeField] public Inventory Inventory;

    [SerializeField] public List<Item> ItemList;
    public void InitCharacter(CharacterData characterData)
    {
        Name = characterData.CharacterStateData.Name;
        Level = characterData.CharacterStateData.Level;
        MaxHp = characterData.CharacterStateData.MaxHp;
        Gold = characterData.CharacterStateData.Gold;

        ItemList = new List<Item>();
    }


   

}
