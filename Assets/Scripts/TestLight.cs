using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestLight : MonoBehaviour
{
    public GameObject light;

    private bool flag;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            if (!flag)
            {
                light.SetActive(true);
                flag = true;
            }
        }

    }

}
