using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIChaise : MonoBehaviour
{
    public static int health = 3;
    public GameObject player;
    public float speed;
    [SerializeField] private AudioSource scream;
    //float inputHorizontal;

    //bool facingRight = false;

    private float distance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //inputHorizontal = Input.GetAxisRaw("Horizontal");

        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;

        //if (inputHorizontal > 0 && !facingRight)
        //{
        //    flip();
        //}
        //else if (inputHorizontal < 0 && facingRight)
        //{
        //    flip();
        //}

        if (distance < 16)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            scream.Play();
            health--;
            Debug.Log("you have " + health + " lives left!");
            Destroy(gameObject);
        }
    }

    //void flip()
    //{
    //    Vector3 currentScale = gameObject.transform.localScale;
    //    currentScale.x *= -1;
    //    gameObject.transform.localScale = currentScale;

    //    facingRight = !facingRight;
    //}

}
