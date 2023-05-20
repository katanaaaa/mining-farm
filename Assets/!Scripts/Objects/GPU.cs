using UnityEngine;

public class GPU : MonoBehaviour
{
    [SerializeField] float _period = 5f;
    private float _nextActionTime;

    private float _playerBitcoins;
    private float _maxPlayerBitcoins;
    public bool IsStanding;

    private void Start()
    {
        _maxPlayerBitcoins = Player.MaxPlayerBitcoins;
        _playerBitcoins = Player.Bitcoins;

        IsStanding = false;
        _nextActionTime = 0.0f;
    }
    private void FixedUpdate()
    {
        if (IsStanding)
        {
            if (_playerBitcoins <= _maxPlayerBitcoins)
            {
                DoWork();
                //Debug.Log(_playerBitcoins);
            }
            else
                Debug.LogWarning("Память закончилась!!!");
        }
    }

    private void DoWork()
    {
        if (Time.time > _nextActionTime)
        {
            _nextActionTime += _period;
            _playerBitcoins += Mathf.Pow(10f, -5f);
        }
        //Debug.Log(_playerBitcoins);
    }
}