using System.Collections;
using System.Collections.Generic;
using UnityEngine;
float score = 0;
public class playSound : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        steps = GetComponent<GetSteps>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    float launchGame(){
        score =0.0;
        GameObject[] list = steps.getList();
        for(i =0; i< list.length() ; i++){
            list[i].setActive(true);
            yield WaitForSeconds(list[i].PartOfGame.getDelay());
            score += list[i].PartOfGame.getScore();
            list[i].setActive(false);
        }
    }
}
