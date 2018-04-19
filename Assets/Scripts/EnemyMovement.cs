using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class EnemyMovement : MonoBehaviour
{

    public Vector3 StartPoint;
    public Vector3 EndPoint;
    public Vector3 StartPosition;
    public float speed;
    public bool GoToRight;

    public State currentState = State.Alive;

    void Start()
    {
        currentState = State.Alive;
        GoToRight = false;
    }

     void Update()
    {
        if (transform.position.x <= StartPoint.x)
        {
            Move();
        }

        if (transform.position.x >= EndPoint.x)
        {
            MoveAgain();
            GoToRight = true;
        }
        if ( GoToRight == true)
        {
            GoToRight = false;
            Move();
        }
    }

    public enum State
    {
        Alive,
        Death,
    }

    void Move()
    {
        transform.DOMove(new Vector3(0, 0, 0), 3);
    }

    void MoveAgain()
    {
        transform.position = new Vector3(-10, 1, 0);
    }
}
