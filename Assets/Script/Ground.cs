using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public GameObject shooter;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name.Contains("Ball"))
        {
            if (collision.transform.GetComponent<Ball>().flag)
            {
                shooter.GetComponent<Shooter>().SetShot();
                collision.transform.GetComponent<Ball>().flag = false;
            }
        }
    }
}
