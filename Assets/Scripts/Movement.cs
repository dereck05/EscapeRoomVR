using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour{

    public float velocity = 0.2f;

    private float verticalDisplacement = 0.0f;
    private float HorizontalDisplacement = 0.0f;

    void Start(){}

    void Update(){
        verticalDisplacement = Input.GetAxis("Vertical") * velocity;
        HorizontalDisplacement = Input.GetAxis("Horizontal") * velocity;
    }

    void FixedUpdate(){
        move();
    }

    private void move(){
        Vector3 direction = (Vector3.forward * verticalDisplacement) + (Vector3.right * HorizontalDisplacement);
        transform.position += transform.rotation * direction;
    }
}
