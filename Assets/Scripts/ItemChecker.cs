using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemChecker : MonoBehaviour
{
    [SerializeField] private ItemScriptable _item;
    private ItemCheckedEvent _event;
    [SerializeField] private int _eventNumber;

    public void Start()
    {
        _event = Resources.Load<ItemCheckedEvent>("ItemCheckedEvent");
    }
    public void Check()
    {
        ItemScriptable item;
        if (transform.childCount == 0) return;
        if (!transform.GetChild(0)) return;
        item = transform.GetChild(0).gameObject.GetComponent<Item>().GetItemData();
        if (!item) return;
        if (_item == item)
        {
            transform.GetChild(0).gameObject.SetActive(false);
            transform.GetChild(0).SetParent(GameObject.FindWithTag("DiscardedItems").transform);
            _event.element = _eventNumber;
            _event.Fire();
        }
    }
}
