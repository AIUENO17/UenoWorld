using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPool : MonoBehaviour
{
    [SerializeField] private GameObject m_bullet = null;
    private GameObject[] m_bullets = new GameObject[PoolSize];
    private const int PoolSize = 5;
    // Start is called before the first frame update
    private void Awake()
    {
        for (int i = 0; i < PoolSize; i++)
        {
            m_bullets[i] = Instantiate(m_bullet);
            m_bullets[i].SetActive(false);
        }
    }
    public GameObject GetBullet(Transform transform)
    {
        foreach (var bullet in m_bullets)
        {
            if (!bullet.activeInHierarchy)
            {
                bullet.transform.position = transform.position;
                bullet.transform.rotation = transform.rotation;
                bullet.SetActive(true);
                return bullet;
            }
        }
        return null;
    }
}
