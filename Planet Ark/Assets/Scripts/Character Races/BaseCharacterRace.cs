using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacterRace
{

    private string raceName = "Needs a name";
    private string raceDescription = "Needs a Description";
    
    public string RaceName
    {
        get { return raceName; }
        set { raceName = value; }
    }

    public string RaceDescription
    {
        get { return raceDescription; }
        set { raceDescription = value; }
    }


    public bool HasStrengthBonous { get; set; }
    public bool HasDexterityBonous { get; set; }
    public bool HasIntellegenceBonous { get; set; }
    public bool HasCharismaBonous { get; set; }
    public bool HasLuckBonous { get; set; }
    
    
}