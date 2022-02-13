using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadialTriggerScript : MonoBehaviour
{
    public Transform pointB;

    private float rad = 2;

    private void OnDrawGizmos()
    {
        Color tempColor = Color.red;

        float distance = Vector2.Distance(transform.position, pointB.position);

        if (distance < rad)
        {
            tempColor = Color.gray;
        }

        tempColor.a = 0.42f;
        Gizmos.color = tempColor;
        Gizmos.DrawSphere(transform.position, rad);
    }
}
