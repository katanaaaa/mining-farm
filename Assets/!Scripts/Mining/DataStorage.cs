using UnityEngine;

public class DataStorage : MonoBehaviour
{
    private float _maxPlayerBitcoins;
    public bool IsStanding;
    
    private void Start()
    {
        _maxPlayerBitcoins = FindFirstObjectByType<Player>().GetMaxPlayerBitcoins();
        IsStanding = false;
    }
    private void FixedUpdate()
    {
        if (IsStanding)
        {
            DoWork();
        }
    }

    private void DoWork()
    {
        _maxPlayerBitcoins += 1;
    }
}
