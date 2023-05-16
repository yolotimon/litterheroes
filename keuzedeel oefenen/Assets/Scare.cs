using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scare : MonoBehaviour
{
    [SerializeField] private Image imgNicolasCage;
    [SerializeField] private AudioSource Jumped;
    [SerializeField] private GameObject Trigger;

    // Start is called before the first frame update
    void Start()
    {
        imgNicolasCage.enabled = false;
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag ("ScareTrigger")) {
            StartCoroutine(ShowAndHide());
            Jumped.Play();
        }
       
    }

    IEnumerator ShowAndHide()
    {
        imgNicolasCage.enabled = true;
        yield return new WaitForSeconds(1f);
        imgNicolasCage.enabled = false;
        Destroy(Trigger);
    }
}
