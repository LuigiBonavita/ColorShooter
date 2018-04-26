using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour {

    public delegate void Killable(EnemyMovement Enemy);
    public static Killable Killed;
}
