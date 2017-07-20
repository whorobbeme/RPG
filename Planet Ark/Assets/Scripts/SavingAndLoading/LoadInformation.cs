using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadInformation {

    public static void LoadAllInformation()
    {
        GameInformation.PlayerName = PlayerPrefs.GetString("PLAYERNAME");
        GameInformation.PlayerLevel = PlayerPrefs.GetInt("PLAYERLAVEL");
        GameInformation.Strength = PlayerPrefs.GetInt("STRENGTH");
        GameInformation.Dexterity = PlayerPrefs.GetInt("DEXTERITY");
        GameInformation.Intellegence = PlayerPrefs.GetInt("INTELLEGENCE");
        GameInformation.Charisma = PlayerPrefs.GetInt("CHARISMA");
        GameInformation.Luck = PlayerPrefs.GetInt("LUCK");
        GameInformation.Gold = PlayerPrefs.GetInt("Gold");


        if (PlayerPrefs.GetString("EQUPMENTITEM1") != null) {

            GameInformation.EquipmentOne = (BaseEquipment)PPSerialization.Load("EQUPMENTITEM1");
        }
    }

}
	