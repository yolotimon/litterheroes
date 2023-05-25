using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SC_CoinCounter : MonoBehaviour
{
    TextMeshProUGUI counterText;

    // Start is called before the first frame update
    void Start()
    {
        counterText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (counterText.text != SC_2DCoin.totalCoins.ToString())
        {
            counterText.text = SC_2DCoin.totalCoins.ToString();
        }
    }
}
