using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spectrum : MonoBehaviour {
    float [] spectrum;
    public GameObject cube;
    GameObject[] cubes;
    public const int numbersOfCube=1024;
    float ridus;
    public float secondsPerLerp=0.2f;
    public float height = 20f;
    float seconds= 0f;
    float[] y;
	// Use this for initialization
	void Start () {
        height = numbersOfCube *6;
        seconds = secondsPerLerp;
        spectrum = new float[numbersOfCube];
        cubes = new GameObject[numbersOfCube];
        y= new float[numbersOfCube];
        ridus = numbersOfCube / (2 * Mathf.PI);
        for (int i = 0; i < numbersOfCube; i++)
        {
            cubes[i] = Instantiate(cube);
            cubes[i].GetComponent<CubeTag>().tag = i;
            //line
            //cubes[i].transform.Translate(new Vector3((i-numbersOfCube/2)*0.5f,0f,0f));


            //circle
            float radian = i * 2 * Mathf.PI / numbersOfCube;
            cubes[i].transform.Translate(new Vector3(ridus*Mathf.Cos(radian),0f , ridus * Mathf.Sin(radian)));
            cubes[i].transform.Rotate(Vector3.up,360-Mathf.Rad2Deg*radian) ;


        }
    }
	
	// Update is called once per frame
	void Update () {
        //spectrum = AudioListener.GetSpectrumData(64,0,FFTWindow.Hamming);
        //Debug.Log(cubes[127].GetComponent<Transform>().localScale.y + "  "+spectrum[127]);
        //Debug.Log(Mathf.Lerp(cubes[127].GetComponent<Transform>().localScale.y, spectrum[127], 0.5f)*20);
            
        if (seconds >= secondsPerLerp)
        {
            AudioListener.GetSpectrumData(spectrum, 0,FFTWindow.Hamming);
            seconds = 0f;
            for(int i=0;i<numbersOfCube;i++)
                y[i] = cubes[i].GetComponent<Transform>().localScale.y;
        }
        seconds += Time.deltaTime;
        for (int i=0;i<numbersOfCube;i++)
        {
            
            float nextY =  Mathf.Lerp(y[i], spectrum[i] * height, seconds/secondsPerLerp);
     
           
            cubes[i].GetComponent<Transform>().localScale=new Vector3(1f,nextY, 1f);
        }

    }
}
