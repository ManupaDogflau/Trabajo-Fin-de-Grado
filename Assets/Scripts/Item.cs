using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private ItemScriptable _item;

    public ItemScriptable GetItemData()
    {
        return _item;
    }
}
