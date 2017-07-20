using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatNewPotion : MonoBehaviour {

    private BasePotion newPotion;

	// Update is called once per frame
	void Update () {
		
	}

    private void CreatPotion() {
        newPotion = new BasePotion();
        newPotion.ItemName = "Potion";
        newPotion.ItemDescription = "This is a potion";
        newPotion.ItemID = Random.Range(1, 101);
        ChoosePotionType();
    }

    private void ChoosePotionType()
    {
        System.Array potions = System.Enum.GetValues(typeof(BasePotion.PotionTypes));
        newPotion.PotionType = (BasePotion.PotionTypes)potions.GetValue(Random.Range(0, potions.Length));
    }

    
}

