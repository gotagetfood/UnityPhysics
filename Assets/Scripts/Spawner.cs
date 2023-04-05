using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objectToSpawn;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.V)) { 
            Instantiate(objectToSpawn);
        
        }
        
    }
}
