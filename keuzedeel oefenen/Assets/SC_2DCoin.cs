using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_2DCoin : MonoBehaviour
{
    public static int totalCoins = 0;
    [SerializeField] private AudioSource CoinPling;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("coin"))
        {
            totalCoins++;
            CoinPling.Play();
            Debug.Log("You currently have " + SC_2DCoin.totalCoins + " Coins");
            Destroy(col.gameObject);
        }
    }
}
