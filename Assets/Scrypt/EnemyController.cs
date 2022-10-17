using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public Transform[] waypoints; 

    [SerializeField] private float moveSpeed;
    int curWayPointIndex = 0;

    void Start()
    {

    }

    private void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, waypoints[curWayPointIndex].position, Time.deltaTime * moveSpeed);
        if (Vector3.Distance(transform.position, waypoints[curWayPointIndex].position) < 0.1f)
        {
            Destroy(gameObject);
        }
    }
}