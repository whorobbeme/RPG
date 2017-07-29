using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacterClass : MonoBehaviour

{

    private string characterClassName;
    private string characterClassDescription;

    //Stats
    public int strength = 8;
    public int dexterity = 8;
    public int intellegence = 8;
    public int charisma = 8;
    public int luck = 8;



    public enum MainStatBonuses
    {
        STRENGTH,
        DEXTERITY,
        INTELLEGENCE,
        CHARISMA,
        LUCK
    }

    public enum SecondaryStatBonuses
    {
        STRENGTH,
        DEXTERITY,
        INTELLEGENCE,
        CHARISMA,
        LUCK
    }

    public enum leastStatBonuses
    {
        STRENGTH,
        DEXTERITY,
        INTELLEGENCE,
        CHARISMA,
        LUCK
    }

    public string CharacterClassName
    {
        get { return characterClassName; }
        set { characterClassName = value; }
    }

    public string CharacterClassDescription
    {
        get { return characterClassDescription; }
        set { characterClassDescription = value; }
    }

    public MainStatBonuses MainStat { get; set; }
    public SecondaryStatBonuses SecondMainStat { get; set; }
    public leastStatBonuses LeastStat { get; set; }

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
    
}