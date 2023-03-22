using System.Collections;
using System.Collections.Generic;
using UnityEngine;
float delay = 3.0;
float score = 0.0;
float scoref = 0.0;
public Material easy;
public Material medium;
public Material hard;
public class PartOfGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        scoref = 0.0;
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Processuss());
    }

    float getScore(){
        return scoref;
    }
    float getDelay(){
        return delay;
    }

    IEnumerator Processuss()
{
    GetComponent<MeshRenderer>().material = easy;
    score = 1.0;
    yield return new WaitForSeconds(1.5);

    GetComponent<MeshRenderer>().material = medium;
    score = 2.0;
    yield return new WaitForSeconds(1.0);

    GetComponent<MeshRenderer>().material = hard;
    score = 5.0;
    yield return new WaitForSeconds(0.5);
}
    void beenHit(){
        scoref = score;
        gameObject.setActive(false);
    }

}
