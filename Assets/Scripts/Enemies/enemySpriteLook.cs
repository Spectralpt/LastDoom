using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpriteLook : MonoBehaviour
{
    private Transform target;
    private bool canLookVertically;
    
    void Start()
    {
        target = FindObjectOfType<PlayerMovement>().transform;
    }

    void Update()
    {
        if (canLookVertically)
        {
            transform.LookAt(target);
        }
        else
        {
            Vector3 yCompesatedTarget = target.position;
            yCompesatedTarget.y = transform.position.y;
            
            transform.LookAt(yCompesatedTarget);
        }
    }
}
