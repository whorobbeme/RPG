using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpTarget : MonoBehaviour {

	public Transform warpTarget; // Transform

    
    IEnumerator OnTriggerEnter2D(Collider2D other){   //other

        Debug.Log("An object collided.");

        ScreenFader sf = GameObject.FindGameObjectWithTag("Fader").GetComponent<ScreenFader>();

        Debug.Log("fade out");

       // yield return StartCoroutine(sf.FadeToBlack());

        Debug.Log("player position");
        if (other.gameObject.name == "Player") //
        {
            yield return StartCoroutine(sf.FadeToBlack()); //
            other.gameObject.transform.position = warpTarget.position;
            Camera.main.transform.position = warpTarget.position;
            yield return StartCoroutine(sf.FadeToClear()); //
        }

       /* if (player.gameObject.name == "Player") // new warp?
        {
           // ScreenFader sf = GameObject.FindGameObjectWithTag("Fader").GetComponent<ScreenFader>();
            player.gameObject.transform.position = warpTarget.position;
            Camera.main.transform.position = warpTarget.position;
            yield return StartCoroutine(sf.FadeToBlack());

            
            yield return StartCoroutine(sf.FadeToClear());
        }*/

       // yield return StartCoroutine (sf.FadeToClear());

        Debug.Log("fade in");
    }

}

