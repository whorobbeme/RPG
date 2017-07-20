using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreatNewCharacter : MonoBehaviour {

    private BasePlayer newPlayer;
    private bool isBouncerClass;
    private bool isPoliticianClass;
    private string playerName = "EnterName";

	// Use this for initialization
	void Start () {
        newPlayer = new BasePlayer();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

   void OnGUI()
    {
        playerName = GUILayout.TextArea(playerName,15);
        isBouncerClass = GUILayout.Toggle(isBouncerClass, "Bouncer");
        isPoliticianClass = GUILayout.Toggle(isPoliticianClass, "Politician");
        if (GUILayout.Button("Create"))
        {
            if (isPoliticianClass)
            {
                newPlayer.PlayerClass = new BasePoliticianClass();
            }
            else if (isBouncerClass)
            {
                newPlayer.PlayerClass = new BaseBouncerClass();
            }
            CreatNewPlayer();
            StoreNewPlayerInfo();
            SaveInformation.SaveAllInformation();

            
        }
        if (GUILayout.Button("Load"))
        {
            SceneManager.LoadScene("LoadTeastSceans");
        }
    }


    private void StoreNewPlayerInfo() {
        GameInformation.PlayerName = newPlayer.PlayerName;
        GameInformation.PlayerLevel = newPlayer.PlayerLevel;
        GameInformation.Strength = newPlayer.Strength;
        GameInformation.Dexterity = newPlayer.Dexterity;
        GameInformation.Intellegence = newPlayer.Intellegence;
        GameInformation.Charisma = newPlayer.Charisma;
        GameInformation.Luck = newPlayer.Luck;
        GameInformation.Gold = newPlayer.Gold;
    }
        private void CreatNewPlayer()
    {
        newPlayer.PlayerLevel = 1;
        newPlayer.Strength = newPlayer.PlayerClass.Strength;
        newPlayer.Dexterity = newPlayer.PlayerClass.Dexterity;
        newPlayer.Intellegence = newPlayer.PlayerClass.Intellegence;
        newPlayer.Charisma = newPlayer.PlayerClass.Charisma;
        newPlayer.Luck = newPlayer.PlayerClass.Luck;
        newPlayer.Gold = 50;
        newPlayer.PlayerName = playerName;
        Debug.Log("Player Name: " + newPlayer.PlayerName);
        Debug.Log("Player Class: " + newPlayer.PlayerClass.CharacterClassName);
        Debug.Log("Player Level: " + newPlayer.PlayerLevel);
        Debug.Log("Player Strength: " + newPlayer.Strength);
        Debug.Log("Player Dexterity: " + newPlayer.Dexterity);
        Debug.Log("Player Intellegence: " + newPlayer.Intellegence);
        Debug.Log("Player Charisma: " + newPlayer.Charisma);
        Debug.Log("Player Luck: " + newPlayer.Luck);
        Debug.Log("Player Gold: " + newPlayer.Gold);
    }

}
