using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _maxPlayerBitcoins;
    private float _bitcoins;

    private void Awake()
    {
        _bitcoins = 0f;
    }

    public ref float GetBitcoinsCount()
    {
        return ref _bitcoins;
    }

    public ref float GetMaxPlayerBitcoins()
    {
        return ref _maxPlayerBitcoins;
    }
}
