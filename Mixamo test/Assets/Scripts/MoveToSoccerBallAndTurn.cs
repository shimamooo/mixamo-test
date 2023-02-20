using System.Collections;
using System.Collections.Generic;
using UnityEngine.Animations.Rigging;
using UnityEngine;

public class MoveToSoccerBallAndTurn : MonoBehaviour
{
    public float speed;
    public Transform target;
    public Rig animationRigging;

    private void Start()
    {
        transform.LookAt(target);
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        if (transform.position == target.position)
        {
            TurnAround();
        }
    }

    void TurnAround()
    {
        animationRigging.weight = 1;
    }
}
