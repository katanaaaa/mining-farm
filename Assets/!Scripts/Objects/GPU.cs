using UnityEngine;
using UnityEngine.UI;

public class GPU : MonoBehaviour
{
    private GameObject _gpuButton;

    private float _period = 5f;
    private float _nextActionTime;

    public bool IsStanding;

    private void Start()
    {
        var ui = GameObject.FindGameObjectWithTag("UI");
        var shop = ui.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject;
        _gpuButton = shop.transform.GetChild(0).gameObject.transform.GetChild(2).gameObject;

        IsStanding = false;
        _nextActionTime = 0.0f;
    }
    private void FixedUpdate()
    {
        if (IsStanding)
        {
            if (Player.Bitcoins <= Player.MaxPlayerBitcoins)
            {
                _gpuButton.GetComponent<Button>().interactable = true;

                DoWork();
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