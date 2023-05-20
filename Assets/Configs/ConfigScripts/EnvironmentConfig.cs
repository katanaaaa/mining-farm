using UnityEngine;

[CreateAssetMenu(fileName = "EnvironmentConfig", menuName = "Configs/EnvironmentConfig", order = 51)]
public class EnvironmentConfig : ScriptableObject
{
    public Light DirectionalLight;
    public GameObject MainCamera;
    public GameObject Floor;
    public GameObject ObjectsStorage;
}
