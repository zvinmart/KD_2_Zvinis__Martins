using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KastesKontrole : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    // FixedUpdate metodē rotēt kasti un tās elementus atkarībā no lietotāja spiestajām bultiņām vertikālās bultiņas - ap X asi; horizontālās bultiņas - ap Z asi; 
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(Vector3.right, 1);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(Vector3.right, -1);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.forward, 1);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.forward, -1);
        }
    }
}
