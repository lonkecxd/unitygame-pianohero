using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GazeDes : MonoBehaviour
{

    public bool isIN = false;
    public GameObject lo;
    public GameObject controller;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(this.transform.position, this.transform.forward);
        RaycastHit hitInfo;



        if (Physics.Raycast(ray, out hitInfo, Mathf.Infinity))
        {
            if (hitInfo.collider.gameObject.tag == "IN")
            {
                lo = hitInfo.collider.gameObject;
                isIN = true;
            }
            else if (hitInfo.collider.gameObject.tag == "OUT")
            {
                Debug.Log("ON0");

                if (isIN)
                {
                    Debug.Log("ON");
                    if (lo.transform.parent == hitInfo.collider.gameObject.transform.parent)
                    {
                        controller.GetComponent<AlexController>().SPlus(20);
                        Destroy(lo.transform.parent.gameObject);
                        
                        isIN = true;
                        lo = null;
                    }
                }
                else
                {
                    isIN = false;
                    lo = null;
                }
            }
            else
            {
                isIN = false;
                lo = null;

            }


        }
        else
        {
            lo = null;
            isIN = true;
        }




    }
}

