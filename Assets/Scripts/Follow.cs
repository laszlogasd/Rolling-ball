using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform target;
    public float destRot;
    public float rotSpeed;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = target.position;
        if (GameManager.Instance.player.currentGround != null &&
            GameManager.Instance.player.currentGround.transform.localRotation.eulerAngles.y != this.transform.rotation.eulerAngles.y)
        {
            destRot = GameManager.Instance.player.currentGround.transform.localRotation.eulerAngles.y;
            if (destRot > 180)
            {
                destRot -= 360;
            }
            
        }

        float rot;
        rot = Mathf.LerpAngle(this.transform.rotation.eulerAngles.y, destRot, Time.deltaTime * rotSpeed);
        this.transform.rotation = Quaternion.Euler(0, rot, 0);
    }
}
