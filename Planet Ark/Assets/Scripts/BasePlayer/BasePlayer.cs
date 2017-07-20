using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlayer
{

    private string playerName;
    private int playerLevel;
    private BaseCharacterClass playerClass;
    private int strength;       // skill mod, Damage mod, to hit mod
    private int dexterity;      // skill mod, AC mod, to hit mod 
    private int intellegence;   // skill mod, magic mod
    private int charisma;       // skill mod, sell item mod
    private int luck;           // Critical hit mod, loot table mod

    private int gold;

    private int correntXP;
    private int requiredXP;
    private int statPointsToAllocate;



    public string PlayerName
    {
        get { return playerName; }
        set { playerName = value; }
    }
    //Dose the same as above
    // public string PlayerName{get;set;}


    public int CorrentXP { get; set; }
    public int RequiredXP { get; set; }
    public int StatPointsToAllocate{ get; set; }

   

    public int PlayerLevel
    {
        get { return playerLevel; }
        set { playerLevel = value; }
    }
    public BaseCharacterClass PlayerClass
    {
        get { return playerClass; }
        set { playerClass = value; }
    }
    public int Strength
    {
        get { return strength; }
        set { strength = value; }
    }
    public int Dexterity
    {
        get { return dexterity; }
        set { dexterity = value; }
    }
    public int Intellegence
    {
        get { return intellegence; }
        set { intellegence = value; }
    }
    public int Charisma
    {
        get { return charisma; }
        set { charisma = value; }
    }
    public int Luck
    {
        get { return luck; }
        set { luck = value; }
    }
    public int Gold
    {
        get { return gold; }
        set { gold = value; }
    }
    
}

