using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OctoMovementController : MonoBehaviour
{
    public float speed;
    private Rigidbody2D octoRigidbody;
    private Vector3 change;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        InitializeVariables();
    }

    private void InitializeVariables()
    {
        octoRigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        change = Vector3.zero;
        change.x = Input.GetAxis("Horizontal");
        change.y = Input.GetAxis("Vertical");

        if (change != Vector3.zero)
        {
            Move();
            animator.SetFloat("moveX", change.x);
            animator.SetFloat("moveY", change.y);
        }
    }



    private void Move()
    {
        octoRigidbody.MovePosition(transform.position + change * speed * Time.deltaTime);
    }
}
