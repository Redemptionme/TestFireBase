using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var mesh = GetComponent<Mesh>();
        var colors = mesh.colors;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
