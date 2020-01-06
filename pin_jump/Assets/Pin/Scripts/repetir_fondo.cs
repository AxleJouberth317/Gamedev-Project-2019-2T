using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repetir_fondo : MonoBehaviour
{
    public float speed;

    public float ini_x;
    public float fin_x;
    private float dis_x;


    private float longitud;

    // Start is called before the first frame update
    void Start()
    {
        dis_x = ini_x - fin_x;
        //longitud = GetComponent<SpriteRenderer>().bounds.size.x;


    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (transform.position.x <= fin_x)
        {
            Vector2 pos = new Vector2(transform.position.x + dis_x, transform.position.y);
            transform.position = pos;
        }
    }
}
