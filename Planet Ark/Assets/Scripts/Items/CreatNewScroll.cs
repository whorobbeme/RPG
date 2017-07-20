using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatNewScroll : MonoBehaviour
{

    private BaseScroll newScroll;

    // Use this for initialization
    void Start()
    {

    }

    private void CreatScroll() {
        newScroll = new BaseScroll();
        newScroll.ItemName = "Scroll";
        newScroll.ItemDescription = "This is a powerfull Scroll";
        newScroll.ItemID = Random.Range(1, 101);
        newScroll.SpellEffectID = Random.Range(500, 1001);

    }
}
