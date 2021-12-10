using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {
   
   //gir health og muligheten til å endre det fra unity direkte og lyd nå:)
    [SerializeField] private AudioSource _death;
    public float health = 50f;

    public void TakeDamage (float amount)
    {
        //hvis tingen med dette sciptet sitt health blir tatt til 0 eller mer så skal den "die" og die betyr da at den fjerner objectet fra spillet
        health -= amount;
        if (health <= 0f)
        {
            StartCoroutine(Die());
        }
    }

    IEnumerator Die()
    {
        deathsound();

        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }

    void deathsound ()
    {
        _death.PlayOneShot(_death.clip);
    }
    
}