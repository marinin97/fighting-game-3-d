using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject BallTemplate;


    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        { 
            SpawnBalls();
        }
    }

    private void SpawnBalls()
    {
        var mousePoint = Input.mousePosition;
        mousePoint.z = 10;
        Vector3 SpawnPosition = Camera.main.ScreenToWorldPoint(mousePoint);
        Instantiate(BallTemplate, SpawnPosition, Quaternion.identity);        
    }
}
