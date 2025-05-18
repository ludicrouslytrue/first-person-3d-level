using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    public Vector3 respawnPosition = new Vector3(0f, 5f, 0f);
    public float respawnYThreshold = -1f;
    private CharacterController controller;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    void Update()
    {
        if (transform.position.y < respawnYThreshold)
        {
            Respawn();
        }
    }
    void Respawn()
    {
        if (controller != null)
            controller.enabled = false;

        transform.position = respawnPosition;

        if (controller != null)
            controller.enabled = true;
    }
}
