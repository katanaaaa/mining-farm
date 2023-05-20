using TMPro;
using UnityEngine;

public class CurrentBitcoinsCount : MonoBehaviour
{
    public TextMeshProUGUI BitcoinsCount;

    private void FixedUpdate()
    {
        BitcoinsCount.text = $"Current bitcoins count: {(int)Player.Bitcoins}";
    }
}
