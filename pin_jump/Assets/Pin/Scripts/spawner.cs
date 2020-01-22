using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject[] obstaculos_patron;

    private float tiempo_spawn;

    //public float tiempo_start = 1.25f;
    //public float tiempo_decrease = 0.05f;
    //public float tiempo_minimo = 0.65f;

    public float tiempo_start = 1f;
    public float tiempo_decrease = 0.00f;
    public float tiempo_minimo = 1f;

    public int nivel = 0;

    private int contador = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (tiempo_spawn <= 0)
        {
            int rand;
            contador++;

            if(contador == 1)
            {
                if(nivel == 2)
                {
                    rand = 1;
                }
                else
                {
                    rand = 1;
                }
            }
            else if(contador == 2)
            {
                if (nivel == 2)
                {
                    rand = Random.Range(0, 2);
                    Debug.Log("r" + rand);
                }
                else
                {
                    rand = 1;
                }
            }
            else if (contador == 3)
            {
                if (nivel == 2)
                {
                    rand = Random.Range(0, 2);
                    Debug.Log("r" + rand);
                }
                else
                {
                    rand = 1;
                }
            }
            else if (contador == 4)
            {
                if (nivel == 2)
                {
                    rand = Random.Range(0, obstaculos_patron.Length);
                    Debug.Log("r" + rand);
                }
                else
                {
                    rand = Random.Range(32, 35);
                    Debug.Log("r" + rand);
                }
            }
            else
            {
                if (nivel == 2)
                {
                    rand = Random.Range(0, obstaculos_patron.Length);
                    Debug.Log("r" + rand);
                }
                else
                {
                    //rand = Random.Range(2, obstaculos_patron.Length-4);
                    rand = Random.Range(2, 31);
                    Debug.Log("r" + rand);
                }
            }
            Instantiate(obstaculos_patron[rand], transform.position, Quaternion.identity);
            tiempo_spawn = tiempo_start;
            if (tiempo_start > tiempo_minimo)
            {
                tiempo_start -= tiempo_decrease;
            }
        }
        else
        {
            tiempo_spawn -= Time.deltaTime;
        }
    }
}
