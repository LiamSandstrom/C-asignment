using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntegerToText : MonoBehaviour
{
    int Value = 10;
    public Text ValueText;
    public Firewithtrejectory firewithtrejectory;
    public Firewithtrejectory firewithtrejectory2;
    public TurnManager turnManager;
    public int index;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(turnManager.IsItPlayerTurn(1))
        {
            Value = firewithtrejectory.ammo;
            ValueText.text = Value.ToString();
        }
        else if(turnManager.IsItPlayerTurn(2))
        {
            Value = firewithtrejectory2.ammo;
            ValueText.text = Value.ToString();
        }
        

    }
}
