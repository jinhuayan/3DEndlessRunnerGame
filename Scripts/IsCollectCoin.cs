using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsCollectCoin : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<IsaBCoin>() != null)
        {
            Debug.Log("we hit a" + collision.gameObject.name);

            ScoreMgr.instance.score += 3;
            SoundMgr.instance.PlayCoinSfx();
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.GetComponent<IsaRCoin>() != null)
        {
            Debug.Log("we hit a" + collision.gameObject.name);

           ScoreMgr.instance.score += 5;
           SoundMgr.instance.PlayCoinSfx();
            Destroy(collision.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
