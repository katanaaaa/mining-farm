using UnityEngine;
using UnityEngine.UI;

public class StorageFull : MonoBehaviour
{
    [SerializeField] private GameObject _gpu;

    public void Overflow()
    {
        _gpu.GetComponent<Button>().interactable = false;
    }
}
