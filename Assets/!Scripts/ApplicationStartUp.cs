using UnityEngine;

public class ApplicationStartUp : MonoBehaviour
{
    public EnvironmentConfig EnvironmentConfig;
    public UIConfig UIConfig;
    public PlayerConfig PlayerConfig;
    public ObjectsConfig ObjectsConfig;

    void Awake()
    {
        gameObject.AddComponent<Environment>();
        gameObject.AddComponent<UI>();
        gameObject.AddComponent<CreatePlayer>();
    }
}