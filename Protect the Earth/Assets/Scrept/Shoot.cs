using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject camera;
    public GameObject prefab;
    private int HP_Count;

    AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
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
                GameManager.instance.AddScore(10);
                audio.Play();
            }
        }
    }

    void Update()
    {
        
    }
}
