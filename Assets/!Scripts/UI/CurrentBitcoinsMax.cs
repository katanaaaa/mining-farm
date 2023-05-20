using TMPro;
using UnityEngine;

public class CurrentBitcoinsMax : MonoBehaviour
{
    public TextMeshProUGUI BitcoinsMax;

    private void FixedUpdate()
    {
        BitcoinsMax.text = $"Max bitcoins count: {((int)Player.MaxPlayerBitcoins)}";
    }
}
