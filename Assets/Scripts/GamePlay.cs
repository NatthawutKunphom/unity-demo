using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GamePlay : MonoBehaviour

{
    int RedSphere = -20;
    int BuleSphere = 10;
    int GreenSphere = 20;
    int sum = 0;
    public TextMeshProUGUI txtDisplay;

    // Update is called once per frame
    void Update () 
    {
       
        if (Input.GetMouseButtonDown (0)) 
        {
            Ray ray =  Camera.main.ScreenPointToRay (Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast (ray, out hit)) 
            {
                if (hit.collider.gameObject.name.CompareTo("RedSphere") == 0)
                {
                    hit.collider.gameObject.SetActive(false);
                    sum = sum + RedSphere;
                    
                }
                else if (hit.collider.gameObject.name.CompareTo("GreenSphere") == 0)
                {
                    hit.collider.gameObject.SetActive(false);
                    sum = sum + GreenSphere;
                    
                }
                else if (hit.collider.gameObject.name.CompareTo("BuleSphere") == 0)
                {
                    hit.collider.gameObject.SetActive(false);
                    sum = sum + BuleSphere;
                }
                

                Debug.Log(sum);
                txtDisplay.text =" "+sum;

            }

        }
       
    }
}
