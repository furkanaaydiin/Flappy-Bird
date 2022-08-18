using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Controller : MonoBehaviour
{
    public GameObject pipeSpawn;
    public float maxY;
    public float minY;

    public float x;
    
    public float interval;


    
    private void Start()
    {
        InvokeRepeating("spawner" , interval , interval);
    }

  private  void spawner()
    {
        GameObject istance = Instantiate(pipeSpawn);
        istance.transform.position = new Vector2(x,Random.Range(minY,maxY));
        istance.transform.SetParent(transform); 
    }

    
}
