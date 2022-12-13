using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KapsulasKontrole : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update metodē pēc katriem 60 uzzīmētiem kadriem nomainīt kapsulas krāsu uz kādu nejauši izvēlētu krāsu (Random)
    void Update()
    {
        if (Time.frameCount % 60 == 0)
        {
            GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
        }
        
    }
}
