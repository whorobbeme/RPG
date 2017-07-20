using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseHalfOrcRace : BaseCharacterRace
{

    public BaseHalfOrcRace()
    {
        new BaseCharacterRace();
        RaceName = "Half Orc";
        RaceDescription = "Half Orcs are seen as easly angered bruts, strong as an ox and sometimes just as dumb";

        HasStrengthBonous = true;
        HasDexterityBonous = true;
        
    }
}