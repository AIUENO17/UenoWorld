using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereStates : MonoBehaviour
{
    [SerializeField] private ObjectStates m_objectStates = null;

    private ObjectData m_sphereData = null;

    public int SphereHp = 0;
    // Start is called before the first frame update
   private  void Aweke()
    {
        foreach (var pickUpData in m_objectStates.ObjectStatesList)
        {
            if (pickUpData.Name.Equals("Sphere"))
            {
                m_sphereData = pickUpData;
                SphereHp = m_sphereData.Hp;
            }
        }
    }

    // Update is called once per frame
   private  void Update()
    {
        if (SphereHp <= 0)
        {
            Debug.Log("ゲームオーバー");
        }
    }
}
