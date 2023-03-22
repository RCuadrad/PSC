using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HittingTarget : MonoBehaviour
{

    [SerializeField]
    private Camera cam;

    [SerializeField]
    private int rangeHit;

    //Ray ray;
    RaycastHit hitData;
    GenerateSound son;

    Vector3 impactPoint = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Cree un rayon qui part du centre de la camera
            Vector3 rayOrigin = cam.ViewportToWorldPoint (new Vector3(0.5f, 0.5f, 0.0f));
            //Si on touche un objet pas trop loin
            if(Physics.Raycast(rayOrigin,cam.transform.forward, out hitData, rangeHit))
            {
                //On utilise la fonction de generation de son de l'objet touche
                son = hitData.collider.GetComponent<GenerateSound>();
                if(son !=null){
                    impactPoint = hitData.point;
                    son.triggeringSound(impactPoint);
                }
                //On regarde également si l'objet fait partie d'un jeu
                game = hitData.collider.GetComponent<PartOfGame>();
                if(game!=null){
                    game.beenHit();
                }
            }
        }
    }
}
