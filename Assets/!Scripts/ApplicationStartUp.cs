using UnityEngine;

public class ApplicationStartUp : MonoBehaviour
{
    public EnvironmentConfig EnvironmentConfig;
    void Awake()
    {
        gameObject.AddComponent<Environment>();
    }
}
