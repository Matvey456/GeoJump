using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField] private float startSize, endSize, currentSize, time;
    [SerializeField] private Camera camera;

    private void Update() => CameraSize();

    private void CameraSize()
    {
        if (StaticHolder.isShip && currentSize < endSize)
        {
            currentSize = Mathf.Lerp(startSize, endSize, 1); 
            camera.orthographicSize = currentSize;
        }
    }
}