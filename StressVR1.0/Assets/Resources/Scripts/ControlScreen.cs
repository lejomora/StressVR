using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ControlScreen : MonoBehaviour
    
{
    // Start is called before the first frame update
    public GameObject newscreen;
    public GameObject oldscreen;
    //public GameObject oldscreen1;
    //public GameObject oldscreen2;
    // public GameObject oldscreen3;
    public AudioSource sound;
    public AudioSource soundold;
    public GameObject objSound;
    public GameObject objSoundold;
    public UnityEngine.Object next;
  

    private bool snew = false;

    void Start()
    {
        sound = objSound.GetComponent<AudioSource>();
        soundold = objSoundold.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnButton()
    {
        if (next == true)
        {
            if (!snew)
            {
                // oldscreen1.SetActive(false);
                // oldscreen2.SetActive(false);
                // oldscreen3.SetActive(false);
                oldscreen.SetActive(false);
                newscreen.SetActive(true);
                sound.Play();
                soundold.Stop();
            }
        }
    }
}
