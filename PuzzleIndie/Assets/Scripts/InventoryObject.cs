using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryObject : InteractiveObject
{

    [SerializeField]
    private string objectName = nameof(InventoryObject);
    private new Renderer renderer;
    private new Collider collider;

    public string ObjectName => objectName;

    private void Start()
    {
        renderer = GetComponent<Renderer>();
        collider = GetComponent<Collider>();
    }

    public InventoryObject() {
        displayText = $"Take {objectName}";
    }

    public override void InteractWith()
    {
        base.InteractWith();
        PlayerInventory.InventoryObjects.Add(this);

        /* ckrueger audio */
        PlaySoundKeyPickup();

        renderer.enabled = false;
        collider.enabled = false;
    }

    /* ckrueger audio */
    void PlaySoundKeyPickup()
    {
        AkSoundEngine.PostEvent("KeyPickup", gameObject);
    }
}
