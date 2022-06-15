using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamera : MonoBehaviour
{ 
    public GameObject skelett;

    // Start is called before the first frame update
    void Start()
    {
        skelett = GameObject.Find("Camera");
    }

    // Update is called once per frame
    void Update()
    { 
        transform.position = new Vector3(skelett.transform.position.x -0.3f, skelett.transform.position.y -2f, skelett.transform.position.z);  
    }
}
