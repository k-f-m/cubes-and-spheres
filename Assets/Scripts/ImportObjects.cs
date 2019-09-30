using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImportObjects : MonoBehaviour
{
    public List<Records> Records = new List<Records>();
    //public GameObject camera;
    //public Transform camPosition;

    private Vector3 offset;
    public Transform ObjectPos;
    public GameObject RedCube;
    public GameObject GreenSphere;
    public GameObject GreenCube;
    // private Vector3 offset;
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
                /*if (R.NameOfObject == "Sphere")
                {
                    new GameObject("Sphere");
                    GameObject newSphere = new GameObject("ColoredSphere");
                    newSphere.AddComponent<Component>();
                }*/
               /* if (R.NameOfObject == "Cube")
                    new GameObject("Cube");*/

                //R.X = row[2];
                float.TryParse(column[2], out R.X);
                float.TryParse(column[3], out R.Y);
                float.TryParse(column[4], out R.Z);
                R.Color = column[5];
                // R.Y = row[3];
                //  R.Z = row[4];

                Records.Add(R);
            }
        }
        /*
        Records RR = new Records();
        for (int i = 1;i<Records.Count; i++)
        {
            if (i < 11)
            {
                this.transform.position = new Vector3(RR.X, RR.Y, RR.Z);
                Instantiate(GreenSphere, this.transform.position, ObjectPos.rotation);
            }
            if (i < 11 && i < 21)
            {
                this.transform.position = new Vector3(RR.X, RR.Y, RR.Z);
                Instantiate(GreenCube, this.transform.position, ObjectPos.rotation);
            }
            if (i == 21)
            {
                this.transform.position = new Vector3(RR.X, RR.Y, RR.Z);
                Instantiate(RedCube, this.transform.position, ObjectPos.rotation);
            }
            // Records.Count
            // if (Equals(Records[i], "Red"))
            // Debug.Log(Records.Contains();

        }*/
        foreach (Records R in Records)
        { /*
            this.transform.position = new Vector3(R.X, R.Y, R.Z);
            Instantiate(GreenCube, this.transform.position, ObjectPos.rotation);*/
            //  Instantiate(RedCube, this.transform.position, ObjectPos.rotation);
           // Debug.Log(R.NameOfObject);
         //   Debug.Log(R.Color);
            if (R.NameOfObject == "Cube" && !Equals(R.Color, "Red"))
            {
                Debug.Log("GreenC");
                this.transform.position = new Vector3(R.X, R.Y, R.Z);
                Instantiate(GreenCube, this.transform.position, ObjectPos.rotation);
            }
            if (Equals(R.NameOfObject, "Sphere"))
            {
                Debug.Log("GreenSp");
                this.transform.position = new Vector3(R.X, R.Y, R.Z);
                Instantiate(GreenSphere, this.transform.position, ObjectPos.rotation);
                //Debug.Log(R.NameOfObject);
            }
            
            if (Equals(R.Color, "Red"))
            {
                Debug.Log("RedC");
                this.transform.position = new Vector3(R.X, R.Y, R.Z);
               // this.transform.localScale = new Vector3(R.X, R.Y, R.Z);
                Instantiate(RedCube, this.transform.position, ObjectPos.rotation);
                
            }
            this.transform.position = new Vector3(R.X, R.Y, R.Z);
            /*
            if (Equals(R.NameOfObject, "Sphere") && Equals(R.Color, "Green"))
            {
                this.transform.position = new Vector3(R.X, R.Y, R.Z);
                Instantiate(GreenSphere, this.transform.position, ObjectPos.rotation);
                Debug.Log(R.NameOfObject);
                Debug.Log(R.X);
                Debug.Log(R.Y);
                Debug.Log(R.Z);
                Debug.Log(R.Color);
            }*/
        }

        
        //  camPosition = camera.GetComponent<Transform>();

        // Debug.Log(camPosition.transform.position.x);

        // offset = transform.position - camera.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
     
        // this.transform.position += new Vector3(-2f, 0f, -2f) * Time.deltaTime;
        // transform.position = camera.transform.position + offset;
        //Debug.Log(transform.position.x = transform.position.x);
        // transform.position.x += transform.position.x;
        // += camPosition.position.x ;
    }

}
