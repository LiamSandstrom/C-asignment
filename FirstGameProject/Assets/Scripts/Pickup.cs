using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    CharacterWeapon characterWeapon;
    Firewithtrejectory firewithtrejectory;

    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.TryGetComponent<Firewithtrejectory>(out Firewithtrejectory firewithtrejectory))
        {
            firewithtrejectory = collider.gameObject.GetComponent<Firewithtrejectory>();
            firewithtrejectory.addammo();
            Destroy(gameObject);
        }   
    }
}
