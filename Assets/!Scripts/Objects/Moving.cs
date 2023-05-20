using UnityEngine;

public class Moving : MonoBehaviour
{
    private GPU _gpu;
    private DataStorage _dataStorage;
    private GameObject _ui;
    public GameObject Shop;

    [SerializeField] private LayerMask _layerToHit;

    private Vector3 _screenPosition;
    private Vector3 _worldPosition;

    private bool _mouseDown;

    private void Start()
    {
        _ui = GameObject.FindGameObjectWithTag("UI");
        Shop = (_ui.transform.GetChild(0).gameObject).transform.GetChild(1).gameObject;
        _gpu = GetComponent<GPU>();
        _dataStorage = GetComponent<DataStorage>();

        _mouseDown = false;
    }

    private void FixedUpdate()
    {
        if (!_mouseDown)
        {
            _screenPosition = Input.mousePosition;

            Ray ray = Camera.main.ScreenPointToRay(_screenPosition);

            if (Physics.Raycast(ray, out RaycastHit hitData, Mathf.Infinity, _layerToHit))
                _worldPosition = hitData.point;

            transform.position = _worldPosition;
        }
    }

    private void OnMouseDown()
    {
        _mouseDown = true;

        if (_gpu != null)
        {
            _gpu.IsStanding = true;
        }

        if (_dataStorage != null)
        {
            _dataStorage.IsStanding = true;
            _dataStorage.DoWork();
        }
    }
    private void OnMouseUp()
    {
        Shop.SetActive(true);
    }
}
