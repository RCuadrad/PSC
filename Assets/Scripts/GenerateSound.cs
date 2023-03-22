using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateSound : MonoBehaviour
{
    public LibPdInstance pdPatch;
    private GetSpecs fct;
    private static int nbMaxHarmoniques = 5;
    private Vector3 coordImpact;
    [SerializeField]
    int nbHarmoniques;

    float fondamental;

    
    float[] amplitudes = new float[nbMaxHarmoniques];

    void Start()
    {
        //On detecte la fonction de calcul des harmoniques de l'objet
        fct = GetComponent<GetSpecs>();
    }
    public void triggeringSound(Vector3 positionImpact)
    {
        //La on calcule les caracteristiques des vibrations
        coordImpact = positionImpact - fct.getOrigin(); 
        fondamental = fct.getFrq(coordImpact);
        amplitudes = fct.getAmp(coordImpact);

        //La on renvoie dans le patch pd
        pdPatch.SendFloat("fondamental",fondamental);
        for(int i =1; i<=nbMaxHarmoniques; i++){
            pdPatch.SendFloat("amplitude"+i, amplitudes[i-1]);
        }
        
    }
}
