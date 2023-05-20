using UnityEngine;
using UnityEngine.UI;

public class ButtonBuy : MonoBehaviour
{
    [SerializeField] private GameObject _shop;
    [SerializeField] private GameObject _objectsStorage;
    [SerializeField] private GameObject _notEnoughBitcoinsWindow;
    private static readonly float[] _prices = { 1, 2 };

    public void BuyItem(int itemNumber)
    {
        var storageFull = _shop.transform.GetChild(0).gameObject.transform.GetChild(6).gameObject;

        if (Player.Bitcoins <= Player.MaxPlayerBitcoins)
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
        else
        {
            _shop.transform.GetChild(0).transform.GetChild(2).gameObject.GetComponent<Button>().interactable = false;
            if (itemNumber == 1)
            {   
                Player.Bitcoins -= _prices[itemNumber];
                _shop.SetActive(false);
                _objectsStorage.GetComponent<CreateObject>().CreateObj(itemNumber);
            }
            else
                storageFull.SetActive(true);
        }
    }
}