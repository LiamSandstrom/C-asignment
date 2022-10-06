using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiTurntime : MonoBehaviour
{
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
        time = turnManager.time;
        maxtime = turnManager.turntime;
        slider.maxValue = maxtime;
        slider.value = time;

    }
}
