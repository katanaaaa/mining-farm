using UnityEngine;

public class ButtonGPU : MonoBehaviour
{
    [SerializeField] private GameObject _shop;
    [SerializeField] private GameObject _objectsStorage;
    [SerializeField] private GameObject _player;
    private float _price = 1;

    public void BuyGPU()
    {
        var playerComponent = _player.GetComponent<Player>();
        if (playerComponent.GetBitcoinsCount() >= _price)
        {
            _shop.SetActive(false);
            _objectsStorage.GetComponent<CreateObject>().CreateObj(0);
        }
    }
}