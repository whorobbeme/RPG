using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInformation : MonoBehaviour {

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    public static bool IsMale { get; set; }
    public static string PlayerBio { get; set; }
    public static BaseEquipment EquipmentOne{ get; set;}
    public static string PlayerName { get; set; }
    public static int PlayerLevel { get; set; }
    public static BaseCharacterClass PlayerClass { get; set; }
    public static int Strength { get; set; }
    public static int Dexterity { get; set; }
    public static int Intellegence { get; set; }
    public static int Charisma { get; set; }
    public static int Luck { get; set; }
    public static int Gold { get; set; }
    public static int CurrentXP { get; set; }
    public static int RequiredXP { get; set; }
}