using UnityEngine;

public class Environment : MonoBehaviour
{
    private EnvironmentConfig _environmentConfig;
    private void Awake()
    {
        _environmentConfig = GetComponent<ApplicationStartUp>().EnvironmentConfig;

        Instantiate(_environmentConfig.DirectionalLight, Vector3.zero, Quaternion.identity);
        Instantiate(_environmentConfig.MainCamera);
        Instantiate(_environmentConfig.Floor);
        Instantiate(_environmentConfig.ObjectsStorage);
    }
}
