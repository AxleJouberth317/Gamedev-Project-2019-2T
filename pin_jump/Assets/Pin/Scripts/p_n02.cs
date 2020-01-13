using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p_n02 : MonoBehaviour
{
    public int recover = 1;
    public float speed = 5;

    public GameObject efecto;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //camara_fx.SetTrigger("shake");
            Instantiate(efecto, transform.position, Quaternion.identity);

            other.GetComponent<pin_n01>().health += recover;
            Debug.Log(other.GetComponent<pin_n01>().health);
            Destroy(gameObject);
        }

    }
}
