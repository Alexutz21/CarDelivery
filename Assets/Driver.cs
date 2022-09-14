using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = -0.05f;
    [SerializeField] float moveSpeed = 15f;
    [SerializeField] float slowSpeed = 5f;
    [SerializeField] float boostSpeed = 25f;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);

    }
    //this is the method if we bump on anything we slow our speed
    void OnCollisionEnter2D(Collision2D other)
    {
        moveSpeed = slowSpeed;
    }
    //this is the method if we bump into SpeedUp we go faster
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Boost")
        {
            moveSpeed = boostSpeed;
        }
    }
}
