using UnityEngine;

public class GPU : MonoBehaviour
{
    private Player _player;

    [SerializeField] float _period = 5f;
    private float _nextActionTime;

    private float _playerBitcoins;
    private float _maxPlayerBitcoins;
    public bool IsStanding;

    private void Start()
    {
        _player = FindFirstObjectByType<Player>();
        _playerBitcoins = _player.GetBitcoinsCount();
        _maxPlayerBitcoins = _player.GetMaxPlayerBitcoins();

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
                Debug.Log(_player.GetBitcoinsCount());
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