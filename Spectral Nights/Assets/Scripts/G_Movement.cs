using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class G_Movement : MonoBehaviour
{
    [SerializeField]
    float M_Speed = 5.0f;

    [SerializeField]
    Rigidbody2D Rb;

    [SerializeField]
    Animator Anim;

    [SerializeField]
    GameObject Sensor;

    Vector2 Move;

    // Update is called once per frame
    void Update()
    {
        Move.x = Input.GetAxisRaw("Horizontal");
        Move.y = Input.GetAxisRaw("Vertical");

        if (Move.x != 0 || Move.y != 0)
        {
            Anim.SetFloat("Horizontal", Move.x);
            Anim.SetFloat("Vertical", Move.y);
            Anim.SetFloat("Speed", Move.sqrMagnitude);

            Sensor.transform.position = new Vector2(gameObject.transform.position.x + Move.x, gameObject.transform.position.y + Move.y);
        }
    }

    private void FixedUpdate()
    {
        Rb.MovePosition(Rb.position + Move.normalized * M_Speed * Time.fixedDeltaTime);
    }
}
