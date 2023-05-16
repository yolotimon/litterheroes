using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opacitychanger : MonoBehaviour
{

    [SerializeField] private GameObject wall;
    Renderer wallRend;

    // Start is called before the first frame update
    void Start()
    {
        wallRend = wall.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        wallRend.enabled = false;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        wallRend.enabled = true;
    }
}
