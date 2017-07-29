using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayer : MonoBehaviour {

    public int damageToGive;
    private int currentDamage;
    public GameObject damageNumber;

    private PlayerStats thePs;

	// Use this for initialization
	void Start () {
        thePs = FindObjectOfType<PlayerStats>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D other) // two coliders meet
    {
        if (other.gameObject.name == "Player")
        {
            currentDamage = damageToGive - thePs.currentDefence;
            if (currentDamage < 0)
            {
                currentDamage = 1;
            } //damage reduction using currentDefence

            other.gameObject.GetComponent<PlayerHealthManager>().HurtPlayer(currentDamage);

            var clone = (GameObject)Instantiate(damageNumber, other.transform.position, Quaternion.Euler(Vector3.zero)); //creates an empty clone object,
            clone.GetComponent<FloatingNumbers>().damageNumber = currentDamage; //fills the empty clone object


        } 
    }
}

