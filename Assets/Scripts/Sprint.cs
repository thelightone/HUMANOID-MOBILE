using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Sprint : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField]
    private UnityEvent _onMouseDown;
    [SerializeField]
    private UnityEvent _onMouseUp;

    public void OnPointerDown(PointerEventData eventData)
    {
        _onMouseDown.Invoke();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        _onMouseUp.Invoke();
    }
}
