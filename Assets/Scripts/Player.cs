using UnityEngine;
using UnityEngine.InputSystem;
public class Player : MonoBehaviour
{
    private GameObject player {get;set;}
    private InputAction moveAction;
    private InputAction interactAction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GetComponent<GameObject>();
        moveAction = InputSystem.actions.FindAction("Move");
        interactAction = InputSystem.actions.FindAction("Interact");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MovePlayer(float x, float y)
    {

    }
}
