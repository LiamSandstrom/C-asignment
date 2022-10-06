using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waterkill : MonoBehaviour
{
    public Playerwin playerwin;
    public int index;

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.CompareTag("Water"))
        {
            if(index == 1)
            {
                playerwin.player1 = true;
                Destroy(gameObject);
            }
                if(index == 2)
            {
                playerwin.player2 = true;
                Destroy(gameObject);
            }
           
        }
    }
}
