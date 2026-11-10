using UnityEngine;

public class PlayerController : MonoBehaviour
{

    string turnedState;
    public float speed;
    //Vector3 movement;
    bool rotate;
    bool isRotating;
    int rotation;
    
    bool move;
    bool isMoving = false;
    int movement;

    void Update()
    {
        float moveForward = Input.GetAxisRaw("Vertical");

       // movement = new Vector3(0f, 0f, moveForward);

      //  movement = movement * speed * Time.deltaTime;

       // transform.position += movement;

        //turning logic
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            rotate = true;
            Turn("Right");
        }
         if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            rotate = true;
            Turn("Left");
        }


        //moving logic
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            move = true;
            Move("Forward");
        }
        else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            move = true;
            Move("Back");
        }

    }

    async void Move(string Direction)
    {
        if(move && !isRotating)
        {
                //Vector3 initialPosition = transform.position;
            isMoving = true;
            while(move)
            {
                if (Direction == "Forward")
                {
                    transform.Translate(Vector3.forward);
                    movement += 1;

                    if(movement >= 5)
                        {
                            move = false;
                            movement = 0;
                            isMoving = false;
                        }
                    await Awaitable.WaitForSecondsAsync(0.02f);
                }   

                if (Direction == "Back")
                {
                    transform.Translate(Vector3.back);
                    movement -= 1;

                    if(movement <= -5)
                    {
                        move = false;
                        movement = 0;
                        isMoving = false;
                    }
                    await Awaitable.WaitForSecondsAsync(0.02f);
                }

            }
        }
    }


    async void Turn(string Direction)
    {
        if(rotate)
        {
            isRotating = true;
while(rotate)
     {
        if (Direction == "Right")
        {
         transform.rotation *= Quaternion.Euler(0,10,0);
          rotation += 10;

       if(rotation >= 90)
          {
           rotate = false;
           rotation = 0;
           isRotating = false;
          }
     await Awaitable.WaitForSecondsAsync(0.03f);
        }

         if (Direction == "Left")
        {
         transform.rotation *= Quaternion.Euler(0,-10,0);
          rotation -= 10;

       if(rotation <= -90)
          {
           rotate = false;
           rotation = 0;
           isRotating = false;
          }
  await Awaitable.WaitForSecondsAsync(0.03f);
        }

     }
        }
     
    }
}
