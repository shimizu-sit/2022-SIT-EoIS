using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GamePadExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // ゲームパッドが接続されていないとnullになる
        if (Gamepad.current == null) return;
        //if (GamePadExample.current.button)

    }

    // Update is called once per frame
    void Update()
    {

    }
}
