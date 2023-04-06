using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UseData : MonoBehaviour
{/**
  * Tutorial link
  * https://github.com/tikonen/blog/tree/master/csvreader
  * */

    List<Dictionary<string, object>> data; 
    public GameObject myCube;//prefab
    int rowCount; //variable 

    private float startDelay = 2.0f;
    private float timeInterval = 1.0f;
    public object tempObj;
    public float tempFloat;

    void Awake()
    {

        data = CSVReader.Read("TestCO2");//udata is the name of the csv file 

        for (var i = 0; i < data.Count; i++)
        {
            //name, age, speed, description, is the headers of the database
            print("xco2 " + data[i]["xco2"] + " ");

        }
        rowCount = 0;

    }//end Awake()

    // Use this for initialization
    void Start()
    {

        InvokeRepeating("SpawnObject", startDelay, timeInterval);

    }//end Start()


    void SpawnObject() {
        tempObj = data[rowCount]["xco2"];
        tempFloat = System.Convert.ToSingle(tempObj);
        tempFloat = (tempFloat - 350.0f) * 5.0f;
        rowCount++;

        transform.localScale = new Vector3(tempFloat, tempFloat, tempFloat);
        
        Debug.Log("tempFloat " + tempFloat);
            Debug.Log("Count " + rowCount);
        }


    // Update is called once per frame
    void Update()
    {        
        //for (var i = 0; i < data.Count; i++)
        //{
          //  object age = data[i]["xco2"];//get age data
            //gameObject.transform.localScale.z = newVector3((xco2, xco2, xco2));
        //As long as cube count is not zero, instantiate prefab
        //while (cubeCount > 0)
       // {
           // Instantiate(myCube);
           // cubeCount--;
           // Debug.Log("cubeCount" +cubeCount);
        //}
        

    }//end Update()
}