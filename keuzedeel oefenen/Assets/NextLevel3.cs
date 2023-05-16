using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SC_2DCoin.totalCoins = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Startgame()
    {
        SceneManager.LoadScene("Level3");
    }
}
