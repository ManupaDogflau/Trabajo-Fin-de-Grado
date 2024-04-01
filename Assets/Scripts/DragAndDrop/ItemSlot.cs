using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour, IDropHandler
{

    private RectTransform _rectTransform;
    private ItemMovedEvent _event;

    public void Awake()
    {
        _rectTransform = GetComponent<RectTransform>();
    }

    public void Start()
    {
        _event=Resources.Load<ItemMovedEvent>("ItemMovedEvent");
        
    }

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null && transform.childCount==0)
        {
            eventData.pointerDrag.transform.SetParent(this._rectTransform);
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = Vector3.zero;
            _event.Fire();
        }
    }

}
