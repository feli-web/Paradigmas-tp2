using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public TextMeshProUGUI[] texts;
    void Start()
    {
        Store ironSword = new Store();
        ironSword.itemName = "Iron Sword";
        ironSword.price = 1.5f;
        
        Store woodShield = new Store();
        woodShield.itemName = "Wood Shield";
        woodShield.price = 0.5f;
        
        Store rayGun = new Store();
        rayGun.itemName = "Ray Gun";
        rayGun.price = 9999f;

        Debug.Log(ironSword.itemName + ": $" + ironSword.price.ToString("0.00"));
        Debug.Log(woodShield.itemName + ": $" + woodShield.price.ToString("0.00"));
        Debug.Log(rayGun.itemName + ": $" + rayGun.price.ToString("0.00"));
        texts[0].text = ironSword.itemName + ": $" + ironSword.price.ToString("0.00");
        texts[1].text = woodShield.itemName + ": $" + woodShield.price.ToString("0.00");
        texts[2].text = rayGun.itemName + ": $" + rayGun.price.ToString("0.00");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
