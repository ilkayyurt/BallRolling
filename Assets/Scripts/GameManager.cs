using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public Text textCollisionAmount;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        //anim =GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenDoor()
    {
        anim.SetBool("playAnim", true);
        Debug.Log("açýldý");
    }

    public void EndGame()
    {
        //GetComponent<Movement>().rb.isKinematic = true;
        textCollisionAmount.text = "KAZANDIN :) ";
    }
}
