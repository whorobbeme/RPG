using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TsetScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        LoadInformation.LoadAllInformation();
        Debug.Log("Player Name: " + GameInformation.PlayerName);
        //Debug.Log("Player Class: " + GameInformation.PlayerClass.CharacterClassName);
        Debug.Log("Player Level: " + GameInformation.PlayerLevel);
        Debug.Log("Player Strength: " + GameInformation.Strength);
        Debug.Log("Player Dexterity: " + GameInformation.Dexterity);
        Debug.Log("Player Intellegence: " + GameInformation.Intellegence);
        Debug.Log("Player Charisma: " + GameInformation.Charisma);
        Debug.Log("Player Luck: " + GameInformation.Luck);
        Debug.Log("Player Gold: " + GameInformation.Gold);


    }

    // Update is called once per frame
    void Update () {
		
	}
}
