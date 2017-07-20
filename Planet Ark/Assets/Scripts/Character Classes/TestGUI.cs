using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGUI : MonoBehaviour {

    private BaseCharacterClass class1 = new BaseBouncerClass();
    private BaseCharacterClass class2 = new BasePoliticianClass();

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnGUI()   {
        GUILayout.Label(class1.CharacterClassName);
        GUILayout.Label(class1.CharacterClassDescription);
        GUILayout.Label(class1.Strength.ToString());
        GUILayout.Label(class1.Dexterity.ToString());
        GUILayout.Label(class1.Intellegence.ToString());
        GUILayout.Label(class1.Charisma.ToString());
        GUILayout.Label(class1.Luck.ToString());
        GUILayout.Label(class2.CharacterClassName);
        GUILayout.Label(class2.CharacterClassDescription);
        GUILayout.Label(class2.Strength.ToString());
        GUILayout.Label(class2.Dexterity.ToString());
        GUILayout.Label(class2.Intellegence.ToString());
        GUILayout.Label(class2.Charisma.ToString());
        GUILayout.Label(class2.Luck.ToString());


    }
}
