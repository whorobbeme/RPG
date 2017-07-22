using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpTarget : MonoBehaviour {

	public Transform warpTarget; // Transform

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D player){   //other
	
		Debug.Log ("An object collided.");
		//other.gameObject.transform.position = warpTarget.position;
		//Camera.main.transform.position = warpTarget.position;

        if (player.gameObject.name == "Player") // new warp?
        {
            player.gameObject.transform.position = warpTarget.position;
            Camera.main.transform.position = warpTarget.position;
        }
    }
}

