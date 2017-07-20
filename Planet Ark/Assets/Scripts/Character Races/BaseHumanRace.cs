using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseHumanRace : BaseCharacterRace
{

    public BaseHumanRace()
    {
        new BaseCharacterRace();
        RaceName = "Human";
        RaceDescription = "The Human race are considered rabbits by other races, along with being quick thinkers";
        
        HasIntellegenceBonous = true;
        HasCharismaBonous = true;
    }
}
