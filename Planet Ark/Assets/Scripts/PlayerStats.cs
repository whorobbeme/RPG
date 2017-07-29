using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

    public int currentLevel;

    public int currentExp;

    public int[] toLevelUp;

    public int[] HPLevels;
    public int[] attackLevels;
    public int[] defenceLevels;

    public int currentHP;
    public int currentAttack;
    public int currentDefence;
    public int strenghtBonous; //

    private PlayerHealthManager theplayerHealth; //PlayerHealthManager attached to player

    // Use this for initialization
    void Start () {
        currentHP = HPLevels[1];
        currentAttack = attackLevels[1];
        currentDefence = defenceLevels[1];

        theplayerHealth = FindObjectOfType<PlayerHealthManager>(); //PlayerHealthManager attached to player
    }
	
	// Update is called once per frame
	void Update () {
        if (currentExp >= toLevelUp[currentLevel]) //checking to level up
        {
            
            LevelUP(); //run call LevelUP Below
        }
	}
    public void AddExperience(int experienceToAdd)

    {
        currentExp += experienceToAdd;
    }

    public void LevelUP()
    {
        currentLevel++; 
        currentHP = HPLevels[currentLevel]; //+ (BaseCharacterClass.strength)

        theplayerHealth.playerMaxHealth = currentHP;
        theplayerHealth.playerCurrentHealth += currentHP - HPLevels[currentLevel - 1]; // adds health when lvl up

        currentAttack = attackLevels[currentLevel]; // + (BaseCharacterClass.
        currentDefence = defenceLevels[currentLevel]; // + BaseCharacterClass
    }
}
