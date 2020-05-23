using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForDestination : MonoBehaviour
{
    public Vector3 destination;
    public float moveTime;
    private Vector3 initpos;
    private float time = 0;
    private int front = 1;


    // Start is called before the first frame update
    void Start()
    {
        initpos = transform.position;
    }

    // Update is called once per frame
    void Update()
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
        time += Time.deltaTime;
    }

    private void GoToDestination()
    {
        this.transform.position += front * (destination / moveTime) * Time.deltaTime;
    }
}
