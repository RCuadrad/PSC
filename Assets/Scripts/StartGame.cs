using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class StartGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            //Cree un rayon qui part du centre de la camera
            Vector3 rayOrigin = cam.ViewportToWorldPoint (new Vector3(0.5f, 0.5f, 0.0f));
            //Si on touche un objet pas trop loin
            if(Physics.Raycast(rayOrigin,cam.transform.forward, out hitData, rangeHit))
            {
                //On lance le jeu associé à l'objet visé
                game = hitData.collider.GetComponent<PlayGame>();
                game.launchGame();
            }
        }
    }
}
