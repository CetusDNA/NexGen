using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementRobot : MonoBehaviour
{
    public float speedMovement = 5.0f;
    public float speedRotation = 250.0f;
    private Animator anim;
    public float x, y;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Translate(0, 0, y * Time.deltaTime * speedMovement);
        transform.Rotate(0, x * Time.deltaTime * speedRotation, 0);

        anim.SetFloat("SpeedX", x);
        anim.SetFloat("SpeedY", y);
    }
}
