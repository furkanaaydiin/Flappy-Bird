using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject pipeSpawn;
    public float maxY;
    public float minY;
    public float x;
    
    public float interval;

    private void Start()
    {
        InvokeRepeating("Spawner" , interval , interval);
    }

  private  void Spawner()
    {
        GameObject istance = Instantiate(pipeSpawn);
        istance.transform.position = new Vector2(x,Random.Range(minY,maxY));
        istance.transform.SetParent(transform); 
    }

    
}
