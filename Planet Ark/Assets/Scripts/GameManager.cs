using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    // Use this for initialization
    
        [SerializeField]
    GameObject[] switches;

    [SerializeField]
    GameObject exitDoor;

    int noOfSwitches = 0;

    [SerializeField]
    Text switchCount;

    void Start()
    {
        GetNoOfSwitches();
    }

    public int GetNoOfSwitches()
    {

        int x = 0;

        for (int i = 0; i < switches.Length; i++)
        {
            if (switches[i].GetComponent<Switch>().isOn == false)
                x++;
            else if (switches[i].GetComponent<Switch>().isOn == true)
                noOfSwitches--;
        }

        noOfSwitches = x;

        return noOfSwitches;
    }

    public void GetExitDoorState()
    {
        if (noOfSwitches <= 0)
        {
            exitDoor.GetComponent<ChestAnimator>().OpenDoor();
            Debug.Log("open door");
        }
    }

    public void Update()
    {
        switchCount.text = GetNoOfSwitches().ToString();
        GetExitDoorState();
    }
}


