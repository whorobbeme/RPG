using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour {
   // [SerializeField]
   // GameObject switchOn;

    [SerializeField]
    GameObject switchOff;

    [SerializeField]
    GameObject switchOn;

    public bool isOn = false;

    private void Start()
    {
        //set the switch to off sprite
      gameObject.GetComponent<SpriteRenderer>().sprite = switchOff.GetComponent<SpriteRenderer>().sprite;
    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        //set the switch to on sprite
        
         gameObject.GetComponent<SpriteRenderer>().sprite = switchOn.GetComponent<SpriteRenderer>().sprite;

        //set is on to true when triggered
        isOn = true;
        
    }

}
