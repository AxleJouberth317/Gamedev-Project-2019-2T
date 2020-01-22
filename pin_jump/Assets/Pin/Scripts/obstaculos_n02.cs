using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaculos_n02 : MonoBehaviour
{
    public int damage = 1;
    public float speed = 5;

    public GameObject efecto;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);

        if (transform.position.y <= -7)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //camara_fx.SetTrigger("shake");
            Instantiate(efecto, transform.position, Quaternion.identity);

            other.GetComponent<pin_n02>().health -= damage;
            Debug.Log(other.GetComponent<pin_n02>().health);
            Destroy(gameObject);
        }

    }
}
