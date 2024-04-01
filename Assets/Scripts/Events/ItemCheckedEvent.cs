using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Events/ItemCheckedEvent", fileName = "ItemCheckedEvent")]
public class ItemCheckedEvent : GameEventScriptable
{
    public int element;
}
