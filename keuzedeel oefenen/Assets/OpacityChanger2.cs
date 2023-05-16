using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class OpacityChanger2 : MonoBehaviour
{

    [SerializeField] private GameObject wall;
    TilemapRenderer wallRend;

    // Start is called before the first frame update
    void Start()
    {
        wallRend = wall.GetComponent<TilemapRenderer>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            wallRend.enabled = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            wallRend.enabled = true;
        }
        }
    }

