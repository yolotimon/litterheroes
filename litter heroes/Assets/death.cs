using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class death : MonoBehaviour
{

    private Rigidbody2D rb;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("death"))
        {
            Die();
        }
    }

    private void Update()
    {
        if (AIChaise.health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        //transform.position = new Vector3(-10, -2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        AIChaise.health = 3;
        SC_2DCoin.totalCoins = 0;
        Debug.Log("You died and lost all your coins!");
    }
}
