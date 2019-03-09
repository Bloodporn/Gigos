using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VragControl : MonoBehaviour
{
    GameObject vrag;
    public int stress=100;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Fear(int fear)
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (stress > 100)
        {
            FindObjectOfType<AudioManager>().Play("Cry");
            Destroy(gameObject);
        }
    }
}
