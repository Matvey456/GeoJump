using System;
using UnityEngine;

public class PinkPortal : Portals
{
    [SerializeField] private GameObject ship;
    [SerializeField] private Transform point;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.transform.CompareTag("Player"))
            Spawn(ship, point);    
    }
}
