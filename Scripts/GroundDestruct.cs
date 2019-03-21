using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDestruct : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Destruct()
    {
        Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("Destruct", 5f);
    }
}
