using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    [SerializeField] private Transform destination;
    public Firewithtrejectory firewithtrejectory;
    public Firewithtrejectory firewithtrejectory2;
    public TurnManager turnManager;
    private float Value;


    void Update()
    {

    }

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {

            if(turnManager.IsItPlayerTurn(1))
            {
                Value = firewithtrejectory.ammo;
                if(Value>= 1)
                {
                    collider.gameObject.transform.position = destination.position;
                    firewithtrejectory.ammo -= 1;
                }
            
            }
            else if(turnManager.IsItPlayerTurn(2))
            {
                Value = firewithtrejectory2.ammo;
                if(Value>= 1)
                {
                    firewithtrejectory2.ammo -= 1;
                    collider.gameObject.transform.position = destination.position;
                }
            }
            
            

        }
        
    }

}
