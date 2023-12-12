using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public string upKeyToMove;
    public string downKeyToMove;
    public int yDirectionToMove;
    public int ySpeedMovement;
    public int yMinLimitToMove;
    public int yMaxLimitToMove;
    private float yPosition;
    public string playerType;
    // Start is called before the first frame update
    void Start()
    {

    }
    void Update()
    {
        if (Input.GetKeyDown(downKeyToMove))
        {
            yDirectionToMove = 0;
        }
        else if (Input.GetKeyUp(downKeyToMove))
        {
            yDirectionToMove = 5;
        }
        //if (Input.GetAxis(downKeyToMove))
        //{
//yDirectionToMove = -40;
        //}
        yPosition = Mathf.Clamp(transform.position.y - ySpeedMovement + yDirectionToMove * Time.deltaTime ,  yMinLimitToMove, yMaxLimitToMove);
        transform.position = new Vector3(yPosition, transform.position.z);
    }
    void Clamp()
    {

    }
}

    

    // Update is called once per frame
    



