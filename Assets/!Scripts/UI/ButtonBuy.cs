using UnityEngine;

public class ButtonBuy : MonoBehaviour
{
    [SerializeField] private GameObject _shop;
    [SerializeField] private GameObject _objectsStorage;
    [SerializeField] private GameObject _notEnoughBitcoinsWindow;
    private static readonly float[] _prices = { 1, 2 };

    public void BuyItem(int itemNumber)
    {
        if (Player.Bitcoins >= _prices[itemNumber])
        {
            Player.Bitcoins -= _prices[itemNumber];
            _shop.SetActive(false);
            _objectsStorage.GetComponent<CreateObject>().CreateObj(itemNumber);
        }
        else
            _notEnoughBitcoinsWindow.SetActive(true);
    }
}