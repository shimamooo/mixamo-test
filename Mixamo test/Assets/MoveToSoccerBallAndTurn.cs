using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToSoccerBallAndTurn : MonoBehaviour
{
    [SerializeField] private GameObject target;
    [SerializeField] private float speed = 15;

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * step);
    }
}
