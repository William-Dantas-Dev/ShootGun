using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenLimits : MonoBehaviour
{
    public      Camera          _mainCamera;
    private     SpriteRenderer  _spriteRenderer;
    private     Vector2         _screenBounds;
    private     float           _objectWidth;
    private     float           _objectHeight;
    private void Start()
    {
        _screenBounds = _mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, _mainCamera.transform.position.z));
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _objectWidth = _spriteRenderer.bounds.extents.x;
        _objectHeight = _spriteRenderer.bounds.extents.y;
    }

    
    private void LateUpdate()
    {
        Vector3 _viewPosition = transform.position;
        _viewPosition.x = Mathf.Clamp(_viewPosition.x, _screenBounds.x * -1 + _objectWidth, _screenBounds.x - _objectWidth);
        _viewPosition.y = Mathf.Clamp(_viewPosition.y, _screenBounds.y * -1 + _objectHeight, _screenBounds.y - _objectHeight);
        transform.position = _viewPosition;
    }
}
