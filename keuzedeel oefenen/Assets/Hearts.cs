using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hearts : MonoBehaviour
{
    [SerializeField] public Image heart1;
    [SerializeField] public Image heart2;
    [SerializeField] public Image heart3;

    // Start is called before the first frame update
    void Start()
    {
        heart1.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (AIChaise.health <= 2)
        {
            heart1.enabled = false;
        }

        if (AIChaise.health <= 1)
        {
            heart2.enabled = false;
        }

        if (AIChaise.health <= 0)
        {
            heart1.enabled = false;
        }
    }
}
