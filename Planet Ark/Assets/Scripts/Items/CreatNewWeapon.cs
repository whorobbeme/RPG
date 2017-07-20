using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatNewWeapon : MonoBehaviour
{

    private BaseWeapon newWeapon;

    public void CreatWeapon()
    {

        newWeapon = new BaseWeapon();

        //assign name to weapon
        newWeapon.ItemName = "W" + Random.Range(1, 101);
        //creat a weapon description
        newWeapon.ItemDescription = "This is a weapon";
        //weapon id
        newWeapon.ItemID = Random.Range(1, 101);
        //stats
        newWeapon.Strength = Random.Range(1, 11);
        newWeapon.Dexterity = Random.Range(1, 11);
        newWeapon.Intellegence = Random.Range(1, 11);
        newWeapon.Charisma = Random.Range(1, 11);
        newWeapon.Luck = Random.Range(1, 11);
        //choose type of weapon
        ChooseWeaponType();
        //spell effect id
        newWeapon.SpellEffectID = Random.Range(1, 101);
    }

    private void ChooseWeaponType()
    {
        

        System.Array weapons = System.Enum.GetValues(typeof(BaseWeapon.WeaponTypes));
        newWeapon.WeaponType = (BaseWeapon.WeaponTypes)weapons.GetValue(Random.Range(0, weapons.Length));
    }
}

        
