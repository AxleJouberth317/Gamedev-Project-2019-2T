using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class Controls : MonoBehaviour
{


    public float tapForce = 10;
    public float smooth = 5;
    public Vector3 startPosition;
    Rigidbody2D rigidbody;
    Quaternion down;
    Quaternion up;


    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        down = Quaternion.Euler(0, 0, 0);
        up = Quaternion.Euler(0, 0, 10);
        //rigidbody.simulated = false;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            transform.rotation = up;
            rigidbody.AddForce(Vector2.up * tapForce, ForceMode2D.Force);
        }
        transform.rotation = Quaternion.Lerp(transform.rotation, down, smooth * Time.deltaTime);

    }

    void OnCoinCollected(Collider2D col)
    {
        if (col.gameObject.tag == "Coin")
        {

        }
    }

    void OnDanger(Collider2D col)
    {
        if (col.gameObject.tag == "Danger")
        {
            rigidbody.simulated = false;
        }
    }

}
