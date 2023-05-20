using UnityEngine;

public class GPU : MonoBehaviour
{
    private GameObject _storageFull;
    private float _period = 5f;
    private float _nextActionTime;

    private float _maxPlayerBitcoins;
    public bool IsStanding;

    private void Start()
    {
        _maxPlayerBitcoins = Player.MaxPlayerBitcoins;
        var shop = GetComponent<Moving>().Shop;

        IsStanding = false;
        _nextActionTime = 0.0f;
    }
    private void FixedUpdate()
    {
        if (IsStanding)
        {
            if (Player.Bitcoins <= _maxPlayerBitcoins)
            {
                DoWork();
            }
            else
            {
                // ����� �������������� ���� ������
                _storageFull.SetActive(true);

                Debug.LogWarning("������ �����������!!!");
            }
        }
    }

    private void DoWork()
    {
        if (Time.time > _nextActionTime)
        {
            _nextActionTime += _period;
            Player.Bitcoins += Mathf.Pow(10f, -1f);
        }
    }
}