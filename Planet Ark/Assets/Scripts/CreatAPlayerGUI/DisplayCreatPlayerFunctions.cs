using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayCreatPlayerFunctions
{

    private StatAllocationModule statAllocationModule = new StatAllocationModule();

    private int classSelection;
    private string[] classSelectionNames = new string[] { "Bouncer", "Politican" };
    private string playerName = "Enter Name";
    //private string playerBio;
    
    private int genderSelection;
    private string[] genderTypes = new string[2] { "Male", "Female" };


    public void DisplayClassSelection()
    {
        classSelection = GUI.SelectionGrid(new Rect(50, 50, 250, 300), classSelection, classSelectionNames, 2);
        GUI.Label(new Rect(450, 50, 300, 300), FindClassDescription(classSelection));
        GUI.Label(new Rect(450, 100, 300, 300), FindClassStatValues(classSelection));

    }

    private string FindClassDescription(int ClassSelection)
    {
        if (classSelection == 0)
        {
            BaseCharacterClass tempClass = new BaseBouncerClass();
            return tempClass.CharacterClassDescription;
        }
        else if (classSelection == 1)
        {
            BaseCharacterClass tempClass = new BasePoliticianClass();
            return tempClass.CharacterClassDescription;
        }
        return "I Think You Broke Something";
    }

    private string FindClassStatValues(int classSelection)
    {
        if (classSelection == 0)
        {

            BaseCharacterClass tempClass = new BaseBouncerClass();
            string tempStats = "Strength " + tempClass.Strength + "\n" + "Dexterity " + tempClass.Dexterity + "\n" + "Intellegence " + tempClass.Intellegence + "\n" + "Charisma " + tempClass.Charisma + "\n" + "Luck " + tempClass.Luck;
            return tempStats;
        }

        else if (classSelection == 1)
        {

            BaseCharacterClass tempClass = new BasePoliticianClass();
            string tempStats = "Strength " + tempClass.Strength + "\n" + "Dexterity " + tempClass.Dexterity + "\n" + "Intellegence " + tempClass.Intellegence + "\n" + "Charisma " + tempClass.Charisma + "\n" + "Luck " + tempClass.Luck;
            return tempStats;
        }
        return "No stats found";
    }

    public void DisplayStatAllocation()
    {
        statAllocationModule.DisplayStatallocationModule();
    }

    public void DisplayFinalSetup()
    {
        playerName = GUI.TextArea(new Rect(20, 10, 100, 35), playerName, 25);
        genderSelection = GUI.SelectionGrid(new Rect(200, 10, 100, 70), genderSelection, genderTypes, 1);
    }

    private void ChooseClass(int classSelection)
    {
        if (classSelection == 0)
        {
            GameInformation.PlayerClass = new BaseBouncerClass();
        }
        else if (classSelection == 1)
        {
            GameInformation.PlayerClass = new BasePoliticianClass();
        }
    }

    public void DisplayMainItems()
    {

        GUI.Label(new Rect(Screen.width / 2, 20, 250, 100), "CREATE NEW PLAYER");


        if (CreatAPlayerGUI.currentState != CreatAPlayerGUI.CreatAPlayerStates.FINALSETUP) // if we are not in the final set up then show a nex button
        {

            if (GUI.Button(new Rect(470, 370, 50, 50), "Next"))
            {
                if (CreatAPlayerGUI.currentState == CreatAPlayerGUI.CreatAPlayerStates.CLASSSELECTION)
                {
                    ChooseClass(classSelection);
                    CreatAPlayerGUI.currentState = CreatAPlayerGUI.CreatAPlayerStates.STATALLOCATION;
                }
                else if (CreatAPlayerGUI.currentState == CreatAPlayerGUI.CreatAPlayerStates.STATALLOCATION)
                {
                    GameInformation.Strength = statAllocationModule.pointsToAllocate[0];
                    GameInformation.Dexterity = statAllocationModule.pointsToAllocate[1];
                    GameInformation.Intellegence = statAllocationModule.pointsToAllocate[2];
                    GameInformation.Charisma = statAllocationModule.pointsToAllocate[3];
                    GameInformation.Luck = statAllocationModule.pointsToAllocate[4];
                    CreatAPlayerGUI.currentState = CreatAPlayerGUI.CreatAPlayerStates.FINALSETUP;

                }
            }
        }
        else if (CreatAPlayerGUI.currentState == CreatAPlayerGUI.CreatAPlayerStates.FINALSETUP)
        {
            if (GUI.Button(new Rect(470, 370, 50, 50), "Finish"))
            {
                GameInformation.PlayerName = playerName;
                //GameInformation.PlayerBio = playerBio;
                if (genderSelection == 0)
                {
                    GameInformation.IsMale = true;
                }
                else if (genderSelection == 1)
                {
                    GameInformation.IsMale = false;
                        
                }
                         
                SaveInformation.SaveAllInformation();
                //final save
                Debug.Log("MAKE FINAL SAVE");
            }

        }

        if (CreatAPlayerGUI.currentState != CreatAPlayerGUI.CreatAPlayerStates.CLASSSELECTION)
            if (GUI.Button(new Rect(295, 370, 50, 50), "Back"))
            {
                if (CreatAPlayerGUI.currentState == CreatAPlayerGUI.CreatAPlayerStates.STATALLOCATION)
                {
                    statAllocationModule.didRunOnce = false;
                    GameInformation.PlayerClass = null;
                    CreatAPlayerGUI.currentState = CreatAPlayerGUI.CreatAPlayerStates.CLASSSELECTION;
                }
                else if (CreatAPlayerGUI.currentState == CreatAPlayerGUI.CreatAPlayerStates.FINALSETUP)
                {
                    CreatAPlayerGUI.currentState = CreatAPlayerGUI.CreatAPlayerStates.STATALLOCATION;
                }
            }

    }
}