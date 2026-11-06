using UnityEngine;

public class PlayerController : MonoBehaviour
{

    string turnedState;
    public float speed;
    Vector3 movement;
    bool rotate;
    int rotation;

    void Update()
    {
        float moveForward = Input.GetAxisRaw("Vertical");

        movement = new Vector3(0f, 0f, moveForward);

        movement = movement * speed * Time.deltaTime;

        transform.position += movement;

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rotate = true;
            Turn("Right");
        }
         if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rotate = true;
            Turn("Left");
        }
    }

    async void Turn(string Direction)
    {
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
          }
     await Awaitable.WaitForSecondsAsync(0.05f);
        }

         if (Direction == "Left")
        {
         transform.rotation *= Quaternion.Euler(0,-10,0);
          rotation -= 10;

       if(rotation <= -90)
          {
           rotate = false;
           rotation = 0;
          }
  await Awaitable.WaitForSecondsAsync(0.05f);
        }

     }
    }
}
