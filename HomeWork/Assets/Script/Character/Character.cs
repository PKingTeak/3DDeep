using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class Character : MonoBehaviour
{
    public string Name { get; private set; }
    public int Level { get; private set; }
    public int Gold { get; private set; }

    [SerializeField] private CharacterData data;

    [SerializeField] public Inventory Inventory;

    [SerializeField] public List<Item> ItemList;

    [Header("State")]
    private int baseAttack;
    private int baseDefense;
    private int MaxHp;

    private int curAttack;
    private int curDefense;
    private int curMaxHp;
    private int curHp;
    
    public void InitCharacter(CharacterData characterData)
    {
        Name = characterData.CharacterStateData.Name;
        Level = characterData.CharacterStateData.Level;
        MaxHp = characterData.CharacterStateData.MaxHp;
        Gold = characterData.CharacterStateData.Gold;

        baseAttack = characterData.CharacterStateData.Damage;
        baseDefense = characterData.CharacterStateData.Defense;

        curAttack = baseAttack;
        curDefense = baseDefense;
        curHp = MaxHp;

    
    }

    public void ApplyState(int damage, int defense, int maxHp)
    {
        curAttack += damage;
        curDefense += defense;
        MaxHp += maxHp;
    }

    public void RejectState(int damage, int defense, int maxHp)
    {

        curAttack -= damage;
        curDefense -= defense;
        MaxHp -= maxHp;
    }


    




}
