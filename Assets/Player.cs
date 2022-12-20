using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    TestInputActions testInputActions;

    void Awake()
    {
        testInputActions = new TestInputActions();
        testInputActions.Enable();
        testInputActions.Player.Fire.performed += context => Debug.Log("Fire");
    }

    // Update is called once per frame
    void Update()
    {
        const float Speed = 1f;

        var direction = testInputActions.Player.Move.ReadValue<Vector2>();
        transform.Translate(direction * Speed * Time.deltaTime);
    }
}
