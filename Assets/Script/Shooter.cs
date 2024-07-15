using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        SetShot();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetShot()
    {
        Invoke(nameof(Shot), 1.0f);
    }

    private void Shot()
    {
        GameObject obj = Instantiate(ball, this.transform.position, Quaternion.identity);
        obj.GetComponent<Rigidbody>().AddForce(new Vector3(0.0f, 0.0f, -3.5f), ForceMode.Impulse);
    }
}
