using UnityEngine;

public class JumpPads : MonoBehaviour
{
    [SerializeField] private Rigidbody2D player;
    
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.transform.CompareTag("JumpPad"))
        {
            player.AddForce(Vector2.up * 2, ForceMode2D.Impulse);
        }    
    }
}
