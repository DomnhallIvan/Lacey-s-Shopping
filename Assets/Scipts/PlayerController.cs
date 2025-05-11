using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]private float speed;

    private Animator animator;
   

    private void Start()
    {
       animator = GetComponent<Animator>();
    }

    //ChangesAnim depending of the Vector2dir for Direction and to set it if it's moving.
    private void Update()
    {
        Vector2 dir = Vector2.zero;
        if (Input.GetKey(KeyCode.A))
        {
            dir.x = -1;
            animator.SetInteger("MoveDirection", 3);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            dir.x = 1;
            animator.SetInteger("MoveDirection", 2);
        }

        if (Input.GetKey(KeyCode.W))
        {
            dir.y = 1;
            animator.SetInteger("MoveDirection", 1);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            dir.y = -1;
            animator.SetInteger("MoveDirection", 0);
        }

        dir.Normalize();
        animator.SetBool("isMoving", dir.magnitude > 0);

        GetComponent<Rigidbody2D>().velocity = speed * dir;
    }

    //Reference for ChestShopper
    public float GetSpeed(float newSpeed)
    {
        speed= newSpeed;
        return speed;
    }
}
