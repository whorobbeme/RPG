using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurneBasedCombatStateMachine : MonoBehaviour
{
    private bool hasAddedXP = false;

    public enum BattleStates
    {
        START,
        PLAYERCHOISE,
        ENEMYCHOISE,
        LOOSE,
        WIN

    }

    private BattleStates currentState;

    void Start()
    {
        hasAddedXP = false;
        currentState = BattleStates.START;
    }

    void Update()
    {
        Debug.Log(currentState);
        switch (currentState)
        {
            case (BattleStates.START):
                //SETUP BATTLE FUNCTION
                break;
            case (BattleStates.PLAYERCHOISE):
                break;
            case (BattleStates.ENEMYCHOISE):
                break;
            case (BattleStates.LOOSE):
                break;
            case (BattleStates.WIN):
                if (!hasAddedXP)
                {
                    IncreaseExperience.AddExperience();
                    hasAddedXP = true;
                
                }
                break;

        }
    }

    private void OnGUI()
    {
        if (GUILayout.Button("NEXT STATE"))
        {
            if (currentState == BattleStates.START)
            {
                currentState = BattleStates.PLAYERCHOISE;
            }
            else if (currentState == BattleStates.PLAYERCHOISE)
            {
                currentState = BattleStates.ENEMYCHOISE;
            }
            else if (currentState == BattleStates.ENEMYCHOISE)
            {
                currentState = BattleStates.LOOSE;
            }
            else if (currentState == BattleStates.LOOSE)
            {
                currentState = BattleStates.WIN;
            }
            else if (currentState == BattleStates.WIN)
            {
                currentState = BattleStates.START;
            }
        }
    }
}



