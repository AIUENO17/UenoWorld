using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpDisposition : MonoBehaviour
{
    public enum PublicPickUpDisposition
    {
        None = 0,
        SpeedUp,
        SpeedDown,
        QTE,
        DispositionMax
    }

    public PublicPickUpDisposition m_pickUpDisposition = PublicPickUpDisposition.None;
    // Start is called before the first frame update
    private void Awake()
    {
        var randomDisposition = 0;

        randomDisposition = Random.Range((int)PublicPickUpDisposition.None, (int)PublicPickUpDisposition.DispositionMax);
        m_pickUpDisposition = (PublicPickUpDisposition)randomDisposition;
    }

}
