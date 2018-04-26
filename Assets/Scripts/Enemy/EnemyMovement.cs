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
    public bool Moving;
    public Tween movementTween;
    TurnColor backgroundcolor;

    public State currentState = State.Alive;
    public EnemyColor enemyColor;

    public Transform[] SpawnLocation;

    public enum EnemyColor
    {
        red,
        blue,
        yell,
    }

    void Start()
    {
        backgroundcolor = FindObjectOfType<TurnColor>();
        currentState = State.Alive;
        Moving = true;
        transform.position = SpawnLocation[Random.Range(0, SpawnLocation.Length)].position;

    }

    void Update()
    {
        if (Moving == true)
        {
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
        Moving = false;
        if (enemyColor == EnemyColor.red && backgroundcolor.actualColor == "red" ||
            enemyColor == EnemyColor.blue && backgroundcolor.actualColor == "blue" ||
            enemyColor == EnemyColor.yell && backgroundcolor.actualColor == "yellow")
        {
            movementTween = transform.DOMove(new Vector3(0, 1, 0), Random.Range(3, 4)).OnComplete(MovementComplete);
            
        }
        else
        {
            movementTween = transform.DOMove(new Vector3(0, 1, 0), Random.Range(4, 6)).OnComplete(MovementComplete);
        }

    }

    void MovementComplete()
    {
        Moving = true;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("Proiettile"))
        {
            Moving = false;
            movementTween.Kill();
            transform.position = SpawnLocation[Random.Range(0, SpawnLocation.Length)].position;
            Moving = true;

        }
    }
}
