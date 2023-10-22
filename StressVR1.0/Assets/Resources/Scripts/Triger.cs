using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triger : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject limit;
    public GameObject screen;
    public AudioSource sound;
    public GameObject player;
    public GameObject objSound;
    public GameObject limitend;

    private bool activated = false;

    void Start()
    {
        sound = objSound.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
      
        
    }
    public void OnTriggerEnter(Collider player )
    {
        if (player != null)
        {
            Debug.Log("Entro");
            if (!activated)
            {
                Debug.Log("ACTIVO");
                screen.SetActive(true);
                sound.Play();
            }


        }

    }
    private void OnTriggerExit(Collider player)
    {
        if (player != null)
        {
            Debug.Log("Salio");
            if (!activated)
            {
                screen.SetActive(false);
                sound.Stop();
            }

        }

    }
}
