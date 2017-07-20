using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseBouncerClass : BaseCharacterClass {

    public BaseBouncerClass() {
        CharacterClassName = "Bouncer";
        CharacterClassDescription = "The person who says when you've had enough";
        MainStat = MainStatBonuses.STRENGTH;
        SecondMainStat = SecondaryStatBonuses.DEXTERITY;
        LeastStat = leastStatBonuses.LUCK;


       // Strength = 3;
       // Dexterity = 3;
       // Intellegence = 1;
       // Charisma = 1;
       // Luck = 2;
    }
}

