using UnityEngine;

public class ApplicationStartUp : MonoBehaviour
{
    public EnvironmentConfig EnvironmentConfig;
    public PlayerConfig PlayerConfig;
    void Awake()
    {
        gameObject.AddComponent<Environment>();
        gameObject.AddComponent<CreatePlayer>();
    }
}