using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public Transform[] Pos;
    public GameObject[] prefab;

    AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
        StartCoroutine(WaitAndSpawn()); //코루틴 사용
    }

    IEnumerator WaitAndSpawn()
    {
        while (true)
        {
            float waitTime = Random.Range(3.0f, 6.0f);
            yield return new WaitForSeconds(waitTime);

            for(int i = 0; i < Random.Range(1,3); i++)
            {
                int iPrefab = Random.Range(0, prefab.Length);
                int iPos = Random.Range(0, Pos.Length);

                GameObject meteo = Instantiate(prefab[iPrefab], Pos[iPos].position, Quaternion.identity);
                Destroy(meteo, 30f);

                Rigidbody rb = meteo.GetComponent<Rigidbody>();
                rb.AddForce(Vector3.down * Random.Range(5.0f, 10.0f), ForceMode.VelocityChange);
            }
            audio.Play();
        } 
    }

    void Update()
    {
        
    }
}
