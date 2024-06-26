using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Damage : MonoBehaviour
{
    private bool isDead = false;
    public Slider multipleHpBar;

    private float multipleHp = 100f;
    private float multipleCurHp = 100f;
    void Start()
    {
        multipleHpBar.value = multipleCurHp / multipleHp;
    }

    
    void Update()
    {
        
    }

    private void Die()
    {
        isDead = true;

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Meteo" && !isDead)
        {
            multipleCurHp = multipleCurHp - 10f;
            HandleHp();
        }
    }

    private void HandleHp()
    {
        multipleHpBar.value = multipleCurHp / multipleHp;
        if( multipleHpBar.value == 0 )
        {
            GameManager.instance.OnPlayerDead(0);
        }
    }
}
