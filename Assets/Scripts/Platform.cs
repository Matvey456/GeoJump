using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] private GameObject[] objectsToMove;
    [SerializeField] private float speed = -0.0075f;
    
    void Update()
    {
        for (int i = 0; i < objectsToMove.Length; i++)
        {
            objectsToMove[i].transform.Translate(speed, 0, 0);
        }       
    }
}
