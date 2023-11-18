using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SG 
{
    public class Item : ScriptableObject
    {
    // Start is called before the first frame update
    [Header("Item Informatio")]
    public string itemName;
    public Sprite itemIcon;
    [TextArea] public string itemDescription;
    public int itemID;
    }
}