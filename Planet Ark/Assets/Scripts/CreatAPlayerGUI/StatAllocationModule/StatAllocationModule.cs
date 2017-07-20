using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatAllocationModule
{

    private string[] statNames = new string[5] { "Strength", "Dexterity", "Intellegence", "Charisma", "Luck" };
    private string[] statDescriptions = new string[5] { "Weapon Damage and Carry Capisity", "Weapon Accuracy and Dodge", "Spell Strength and Skill Points", "Bartering and Likeability", "Chance to Find Loot and Critical Hit/Miss" };
    private bool[] statSelections = new bool[5];

    public int[] pointsToAllocate = new int[5]; // starting stat values for the chosen class
    private int[] baseStatPoints = new int[5];   //starting stat values for the chosen class

    private int availPoints = 20;
    public bool didRunOnce = false;

    public void DisplayStatallocationModule()
    {
        if (!didRunOnce)
        {
            RetrieveStatBaseStatPoints();
            didRunOnce = true;
        }
        DisplayStatToggleSwitches();
        DisplayStatIncreaseDecreaseButtons();
    }

    private void DisplayStatToggleSwitches()
    {
        for (int i = 0; i < statNames.Length; i++)
        {
            statSelections[i] = GUI.Toggle(new Rect(10, 10 + (i * 60), 100, 50), statSelections[i], statNames[i]);
            GUI.Label(new Rect(100, 10 + (i * 60), 50, 50), pointsToAllocate[i].ToString());
            if (statSelections[i])
            {
                GUI.Label(new Rect(20, 60 * i + 30, 150, 100), statDescriptions[i]);
            }
        }
    }

    private void DisplayStatIncreaseDecreaseButtons()
    {
        for (int i = 0; i < pointsToAllocate.Length; i++)
        {
            if (pointsToAllocate[i] >= baseStatPoints[i] && availPoints > 0)
            {
                if (GUI.Button(new Rect(200, 10 + (i * 60), 50, 50), "+"))
                {
                    pointsToAllocate[i] += 1;
                    --availPoints;
                }
            }
            if (pointsToAllocate[i] > baseStatPoints[i])
            { 
                if (GUI.Button(new Rect(260, 10 + (i * 60), 50, 50), "-"))
                {
                    pointsToAllocate[i] -= 1;
                    ++availPoints;
                }
            }
        }
    }

    private void RetrieveStatBaseStatPoints()
    {
        BaseCharacterClass cClass = GameInformation.PlayerClass;
        pointsToAllocate[0] = cClass.Strength;
        baseStatPoints[0] = cClass.Strength;
        pointsToAllocate[1] = cClass.Dexterity;
        baseStatPoints[1] = cClass.Dexterity;    
        pointsToAllocate[2] = cClass.Intellegence;
        baseStatPoints[2] = cClass.Intellegence;
        pointsToAllocate[3] = cClass.Charisma;
        baseStatPoints[3] = cClass.Charisma;
        pointsToAllocate[4] = cClass.Luck;
        baseStatPoints[4] = cClass.Luck;
    }

}
