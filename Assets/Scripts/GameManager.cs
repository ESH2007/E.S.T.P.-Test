using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject startMenu;
    public bool start = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (start == false)
        {
            if (Input.GetButton("Start"))
            {
                start = true;
            }
        }

        if (start == true)
        {
            startMenu.SetActive(false);
        }
    }

    void OnTriggerEnter3D(Collider collider) {
        if(collider.gameObject.tag == "Player"){
            SceneManager.LoadScene("Test", LoadSceneMode.Single);
        }
    }
}
