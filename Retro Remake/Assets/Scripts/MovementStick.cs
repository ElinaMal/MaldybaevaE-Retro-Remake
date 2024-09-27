using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementStick : MonoBehaviour
{
    public float speed = 3f;

    private Animator _animation;
    private Rigidbody2D _rb2D;

    // Start is called before the first frame update
    void Start()
    {
        _animation = GetComponent<Animator>();
        _rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            _rb2D.AddForce(new Vector2(-1, 0) * speed);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            _rb2D.AddForce(new Vector2(1, 0) * speed);
        }

        _animation.SetFloat("XSpeedAbs", Mathf.Abs(_rb2D.velocity.x));
    }
}
