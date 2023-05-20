using UnityEngine;

public class DataStorage : MonoBehaviour
{
    public bool IsStanding;
    
    private void Start()
    {
        IsStanding = false;
    }

    public void DoWork()
    {
        if (IsStanding)
            Player.MaxPlayerBitcoins += 1f;
        Debug.LogWarning($"MaxPlayerBitcoins = {Player.MaxPlayerBitcoins}");
    }
}
