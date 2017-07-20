using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class IncreaseExperience
{

    private static int xpToGive;
    private static LevelUp levelUpScript = new LevelUp();


    public static void AddExperience()
    {
        xpToGive = GameInformation.PlayerLevel * 100;
        GameInformation.CurrentXP += xpToGive;
        CheckToSeeIfPlayerLeveled();
        Debug.Log(xpToGive);
    }

    public static void DiscoverExperience()
    {
        xpToGive = GameInformation.PlayerLevel * 100;
        GameInformation.CurrentXP += xpToGive;
        CheckToSeeIfPlayerLeveled();
        Debug.Log(xpToGive);
    }

    private static void CheckToSeeIfPlayerLeveled()
    {
        if (GameInformation.CurrentXP >= GameInformation.RequiredXP)
        {
            levelUpScript.LevelUpCharacter();

        }


    }

    
}