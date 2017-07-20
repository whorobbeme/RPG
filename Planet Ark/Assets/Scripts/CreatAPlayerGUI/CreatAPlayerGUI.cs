using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatAPlayerGUI : MonoBehaviour
{

    public enum CreatAPlayerStates
    {
        CLASSSELECTION, //display all class types
        STATALLOCATION, // allocate stats where the player wants them
        FINALSETUP      // add name and misc items
    }

    private DisplayCreatPlayerFunctions displayFunctions = new DisplayCreatPlayerFunctions();
    public static CreatAPlayerStates currentState;

    // Use this for initialization
    void Start()
    {
        currentState = CreatAPlayerStates.CLASSSELECTION;


    }

    // Update is called once per frame
    void Update()
    {
        switch (currentState)
        {
            case (CreatAPlayerStates.CLASSSELECTION):
                break;
            case (CreatAPlayerStates.STATALLOCATION):
                break;
            case (CreatAPlayerStates.FINALSETUP):
                break;

        }

    }

    void OnGUI()
    {
        displayFunctions.DisplayMainItems();
        if (currentState == CreatAPlayerStates.CLASSSELECTION)
        {
            displayFunctions.DisplayClassSelection();

        }
        if (currentState == CreatAPlayerStates.STATALLOCATION)
        {
            displayFunctions.DisplayStatAllocation();
        }
        if (currentState == CreatAPlayerStates.FINALSETUP)
        {
            displayFunctions.DisplayFinalSetup();
        }
    }
}
