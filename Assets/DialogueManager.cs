using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public GameObject dialoguePanel;
    public TextMeshProUGUI dialogueText;
    private bool isOpen = false;

    void Update()
    {
        if (Keyboard.current.eKey.wasPressedThisFrame)
        {
            if (isOpen)
            {
                CloseDialogue();
            }
            else
            {
                OpenDialogue("Hello. Who are you?");
            }
        }
    }

    public void OpenDialogue(string text)
    {
        dialoguePanel.SetActive(true);
        dialogueText.text = text;
        isOpen = true;
    }

    public void CloseDialogue()
    {
        dialoguePanel.SetActive(false);
        isOpen = false;
    }
}