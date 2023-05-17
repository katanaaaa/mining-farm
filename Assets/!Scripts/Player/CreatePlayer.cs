using UnityEngine;

public class CreatePlayer : MonoBehaviour
{
    private PlayerConfig _playerConfig;

    private void Awake()
    {
        _playerConfig = GetComponent<ApplicationStartUp>().PlayerConfig;

        Instantiate(_playerConfig.Player);
    }
}
