using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpPick : MonoBehaviour
{
    public static int PowerUps = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("PowerUp"))
        {
            PowerUps++;
            Debug.Log("You currently have " + PowerUpPick.PowerUps + " trash cans");
            Destroy(col.gameObject);
        }
    }
}   
