using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UiMovementtime : MonoBehaviour
{
    // Start is called before the first frame update
    public CharacterController characterController;
    public CharacterController characterController2;
    public TurnManager turnManager;
    private float time;
    private float maxtime;
    private float valuetime;
    public Slider slider;
    void Start()
    {
        
    }

    
    void Update()
    {
        
        

            if(turnManager.IsItPlayerTurn(1))
        {
            time = characterController.Movetimer;
            maxtime = characterController.turntime;
            slider.maxValue = maxtime;
            slider.value = time;
        }
        else if(turnManager.IsItPlayerTurn(2))
        {
            time = characterController2.Movetimer;
            maxtime = characterController2.turntime;
            slider.maxValue = maxtime;
            slider.value = time;
        }

    }
}
