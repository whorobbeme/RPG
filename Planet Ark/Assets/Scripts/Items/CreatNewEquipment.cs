using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatNewEquipment : MonoBehaviour {

    private BaseEquipment newEquipment;
    private string[] itemNames = new string[4] { "Common", "Uncommon", "Rare", "Legendery" };
    private string[] itemDes = new string[2] { "A new looking item", "An old looking item" };


     void Start()
    {
        
    }

    private void CreateEquipment() {
        newEquipment = new BaseEquipment();
        newEquipment.ItemName = itemNames[Random.Range(0, 3)] + " Item";
        newEquipment.ItemID = Random.Range(1, 101);
        ChooseItemType();
        newEquipment.ItemDescription = itemDes[Random.Range(0, itemDes.Length)];
        newEquipment.Strength = Random.Range(1, 11);
        newEquipment.Dexterity = Random.Range(1, 11);
        newEquipment.Intellegence = Random.Range(1, 11);
        newEquipment.Charisma = Random.Range(1, 11);
        newEquipment.Luck = Random.Range(1, 11);
    }

    private void ChooseItemType() {
        int randomTemp = Random.Range(1, 14);
        if (randomTemp == 1)
        {
            newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.HEAD;
        }
        else if (randomTemp == 2)
        {
            newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.EYES;
        }
        else if (randomTemp == 3)
        {
            newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.EARS;
        }
        else if (randomTemp == 4)
        {
            newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.NECK;
        }
        else if (randomTemp == 5)
        {
            newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.ARMS;
        }
        else if (randomTemp == 6)
        {
            newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.LEFTARM;
        }
        else if (randomTemp == 7)
        {
            newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.RIGHTARM;
        }
        else if (randomTemp == 8)
        {
            newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.CHEST;
        }
        else if (randomTemp == 9)
        {
            newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.LEGS;
        }
        else if (randomTemp == 10)
        {
            newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.FEET;
        }
        else if (randomTemp == 11)
        {
            newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.LEFTRING;
        }
        else if (randomTemp == 12)
        {
            newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.RIGHTRING;
        }
        else if (randomTemp == 13)
        {
            newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.CLOAK;
        }
        else if (randomTemp == 14)
        {
            newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.ROBE;
        }
    }

    private void Update()
    {
        
    }
}
