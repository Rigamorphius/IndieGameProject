using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryObject : InteractiveObject
{

    [SerializeField]
    private string objectName = nameof(InventoryObject);
    private new Renderer[] renderers;
    private new Collider collider;

    public string ObjectName => objectName;

    private void Start()
    {
        renderers = GetComponentsInChildren<Renderer>();
        collider = GetComponent<Collider>();
    }

    public InventoryObject() {
        displayText = $"Take {objectName}";
    }

    public override void InteractWith()
    {
        base.InteractWith();
        PlayerInventory.InventoryObjects.Add(this);
        for (int i = 0; i < renderers.Length; i++)
        {
            renderers[i].enabled = false;
        }   
        collider.enabled = false;
    }
}
