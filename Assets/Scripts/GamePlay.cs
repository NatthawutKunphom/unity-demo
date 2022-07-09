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
    public TextMeshProUGUI txtDisplay, txtDisplay2, txtDisplay3;
    public float timeRemaining = 20;

    // Update is called once per frame
    void Update () 
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            txtDisplay3.text = "TIME " + timeRemaining.ToString("0");
        }
        else if (sum <= 0)
        {
            txtDisplay2.text = "Mission Failed";
        }
       
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

                if (sum == 120)
                {
                    txtDisplay2.text = "Mission Completed";
                    timeRemaining = 0;
                }
                else if (sum <= 0)
                {
                    txtDisplay2.text = "Mission Failed";
                    timeRemaining = 0;
                }

            }

        }
       
    }
}
