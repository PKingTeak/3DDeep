using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[Serializable]
public class CharacterStateData
{
    public string Name;
    public int Level;
    public int MaxHp;
    public int Damage;
    public int Defense;
    public int Gold;

    public string CharacterInfo;
}



[CreateAssetMenu(fileName ="Character", menuName = "SO/CharacterData")]
public class CharacterData : ScriptableObject
{
    [field: SerializeField] public CharacterStateData CharacterStateData { get; private set; }




}
