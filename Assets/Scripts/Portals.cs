using UnityEngine;

public class Portals : MonoBehaviour
{
    [SerializeField] private Transform spawnShipPoint;
    [SerializeField] private GameObject ship;
    [SerializeField] private AudioSource source;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.CompareTag("PinkPortal"))
        {
            source.Play();
            Instantiate(ship, spawnShipPoint.position, Quaternion.identity);
            Destroy(gameObject);
            StaticHolder.isShip = true;
        }
    }
}
