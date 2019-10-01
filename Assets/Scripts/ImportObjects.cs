using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImportObjects : MonoBehaviour
{
    public List<Records> Records = new List<Records>();
    private Vector3 offset;
    public Transform objectPos;
    public GameObject redCube;
    public GameObject greenSphere;
    public GameObject greenCube;
    // Start is called before the first frame update
    void Start()
    {
        TextAsset querydata = Resources.Load<TextAsset>("ObjectsProperties");
        string[] data = querydata.text.Split('\n');
        Debug.Log(data.Length);
        for (int i=1; i<data.Length; i++)
        {
            string[] column = data[i].Split(',');
           // if (column[i] != "")
            {
                Records R = new Records();
                int.TryParse(column[0], out R.ID);
                R.NameOfObject = column[1];
                float.TryParse(column[2], out R.X);
                float.TryParse(column[3], out R.Y);
                float.TryParse(column[4], out R.Z);
                R.Color = column[5];
                Records.Add(R);
            }
        }
        foreach (Records R in Records)
        { 
            if (R.NameOfObject == "Cube" && !Equals(R.Color, "Red"))
            {
                Debug.Log("GreenC");
                this.transform.position = new Vector3(R.X, R.Y, R.Z);
                Instantiate(greenCube, this.transform.position, objectPos.rotation);
            }
            if (Equals(R.NameOfObject, "Sphere"))
            {
                Debug.Log("GreenSp");
                this.transform.position = new Vector3(R.X, R.Y, R.Z);
                Instantiate(greenSphere, this.transform.position, objectPos.rotation);
                //Debug.Log(R.NameOfObject);
            }
            
            if (Equals(R.Color, "Red"))
            {
                Debug.Log("RedC");
                this.transform.position = new Vector3(R.X, R.Y, R.Z);
                Instantiate(redCube, this.transform.position, objectPos.rotation);
                
            }
            this.transform.position = new Vector3(R.X, R.Y, R.Z);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
