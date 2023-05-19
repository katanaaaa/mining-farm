using UnityEngine;

public class Moving : MonoBehaviour
{
    private GameObject _ui;
    private GPU _gpu;

    [SerializeField] private LayerMask _layerToHit;
    private Vector3 _screenPosition;
    private Vector3 _worldPosition;

    private bool _mouseDown;

    private void Awake()
    {
        _gpu = GetComponent<GPU>();
        _ui = GameObject.FindGameObjectWithTag("UI");

        _mouseDown = true;
    }

    private void FixedUpdate()
    {
        if (_mouseDown)
        {
            _screenPosition = Input.mousePosition;

            Ray ray = Camera.main.ScreenPointToRay(_screenPosition);

            if (Physics.Raycast(ray, out RaycastHit hitData, Mathf.Infinity, _layerToHit))
            {
                _worldPosition = hitData.point;
            }

            transform.position = _worldPosition;
        }
    }

    private void OnMouseDown()
    {
        _mouseDown = false;

        if (_gpu != null)
        {
            _gpu.IsStanding = true;
        }

        var shop = (_ui.transform.GetChild(0).gameObject).transform.GetChild(1).gameObject;
        shop.SetActive(true);
    }
}
