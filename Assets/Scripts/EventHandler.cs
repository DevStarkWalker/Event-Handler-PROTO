using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventHandler : MonoBehaviour
{

    private GameObject player;
    private GameObject welcomeText;
    public List<GameObject> currentMission;



    // Start is called before the first frame update
    void Start()
    {
        Instantiate(player, new Vector3(12, 0, 1), player.transform.rotation);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("Key pressed");
            welcomeText.gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("Guide"))
        {
            
        }
        //Instantiate(currentMission, new Vector3(0, 0, 0), currentMission.transform.rotation);
    }
}
