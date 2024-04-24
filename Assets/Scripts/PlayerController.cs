using System;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody2D), typeof(BoxCollider2D))]
public class PlayerController : Sounds
{
    private Rigidbody2D _rb;
    [SerializeField] private protected float jumpForce = 5;
    private bool _isGrounded;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _isGrounded)
            Jump();
    }

    public virtual void Jump()
    {
        _rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        _rb.AddTorque(15);
        PlaySound(sounds[0]);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.CompareTag("Ground"))
            _isGrounded = true;
    }
    
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.transform.CompareTag("Ground"))
            _isGrounded = false;
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.transform.CompareTag("Obstacle"))
            SceneManager.LoadScene(0);
    }
}
