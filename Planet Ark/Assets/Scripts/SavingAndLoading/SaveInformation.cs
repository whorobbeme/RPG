using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveInformation
{

    public static void SaveAllInformation()
    {
        PlayerPrefs.SetInt("PLAYERLEVEL", GameInformation.PlayerLevel);
        PlayerPrefs.SetString("PLAYERNAME", GameInformation.PlayerName);
        PlayerPrefs.SetInt("STRENGTH", GameInformation.Strength);
        PlayerPrefs.SetInt("DEXTERITY", GameInformation.Dexterity);
        PlayerPrefs.SetInt("INTELLEGENCE", GameInformation.Intellegence);
        PlayerPrefs.SetInt("CHARISMA", GameInformation.Charisma);
        PlayerPrefs.SetInt("LUCK", GameInformation.Luck);
        PlayerPrefs.SetInt("Gold", GameInformation.Gold);

        if (GameInformation.EquipmentOne != null)
        {
            PPSerialization.Save("EQUPMENTITEM1", GameInformation.EquipmentOne);
        }
        Debug.Log("SAVED ALL INFORMATION");


    }
}