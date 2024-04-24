using UnityEngine;

public class ShipController : PlayerController
{
    private Rigidbody2D _rb;
    private Vector2 _dir;
    [SerializeField] private float speed;

    private void Start() => _rb = GetComponent<Rigidbody2D>();

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Jump();
    }

    public override void Jump()
    {
        _rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
    
    private void Flying()
    {
        var v = Input.GetAxis("Vertical");
        
        _dir = new Vector2(v, 0);
        _rb.velocity = _dir * jumpForce;
    }
}
