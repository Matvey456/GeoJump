using UnityEngine;

public abstract class Portals : MonoBehaviour
{
    public virtual void Spawn(GameObject gameMode, Transform spawnGameModePoint)
    {
        Instantiate(gameMode, spawnGameModePoint);
    }
}
