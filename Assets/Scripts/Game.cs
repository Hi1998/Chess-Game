using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Mathematics;
using UnityEngine;

public class Game : MonoBehaviour
{
    public GameObject chessPeice;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(chessPeice, transform.position, quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
