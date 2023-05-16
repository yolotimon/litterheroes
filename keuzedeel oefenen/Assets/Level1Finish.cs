using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1Finish : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && SC_2DCoin.totalCoins >= 20)
        {
            SceneManager.LoadScene("level1end");
            Debug.Log("Level completed");
        }

        else if (collision.gameObject.CompareTag("Player") && SC_2DCoin.totalCoins < 20)
        {
            Debug.Log("Not enough coins");
        }
    }
}
