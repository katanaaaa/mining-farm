using UnityEngine;

public class MoveObject : MonoBehaviour
{
    [SerializeField] private LayerMask _layerToHit;
    private Vector3 _screenPosition;
    private Vector3 _worldPosition;
    private bool _mouseDown;
    private int _clickCount;

    private void Awake()
    {
        _mouseDown = true;
        _clickCount = 0;
    }

    private void FixedUpdate()
    {
        if (_mouseDown)
            _screenPosition = Input.mousePosition;

            Ray ray = Camera.main.ScreenPointToRay(_screenPosition);

            if (Physics.Raycast(ray, out RaycastHit hitData, Mathf.Infinity, _layerToHit))
            {
                _worldPosition = hitData.point;
            }

            transform.position = _worldPosition;
    }

    private void OnMouseDown()
    {
        _clickCount++;
        if (_clickCount < 2)
            _mouseDown = false;
        else
        {
            _mouseDown = true;
            _clickCount = 0;
        }
    }
}
