using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisable : MonoBehaviour
{
    private bool isKeyPressed = false;
    public GameObject objectToEnable;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown && !isKeyPressed)
        {
            isKeyPressed = true;
            objectToEnable.SetActive(true);
        }
        
        if (Input.GetKeyDown(KeyCode.Escape) && isKeyPressed)
        {
            Application.Quit();
        }
    }
}
