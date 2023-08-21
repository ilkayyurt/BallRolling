using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Trigger : MonoBehaviour
{
    private GameObject manager;
    [HideInInspector] 
    public int diamondAmount;

    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("GameController");
    }

    // Update is called once per frame
    void Update()
    {
        if (diamondAmount == 4)
        {
            manager.GetComponent<GameManager>().OpenDoor();
        }


        if (diamondAmount == 5)
        {
            GetComponent<Movement>().rb.isKinematic = true;
            manager.GetComponent<GameManager>().EndGame();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Prize"))
        {
            Destroy(other.gameObject);
            diamondAmount += 1;
        }
        if (other.gameObject.tag == "DeadZone")
        {
            SceneManager.LoadScene("MarbleGame");
        }

        


    }
}
