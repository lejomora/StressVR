using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueSC : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;

    public string[] lines;

    public float textSpeed = 0.1f;

    int index;


    void Start()
    {
        dialogueText.text = string.Empty;
        StartDialogue();
    }


    void Update()
    {

    }

    public void StartDialogue()
    {
        index = 0;
        StartCoroutine(WriteLine());
    }

    IEnumerator WriteLine()
    {
        foreach (char letter in lines[index].ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(textSpeed);
        }

    }


}
