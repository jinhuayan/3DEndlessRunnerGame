using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMgr : MonoBehaviour
{
    public GameObject[] blocks;
    public float spawnTime;
    public float spawnDelay;
    private float forward;
    public static BlockMgr instance;

    public void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this);
    }

    public void CreateGround()
    {
        UpdateDis();
        Instantiate(blocks[Random.Range(0, blocks.Length)], new Vector3(0, -0.5f, forward), Quaternion.Euler(new Vector3(-90, 0, 0)));
    }

    public void UpdateDis()
    {
        forward+=20;
    }

    // Start is called before the first frame update
    void Start()
    {
        forward = 5;
        InvokeRepeating("CreateGround", spawnTime, spawnDelay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
