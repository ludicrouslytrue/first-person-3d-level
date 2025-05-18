using UnityEngine;
using TMPro;

public class TrophyInteraction : MonoBehaviour
{
    public GameObject tooltip;
    public Transform trophyHandPosition;
    public ChatManager chatManager;
    public Camera playerCamera;
    
    private bool isPlayerNear = false;
    private bool trophyEquipped = false;

    void Start()
    {
        if (tooltip != null)
            tooltip.SetActive(false);
        if (playerCamera == null)
            playerCamera = Camera.main;
    }

    void Update()
    {
        if (trophyEquipped) return;

        if (isPlayerNear)
        {
            if (tooltip != null)
                tooltip.SetActive(true);
            
            if (Input.GetKeyDown(KeyCode.E))
            {
                EquipTrophy();
                if (chatManager != null)
                {
                    chatManager.AddMessage("I won the trophy!");
                    chatManager.OpenChat(); 
                }
            }
        }
        else
        {
            if (tooltip != null)
                tooltip.SetActive(false);
        }
    }

    private void EquipTrophy()
    {
        transform.SetParent(trophyHandPosition);
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.identity;
        transform.localScale = Vector3.one;

        gameObject.SetActive(true);
        Renderer rend = GetComponent<Renderer>();
        if (rend != null) rend.enabled = true;

        Destroy(GetComponent<Rigidbody>());
        Destroy(GetComponent<Collider>());
        
        trophyEquipped = true;
        if (tooltip != null)
            tooltip.SetActive(false);

        GameObject playerRoot = GameObject.FindGameObjectWithTag("Player");
        if (playerRoot != null)
        {
            var controller = playerRoot.GetComponent<CharacterController>();
            if (controller != null) controller.enabled = false;
            playerRoot.transform.position = new Vector3(0f, 5f, 0f);
            if (controller != null) controller.enabled = true;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNear = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNear = false;
        }
    }
}
