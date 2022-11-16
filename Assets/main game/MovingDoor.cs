using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingDoor : MonoBehaviour
{
    public bool isOpen = false;
    public Transform door;
    public Transform startingPoint;
    public Transform endingPoint;

    // Start is called before the first frame update
     private void Start()
    {
        door.position = startingPoint.position;
    }

    // Update is called once per frame
     private void Update()
    {
        if (isOpen == true)
        {
            door.position = Vector3.MoveTowards(door.position, endingPoint.position, Time.deltaTime);
        }
    }
}
