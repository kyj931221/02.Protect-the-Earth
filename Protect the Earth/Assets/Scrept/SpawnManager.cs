using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public Transform[] Pos;
    public GameObject[] prefab;
    public GameObject[] prefab2;

    AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
        StartCoroutine(WaitAndSpawn()); //코루틴 사용
        StartCoroutine(WaitAndSpawn2());
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
    
    IEnumerator WaitAndSpawn2() //큰 운석
    {
        while(true)
        {
            float waitTime2 = Random.Range(20.0f, 25.0f);
            yield return new WaitForSeconds(waitTime2);

            for (int i = 0; i < 1; i++)
            {
                int iPrefab2 = Random.Range(0, prefab2.Length);
                int iPos = Random.Range(0, Pos.Length);

                GameObject bigmeteo = Instantiate(prefab2[iPrefab2], Pos[iPos].position, Quaternion.identity);
                Destroy(bigmeteo, 30f);

                Rigidbody rb2 = bigmeteo.GetComponent<Rigidbody>();
                rb2.AddForce(Vector3.down * Random.Range(2.0f, 5.0f), ForceMode.VelocityChange);
            }
            audio.Play();
        }
    }
    

    void Update()
    {
        
    }
}
