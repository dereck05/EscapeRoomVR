using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class View : MonoBehaviour{

    public float sensitivity = 125.0f;

    private float verticalRotation = 0.0f;
    private float horizontalRotation = 0.0f;

    void Start(){}


    void Update(){
        verticalRotation = -Input.GetAxis("Mouse Y") * sensitivity;
        horizontalRotation = Input.GetAxis("Mouse X") * sensitivity;
    }

    void FixedUpdate(){
        transform.Rotate(new Vector3(0, horizontalRotation * Time.deltaTime, 0));
        transform.GetChild(0).transform.Rotate(new Vector3(verticalRotation * Time.deltaTime, 0, 0));
    }

}
