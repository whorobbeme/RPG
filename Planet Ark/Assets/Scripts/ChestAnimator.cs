using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ChestAnimator : MonoBehaviour {

    Animator anim;

    //is entry or an exit
    [SerializeField]
    GameObject ChestType;

    //track the state of door
    int stateOfDoor = 1;

    public void Start()
    {
        //initialize the animator
        anim = GetComponent<Animator>();

        if (ChestType.name == "EntryDoor")
            OpenDoor();

        if (ChestType.name == "ExitDoor")
            LockDoor();

    }

   public void LockDoor()
    {
        if (ChestType.name == "ExitDoor")
        {
            anim.SetFloat("DoorState", 1);
            stateOfDoor = 1;
        }
    }

    // fucnctin to unlock door and set its state
   public void UnlockDoor()
    {
        if (ChestType.name == "ExitDoor")
        {
            anim.SetFloat("DoorState", 2);
            stateOfDoor = 2;
        }
    }

   public void OpenDoor()
    {
        if (ChestType.name == "ExitDoor")
        {
            anim.SetFloat("DoorState", 3);
            stateOfDoor = 3;
        }
                
    }
    //function to set state of door
    public void SetDoorState(int state)
    {
        if (state == 1 && ChestType.name == "ExitDoor")
            LockDoor();
        if(state == 2 && ChestType.name == "ExitDoor")
            UnlockDoor();
        if(state == 3 && ChestType.name == "ExitDoor")
            OpenDoor();
    }

    //function to get current door state
    public int GetDoorState()
    {
        return stateOfDoor;
    }
}
