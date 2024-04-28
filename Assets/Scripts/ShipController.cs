using UnityEngine;

public class ShipController : PlayerController
{
    private Rigidbody2D _rb;
    private Vector2 _dir;

    private void Start() => _rb = GetComponent<Rigidbody2D>();

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
            Jump();
    }

    private void Jump()
    {
        _rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
    
}
