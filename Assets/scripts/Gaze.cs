using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gaze : MonoBehaviour
{

    public GameObject text;
    public Image img;  //Gaze图标  
    public float gazeTime = 0f;  //盯着的时间  
    public float waitTime = 3f;  //盯多久才选中  
    public bool hasChangeMat = false;

    //private float x;  
    //private float y;  
    private Material otherMat;
    // Use this for initialization  
    void Start()
    {
        // x = y = 0f;     //方便电脑测试  
    }
    // Update is called once per frame  
    void Update()
    {
        /* 
     //下面三行方便电脑测试 鼠标输入 
         x += Input.GetAxis("Mouse X")*2f; 
         y += Input.GetAxis("Mouse Y")*2f; 
         this.transform.rotation = Quaternion.Euler(-y, x, 0); 
         */
        //射线检测  
        Ray ray = new Ray(this.transform.position, this.transform.forward);
        RaycastHit hitInfo;
        if (Physics.Raycast(ray, out hitInfo, Mathf.Infinity))
        {
            MeshRenderer otherRenderer = hitInfo.collider.gameObject.GetComponent<MeshRenderer>();
            if (otherRenderer != null)
            {
                if (!hasChangeMat)  //如果没有换颜色  
                {
                    gazeTime += Time.deltaTime;  //设置盯着的时间  
                    otherMat = otherRenderer.material; //设置材质引用  
                }
            }
            else
            {
                otherMat = null;
            }

        }
        else
        {
            otherMat = null;
            gazeTime = 0f;
            hasChangeMat = false;  //退出凝视则重置hasChangeMat  
        }

        //如果盯着的时间>=应该等待的时间，则表示选中  
        if (gazeTime >= waitTime)
        {
            gazeTime = 0f;
            hasChangeMat = true;
            //随机颜色并给材质  
            float r = Random.Range(0f, 1f);
            float g = Random.Range(0f, 1f);
            float b = Random.Range(0f, 1f);
            Color randomColor = new Color(r, g, b);
            otherMat.color = randomColor;

        }
        else
        {
            //设置准星形状  
            img.fillAmount = gazeTime/ waitTime ; //设置FillAmount  
        }




    }
    

}