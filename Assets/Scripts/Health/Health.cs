using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField]private float startingHealth;
    public float currentHealth {  get; private set; }

    private void awake()
    {
        currentHealth = startingHealth;
    }

    public void takeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);

        if(currentHealth > 0) 
        { 
        
        }

        else
        {

        }
        
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            takeDamage(1);
        }
    }
}
