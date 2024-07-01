using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject camera;
    public GameObject prefab;
    public GameObject prefab2;
    private int Hitcnt = 0;
    private int BigMeteoHP;

    AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
         BigMeteoHP = Random.Range(10, 20);
    }

    public void Fire()
    {
        RaycastHit hit;
        if (Physics.Raycast(camera.transform.position, camera.transform.forward, out hit));
        {
            if (hit.transform.tag == "Meteo")
            {
                Destroy(hit.transform.gameObject); 
                Instantiate(prefab, hit.point, Quaternion.LookRotation(hit.normal));
                GameManager.instance.AddScore(5);
                audio.Play();
            }
        }
        if (Physics.Raycast(camera.transform.position, camera.transform.forward, out hit)) ;
        {
            if (hit.transform.tag == "BigMeteo")
            {
                if(Hitcnt == BigMeteoHP)
                {
                    Destroy(hit.transform.gameObject);
                    GameManager.instance.AddScore(50);
                    Instantiate(prefab, hit.point, Quaternion.LookRotation(hit.normal));
                    Hitcnt = 0;
                }
                Hitcnt++;
                Instantiate(prefab2, hit.point, Quaternion.LookRotation(hit.normal));
                audio.Play();
            }
        }
    }

    void Update()
    {
        
    }
}
