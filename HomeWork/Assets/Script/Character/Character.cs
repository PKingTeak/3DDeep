using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using static UnityEngine.PlayerLoop.EarlyUpdate;

public class Character : MonoBehaviour
{
    public Action ExpUpdate;
    public int CurAttack { get { return curAttack; } }
    public int CurDefense { get { return curDefense; } }
    public int CurMaxHP { get { return curMaxHp; } }

    public float CurExp { get { return curExp; } }

    public float MaxExp { get { return maxExp; } }

    public string Name { get; private set; }
    public int Level { get; private set; }

    public int Gold { get; private set; }
    public string Info { get; private set; }

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
    private float maxExp;
    private float curExp;
 
    
    public void InitCharacter(CharacterData characterData)
    {
        Name = characterData.CharacterStateData.Name;
        Level = characterData.CharacterStateData.Level;
        MaxHp = characterData.CharacterStateData.MaxHp;
        Gold = characterData.CharacterStateData.Gold;
        Info = characterData.CharacterStateData.CharacterInfo;

        baseAttack = characterData.CharacterStateData.Damage;
        baseDefense = characterData.CharacterStateData.Defense;


       
        curAttack = baseAttack;
        curDefense = baseDefense;
        curMaxHp = MaxHp;
        curHp = MaxHp;
        maxExp = 10;
        curExp = 0;

    }

    public void ApplyState(int damage, int defense, int maxHp)
    {
        curAttack += damage;
        curDefense += defense;
        curMaxHp += maxHp;
        Debug.Log("증가");
    }

    public void RejectState(int damage, int defense, int maxHp)
    {

        curAttack -= damage;
        curDefense -= defense;
        curMaxHp -= maxHp;
        Debug.Log("감소");
    }

    public void AddGold(int gold)
    {
        Gold += gold;
        //다른 몬스터 가 들고있다가 죽고 드랍할수도 잇으니까 다른 몬스터들도 골드를 소유할수도 있어서 확장성을 생각해서 구현
    }


    public float GetCurLevelRatio()
    {
        return (float)curExp / maxExp;
    }

    public void AddExp(int value)
    {

        
        curExp += value;

        if (curExp >= maxExp)
        {
            Level++;
            curExp -= maxExp;
            maxExp *= Level;
        }
        ExpUpdate?.Invoke();
    }

    public string GetCharacterInfo()
    {
        return Info;
    }


}
