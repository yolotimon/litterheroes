using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrashCans : MonoBehaviour
{
    [SerializeField] public Image trashcan1;
    [SerializeField] public Image trashcan2;
    [SerializeField] public Image trashcan3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        {
            if (PowerUpPick.PowerUps == 1)
            {
                trashcan1.enabled = true;
            }

            if (PowerUpPick.PowerUps == 2)
            {
                trashcan2.enabled = true;
            }

            if (PowerUpPick.PowerUps == 3)
            {
                trashcan3.enabled = true;
            }
        }
    }
}
