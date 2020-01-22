using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class pin_n01 : MonoBehaviour
{
    private Vector2 target_pos;

    public float y_increment = 3;
    public float speed = 100;

    public float max_h = 3;
    public float min_h = -3;

    public int health = 3;

    public GameObject efecto;

    public Text txt_salud;

    public GameObject go_txt;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            health = 0;
        }

        txt_salud.text = health.ToString();

        if (health <= 0)
        {
            if (transform.position.x == 0)
            {
                Debug.Log("valor 0");
                Instantiate(efecto, transform.position, Quaternion.identity);
                go_txt.SetActive(true);
                Destroy(gameObject);
            }
        }
        else
        {

            transform.position = Vector2.MoveTowards(transform.position, target_pos, speed * Time.deltaTime);

            if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < max_h)
            {
                target_pos = new Vector2(transform.position.x, transform.position.y + y_increment);
                //transform.position = target_pos;
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > min_h)
            {
                target_pos = new Vector2(transform.position.x, transform.position.y - y_increment);
                //transform.position = target_pos;
            }
        }
    }
}
