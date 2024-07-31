using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics;

public class ItemPickup : MonoBehaviour
{

    public int itemID;
    public int _count;
    public string pickUpSound;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                AudioManager.instance.Play(pickUpSound);
                Inventory.instance.GetAnItem(itemID, _count);
                Destroy(this.gameObject);
            }
        }
    }
}
