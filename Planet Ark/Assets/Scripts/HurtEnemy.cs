using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtEnemy : MonoBehaviour {

    public int damageToGive;
    private int currentDamage;
    public GameObject damageBurst;
    public Transform burstPoint;
    public GameObject damageNumber;

    private PlayerStats thePS; //makes refrence to PlayerStats script where currentAttack is (alter to use strength for damage aslo)
    private BaseCharacterClass strengthBonous; //
    // Use this for initialization
    void Start ()
    {
        thePS = FindObjectOfType<PlayerStats>();
      
	}

    // Update is called once per frame
    void Update()
    {

        

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            //Destroy(other.gameObject);
            currentDamage = damageToGive + thePS.currentAttack; //can be used to add strength to damage

            other.gameObject.GetComponent<EnemyHealthManager>().HurtEnemy(currentDamage);
            Instantiate(damageBurst, burstPoint.position, burstPoint.rotation); // activates Damage burst prefab
            var clone = (GameObject)Instantiate(damageNumber, burstPoint.position, Quaternion.Euler(Vector3.zero)); //creates an empty clone object,
            clone.GetComponent<FloatingNumbers>().damageNumber = currentDamage; //fills the empty clone object
        }
    }

    
}
