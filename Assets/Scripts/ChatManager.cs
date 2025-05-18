using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;

public class ChatManager : MonoBehaviour
{
    public GameObject chatPanel;
    public GameObject chatScrollContent;
    public TMP_InputField chatInputField;
    public GameObject textBubblePrefab;
    private bool chatOpen = false;
    public void OpenChat()
{
    chatPanel.SetActive(true);
    chatOpen = true;
    chatInputField.ActivateInputField();
}
    void Start()
    {
        chatPanel.SetActive(false);
        chatInputField.onSubmit.AddListener(OnMessageSubmit);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            ToggleChatWindow();
        }
    }
    void ToggleChatWindow()
    {
        chatOpen = !chatOpen;
        chatPanel.SetActive(chatOpen);

        if (chatOpen)
        {
            chatInputField.ActivateInputField();
        }
        else
        {
            chatInputField.DeactivateInputField();
        }
    }
    void OnMessageSubmit(string message)
    {
        if (!string.IsNullOrEmpty(message))
        {
            AddMessage(message);
            chatInputField.text = "";
            chatInputField.ActivateInputField();
        }
    }
    public void AddMessage(string message)
    {
        GameObject bubble = Instantiate(textBubblePrefab, chatScrollContent.transform, false);
        TMP_Text bubbleText = bubble.GetComponentInChildren<TMP_Text>();
        bubbleText.text = message;
    }
}