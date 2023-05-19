using UnityEngine;

public class UI : MonoBehaviour
{
    private UIConfig _uiConfig;

    private void Awake()
    {
        _uiConfig = GetComponent<ApplicationStartUp>().UIConfig;

        Instantiate(_uiConfig.UI);
    }
}
