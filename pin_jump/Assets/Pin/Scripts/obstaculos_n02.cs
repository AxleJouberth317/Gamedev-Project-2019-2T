using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class obstaculos_n02 : MonoBehaviour
{
    public int damage = 1;
    public float speed = 5;

    public GameObject efecto;

    //private GameObject pin_ui;
    //private Text pin_valor;

    // Start is called before the first frame update
    void Start()
    {
        //txt_valor = GameObject.Find("pin_valor");

        //pin_ui = GameObject.Find("pin_ui");

        
        //pin_valor = GameObject.FindGameObjectWithTag("pin_valor").GetComponent<Text>();
        //pin_valor.text = gameObject.GetComponent<Text>().text;

        //pin_valor = GameObject.FindGameObjectWithTag("pin_valor").GetComponent<Text>();
        //pin_valor.text = gameObject.GetComponent<Text>().text;
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
            //pin_valor.text = "-1";
            //StartCoroutine("ColisionRetroalimentacion");

            //Debug.Log(other.GetComponent<pin_n02>().health);
            Destroy(gameObject);
        }

    }

    /*
    IEnumerator ColisionRetroalimentacion()
    {
        pin_ui.SetActive(true);
        yield return new WaitForSeconds(1f);
        pin_ui.SetActive(false);
    }
    */
}
