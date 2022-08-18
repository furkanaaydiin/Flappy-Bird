using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes_Contollers : MonoBehaviour
{
    public float speed;

    public float LifeTime;



    void Start()
    {
        
    }

    
    void Update()
    {
        transform.position += Vector3.left * speed *Time.deltaTime;
        Destroy(gameObject , LifeTime);
    }
}
