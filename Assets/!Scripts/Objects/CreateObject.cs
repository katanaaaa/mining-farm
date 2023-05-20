using UnityEngine;

public class CreateObject : MonoBehaviour
{
    private ObjectsConfig _objectsConfig;
    public int ObjectNumber;

    public void CreateObj(int ObjectNumber)
    {
        _objectsConfig = FindFirstObjectByType<ApplicationStartUp>().ObjectsConfig;
        var objectsStorage = FindFirstObjectByType<CreateObject>();
        
        switch (ObjectNumber)
        {
            case 0:
                Instantiate(_objectsConfig.GPU, objectsStorage.transform);
                break;
            case 1:
                Instantiate(_objectsConfig.DataStorage, objectsStorage.transform);
                break;
        }
    }
}