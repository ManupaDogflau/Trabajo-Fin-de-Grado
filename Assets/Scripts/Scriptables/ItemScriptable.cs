using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptables/Item", fileName ="Item")]
public class ItemScriptable : ScriptableObject
{
    public int id;
    public string itemName;
    public string description;
}
