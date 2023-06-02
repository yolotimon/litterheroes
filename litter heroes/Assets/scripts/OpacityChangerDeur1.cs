using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpacityChangerDeur1 : MonoBehaviour
{
    [SerializeField] private GameObject Deur;
    private Renderer DeurRenderer;

    // Start is called before the first frame update
    void Start()
    {
        DeurRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (SC_2DCoin.totalCoins == 22)
        {
            DeurRenderer.enabled = false;
        }
    }
}