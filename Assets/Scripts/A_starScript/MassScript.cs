using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MassScript : MonoBehaviour
{
    private Vector2 adress;
    [SerializeField] private Status status;
    private void Start()
    {
        adress = this.transform.position;
        switch (this.status)
        {
            case Status.StartPosition:
                //
                break;
        }
    }
    public MassScript(Vector2 adress,Status status)
    {

    }
}
public enum Status
{
    NonSpace,
    Wall,
    StartPosition,
    GoalPosition,
    Open,
    Close
}
