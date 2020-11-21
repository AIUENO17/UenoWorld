using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereDamage : MonoBehaviour
{

    private SphereStates m_sphereStates = null;


    private void Awake()
    {
        m_sphereStates = GetComponent<SphereStates>();
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {



            AddSphereDamage(1);
        }
    }

    public void AddSphereDamage(int damage)
    {
        m_sphereStates.SphereHp -= damage;
    }
}