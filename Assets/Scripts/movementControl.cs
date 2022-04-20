using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementControl : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5.0f;
    public float spacing = 200.0f;
    float time;
    Vector3 pos;
    Rigidbody myRigid;
    Animator anim;

    public float x, y;

    void Start()
    {
        anim = GetComponent<Animator>();

        pos = transform.position;
        myRigid = GetComponent<Rigidbody>();
        time = Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");

        transform.Rotate(0, x * time * spacing, 0);
        transform.Translate(0, 0, y * time * speed);
        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);
        if (Input.GetButtonDown("Jump"))
        {
            anim.SetTrigger("isJump");
            Debug.Log("jump");
        }
    }
}
