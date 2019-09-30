using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class UserInputHandling : MonoBehaviour
{
    private bool isKeyPressed = false;
    private string S2;
    public TextMesh affectedObject;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown && !isKeyPressed)
        {
            isKeyPressed = true;
            Debug.Log("A Key Is Pressed");
            Debug.Log(System.DateTime.Now.Date);
            Debug.Log(System.DateTime.Now);

            S2 = System.Convert.ToString(System.DateTime.Now.TimeOfDay);
            char[] chars = S2.ToCharArray();

            for (int i=8; i<16; i++)
            {
                chars[i] = ' ';
            }
            string str = new string(chars);
            affectedObject.text = str;
        }
    }
}
