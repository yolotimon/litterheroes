using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private float attackCooldown;
    private playermovement playerMovement;
    private float cooldownTimer = Mathf.Infinity;
    private Animator anim;

    private void Awake()
    {
        playerMovement = GetComponent<playermovement>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && cooldownTimer > attackCooldown && playerMovement.canAttack())
        {
            Attack();

            cooldownTimer += Time.deltaTime;
        }
    }

    private void Attack()
    {
        cooldownTimer = 0;
    }

    //https://www.youtube.com/watch?v=PUpC44Q64zY&list=PLgOEwFbvGm5o8hayFB6skAfa8Z-mw4dPV&index=5

}
