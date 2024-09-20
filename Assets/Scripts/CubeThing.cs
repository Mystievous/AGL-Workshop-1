using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeThing : MonoBehaviour
{
    private float counter;
    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
        counter += Time.deltaTime;
        
        Debug.Log((int) counter);
    }
}
