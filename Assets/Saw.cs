using UnityEngine;

public class Saw : MonoBehaviour
{
    [SerializeField] private float rotateSpeed;

    private void Update()
    {
        gameObject.transform.Rotate(0, 0, rotateSpeed);
    }
}
