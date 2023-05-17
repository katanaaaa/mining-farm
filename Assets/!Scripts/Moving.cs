using UnityEngine;

public class Moving : MonoBehaviour
{
    private GPU _gpu;

    [SerializeField] private LayerMask _layerToHit;
    private Vector3 _screenPosition;
    private Vector3 _worldPosition;

    private int _clickCount;
    private bool _mouseDown;

    private void Awake()
    {
        _gpu = GetComponent<GPU>();

        _mouseDown = true;
        _clickCount = 0;
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
        _clickCount++;
        if (_clickCount < 2)
        {
            _mouseDown = true;
            if (_gpu != null)
                _gpu.IsStanding = false;
        }
        else
        {
            _mouseDown = false;
            _clickCount = 0;

            if (_gpu != null) 
                _gpu.IsStanding = true;
        }
    }
}
