using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatchTriggerScript : MonoBehaviour
{

    public Transform pointC;

    private void OnDrawGizmos()
    {
        Vector2 tagetVector = (Vector2)(pointC.position - transform.position);

        Vector2 forward = (Vector2)transform.TransformDirection(Vector3.up) * 2;

        Gizmos.color = Color.green;
        float vectorRelationship = Vector3.Dot(forward, tagetVector);
        Color rayCastColor = Color.green;
        if (vectorRelationship > 0)
        {
            rayCastColor = Color.red;
        }
        print(vectorRelationship);
        RaycastHit2D ray = Physics2D.Raycast(transform.position, forward);
        Debug.DrawRay(transform.position, forward, rayCastColor);
        Gizmos.DrawLine(pointC.position, transform.position);
    }
}
