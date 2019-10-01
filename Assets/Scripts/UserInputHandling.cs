using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class UserInputHandling : MonoBehaviour
{
    private bool isKeyPressed = false;
    private bool countEnable = true;
    public string outputString;
    private int hourDifference = 0;
    private int minuteDifference = 0;
    private int intSecElapsed;
    public TextMesh affectedObject;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        intSecElapsed = System.Convert.ToInt32(Time.time);
        if (intSecElapsed % 60 == 0 && intSecElapsed != 0)
        {
            while (countEnable)
            {
                minuteDifference++;
                countEnable = false;
            }
        }
        if (intSecElapsed % 60 == 1)
            countEnable = true;
        if (minuteDifference > 59)
        {
            minuteDifference = 0;
            hourDifference++;
        }
        if (hourDifference > 23)
        {
            hourDifference = 0;
        }
        if (Input.anyKeyDown && !isKeyPressed)  
        {
            isKeyPressed = true;
            Debug.Log("A Key Is Pressed");
            Debug.Log(Time.time);
            Debug.Log(intSecElapsed);
            outputString = System.Convert.ToString(hourDifference + ":" + minuteDifference + ":" + intSecElapsed % 60);
            Debug.Log(outputString);
            affectedObject.text = outputString;
        }
    }
}
