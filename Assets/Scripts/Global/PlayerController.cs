using UnityEngine;

public class PlayerController : MonoBehaviour
{

    string turnedState;
    public float speed;
    Vector3 movement;
    bool rotate;
    bool isRotating;
    int rotation;


    void Update()
    {
        float moveForward = Input.GetAxisRaw("Vertical");

        movement = new Vector3(0f, 0f, moveForward);

        movement = movement * speed * Time.deltaTime;

        transform.position += movement;

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
