using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseBall : MonoBehaviour
{
    public GameObject ball;
    public GameObject NPC;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        NPC.transform.position = Vector3.MoveTowards(NPC.transform.position, ball.transform.position, speed);
    }
}
