using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetSpecs : MonoBehaviour
{
    private Vector3 origin = Vector3.zero;

    private float fondamental = 440;

    private float[] amplitude = {60,30,20,15,12};

    public Vector3 getOrigin(){
        return transform.position;
    }

    public float getFrq(Vector3 impact){
        return fondamental*(impact.magnitude);
    }

    public float[] getAmp(Vector3 impact){
        return amplitude;
    }
    
    
    
    
    
    

}
