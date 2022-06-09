using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed = 0.5f;
    [SerializeField] float JumpSpeed = 10;
    [SerializeField] GameObject ObjectToDestroy;
    int Miror = 180;

    void Update()
    {

        transform.Rotate(0f, 0f, 0f);

        float Movement = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        float Vert = Input.GetAxis("Vertical") * JumpSpeed * Time.deltaTime;

        transform.Translate(Movement, Vert, 0);

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        transform.SetPositionAndRotation(new Vector3(-7.92f, 2.33f, 0), Quaternion.Euler(0,0,0));
    }
}
