using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float playerSpeed = 10.0f;
    public float playerRotationSpeed = 100.0f;
    [SerializeField]
    private Rigidbody PlayerRigidbody;
    float neuePosition;

    void Start()
    {

    }


    void Update()
    {
        
        float translation = Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime;
        float rotation = Input.GetAxis("Horizontal") * playerRotationSpeed * Time.deltaTime;


        transform.Translate(0, 0, translation);

        transform.Rotate(0, rotation, 0);


    
        

        if (Input.GetKey(KeyCode.Space))
        {
            new Vector3(transform.position.x, transform.position.y + 3.0f, transform.position.z);
        }
        

        
    }


    void FixedUpdate()
    {
        var myFigur = GameObject.FindGameObjectWithTag("Respawn");
        var targetVector = new Quaternion(0f, 0f, 0f, 180f);
        var currentVector = Quaternion.Normalize(transform.rotation);
        var step = 0.001f;

        float translation = Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime;
        float rotation = Input.GetAxis("Horizontal") * playerRotationSpeed * Time.deltaTime;
        
        if(currentVector.x > targetVector.x)
        {
            myFigur.transform.rotation = new Quaternion(myFigur.transform.rotation.x + step, 0f, 0f, 180f);
        }
        else if (currentVector.x < targetVector.x)
        {
            myFigur.transform.rotation = new Quaternion(myFigur.transform.rotation.x - step, 0f, 0f, 180f);
        }
     

        
        


        transform.Translate(0, 0, translation);

        transform.Rotate(0, rotation, 0);


    }
}