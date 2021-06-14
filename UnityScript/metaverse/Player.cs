using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player: MonoBehaviour
{
    public static GameObject raytarget;
    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    private float playerSpeed = 2.0f;
    private float jumpHeight = 1.0f;
    private float gravityValue = -9.81f;

    private void Start()
    {
        controller = gameObject.AddComponent<CharacterController>();
    }

    void Update()
    {
        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(move * Time.deltaTime * playerSpeed);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }

        // Changes the height position of the player..
        if (Input.GetButtonDown("Jump") && groundedPlayer)
        {
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        }

        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);
        ////////////////////////////////////////////////////
        ///

        Debug.DrawRay(transform.position, transform.forward * 8, Color.red);

        //  레이캐스트가 빨간줄로 실제로 보게 만들어 준다.

        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit, 8))

        // (시작점,방향 ,hit info,거리)

        {

            //Debug.Log(hit.collider.gameObject.name);
            raytarget = hit.collider.gameObject;


            // 광선이 충돌한 오브젝트를 로그창에 보여 준다.

        }

    }
}