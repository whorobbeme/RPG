using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseElfRase : BaseCharacterRace
{

    public BaseElfRase()
    {
        new BaseCharacterRace();
        RaceName = "Elf";
        RaceDescription = "Elfs are frale and light on there feet with a tallent for getting themselves out of trouble";

        HasDexterityBonous = true;
        HasLuckBonous = true;

    }
}
