using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeMaker : MonoBehaviour {
    public GameObject locator;
    public float waitTime =1;
    public float prTime = 0;
    public int direction = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        direction = (int)(Random.Range(0, 4));
        
        prTime += Time.deltaTime;
        print(Time.time);
        waitTime = Random.Range(2f,8f)*(Mathf.Exp( -1/1000*Time.time)/(1+ Mathf.Exp(-1/1000*Time.time)));
        float x = Random.Range(-1f, 1f);
        float z = Random.Range(-1f, 1f);

        Vector3 loc = new Vector3(x, 0, z);

        if (prTime >= waitTime)
        {
            GameObject newOne = Instantiate(locator, 10*loc, Quaternion.identity);
            newOne.transform.LookAt(Vector3.zero);
            newOne.transform.Rotate(transform.forward, 90 * direction);
            prTime = 0;
            Destroy(newOne, 20);
        }

    }
}
