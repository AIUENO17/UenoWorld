using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pitfall : MonoBehaviour
{

    [SerializeField] private Collider m_stageCollider = null;
    [SerializeField] private float m_convergeTime = 5f;
    [SerializeField] private float m_safeTime = 5f;

    float sinScale = 0f;

    private Transform m_transform = null;

    private bool m_isFall = false;
    // Start is called before the first frame update
   private  void Start()
    {
        m_transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    private void Update()
    {
        m_safeTime -= Time.deltaTime;

        if (m_safeTime > 0)
        {
            return;
        }
        m_convergeTime -= Time.deltaTime;
        sinScale = Mathf.Sin(Mathf.PI * Time.time);
        m_transform.localScale = new Vector3(sinScale * 2, 1, sinScale * 2);

        if (m_transform.localScale.x > 1.5f)
        {
            m_isFall = true;
        }
        else
        {
            m_isFall = false;
        }
        if (m_convergeTime > 0)
        {
            return;
        }

        m_transform.localScale = new Vector3(0, 0, 0);
        m_convergeTime = 5f;
        m_safeTime = 5f;
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && m_isFall)
        {
            m_stageCollider.enabled = false;
        }
    }
}
