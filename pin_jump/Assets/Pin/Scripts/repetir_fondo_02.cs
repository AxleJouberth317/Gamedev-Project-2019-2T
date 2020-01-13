using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repetir_fondo_02 : MonoBehaviour
{
    public float speed_y;

    public float ini_y;
    public float fin_y;
    private float dis_y;


    private float longitud;

    // Start is called before the first frame update
    void Start()
    {
        dis_y = ini_y - fin_y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * speed_y * Time.deltaTime);

        if (transform.position.y <= fin_y)
        {
            Vector2 pos = new Vector2(transform.position.x, transform.position.y + dis_y);
            transform.position = pos;
        }
    }
}
