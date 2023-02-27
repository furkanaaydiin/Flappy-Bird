using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesController : MonoBehaviour
{
    public float speed;
    public float LifeTime;
    void Update()
    {
        transform.position += Vector3.left * (speed * Time.deltaTime);
        Destroy(gameObject , LifeTime);
    }
}
