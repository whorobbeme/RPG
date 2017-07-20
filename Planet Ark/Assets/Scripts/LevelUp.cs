using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUp  {

    public int maxPlayerLevel = 50;

    public void LevelUpCharacter()
    {
        //check to see if current XP > than required xp
        if (GameInformation.CurrentXP > GameInformation.RequiredXP)
        {
            GameInformation.CurrentXP -= GameInformation.RequiredXP;
        }
        else
        {
            GameInformation.CurrentXP = 0;
        }
        if (GameInformation.PlayerLevel < maxPlayerLevel)
        {
            GameInformation.PlayerLevel += 1;
        }
        else
        {
            GameInformation.PlayerLevel = maxPlayerLevel;
        }
        //give statpoints
        //give ability points
        //determin the next amount of required xp
        DetermineRequiredXP();
    
    }

    private void DetermineRequiredXP()
    {

        int temp = (GameInformation.PlayerLevel * 100) + 100;
        GameInformation.RequiredXP = temp;

    }
}