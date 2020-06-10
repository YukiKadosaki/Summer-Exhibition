using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MoveForDestination : MonoBehaviour
{
    public Vector3 destination;
    public float moveTime;
    private Rigidbody rb;
    private Vector3 initpos;
    private Vector3 previousPos;
    private Vector3 speed;
    private Vector3 position = Vector3.zero;
    private float time = 0;
    private int front = 1;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        initpos = transform.position;
        previousPos = transform.position;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        TryGoToDestination();
    }


    private void TryGoToDestination()
    {
        CanGoToDestination();
        GoToDestination();
    }

    private void CanGoToDestination()
    {
        if(time >= moveTime)
        {
            //目的地にたどり着いたとき
            if (front == 1)
            {
                //ずれを修正
                this.transform.position = initpos + destination;
                time = 0;
                front = -1;
            }
            //スタート地点に戻ってきたとき
            else
            {
                //ずれを修正
                this.transform.position = initpos;
                time = 0;
                front = 1;
            }
        }
        position += front * (destination / moveTime) * Time.deltaTime;
        time += Time.deltaTime;
    }

    private void GoToDestination()
    {
        previousPos = this.transform.position;
        rb.MovePosition(initpos + position);
    }

    public Vector3 Speed()
    {
        return this.transform.position - previousPos;
    }
}
