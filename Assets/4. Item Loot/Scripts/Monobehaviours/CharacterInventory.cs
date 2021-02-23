using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterInventory : MonoBehaviour
{
    #region Variable Declarations
    public static CharacterInventory instance;
    #endregion

    #region Initializations
    void Start()
    {
        instance = this;
    }
    #endregion

    public class InventoryDisplaySlots
    {
        public Sprite sprite;
    }

    public InventoryDisplaySlots[] inventoryDisplaySlots;

    public void StoreItem(ItemPickUp itemToStore)
    {

    }
}