using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] public float speed = 100f;
    protected Vector2 input;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Animator animator;
    [SerializeField] private SpriteRenderer spriteRenderer;
    private void Awake()
    {
        if (rb == null)
        {
            rb = GetComponentInParent<Rigidbody2D>();
        }
        if (animator == null)
        {
            animator = GetComponentInChildren<Animator>();
        }
        if (spriteRenderer == null)
            spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    void Update()
    {
        this.InputMove();
        this.HandleInput();
    }

    private void FixedUpdate()
    {
        this.Move();
    }

    protected virtual void InputMove()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        input = new Vector2(x, y).normalized;
    }

    protected virtual void Move()
    {
        rb.velocity = input * speed * Time.fixedDeltaTime;
    }

    private void HandleInput()
    {
        animator.SetBool("isMoving", input.magnitude > 0.1f);

        animator.SetFloat("Horizontal", input.x);
        animator.SetFloat("Vertical", input.y);

        if (input.x > 0.1f) spriteRenderer.flipX = false;
        if (input.x < -0.1f) spriteRenderer.flipX = true;
    }
}
