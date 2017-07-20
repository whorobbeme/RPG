using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseWeapon : BaseItem {


    public enum WeaponTypes {
        DAGGER,
        KNIFE,
        SHORTSWORD,
        LONGSWORD,
        GREATSWORD,
        AXE,
        BATTLEAXE,
        GREATAXE,
        MACE,
        MORNINGSTAR,
        SPEAR,
        HALBARD,
        WHIP,
        SLING,
        PISTOL,
        RIFFLE,
        LASERPISTOL,
        LIGHTCROSSBOW,
        HEAVYCROSSBOW,
        SHORTBOW,
        LONGBOW,
        SHIELD,
        TOWERSHIELD,
        BUCKLER,
        STAFF

    }
    private WeaponTypes weaponType;
    private int spellEffectID;

    public WeaponTypes WeaponType {
        get { return weaponType; }
        set {  weaponType = value;  }
    }

    public int SpellEffectID { 
        get { return spellEffectID; }
        set { spellEffectID = value; }
    }




}
