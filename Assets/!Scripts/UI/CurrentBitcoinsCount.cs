using TMPro;
using UnityEngine;

public class CurrentBitcoinsCount : MonoBehaviour
{
    public TextMeshProUGUI BitcoinsCount;

    private void FixedUpdate()
    {
        BitcoinsCount.text = Player.Bitcoins.ToString();
    }
}
