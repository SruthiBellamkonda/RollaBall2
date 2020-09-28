using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    GameObject[] go_objs;
    GameObject co_objs;
    GameObject plane;
    GameObject collectibles;
    // Start is called before the first frame update
    void Start()
    {
        GameObject env = new GameObject("ENvironemnt");

        GameObject wall = new GameObject("Wall");
        wall.transform.SetParent(env.transform);

        plane = GameObject.CreatePrimitive(PrimitiveType.Cube);
        plane.name = "Plane";
        plane.transform.SetParent(env.transform);

        go_objs = new GameObject[4];
        for (int i = 0; i < 4; i++)
        {
            go_objs[i] = GameObject.CreatePrimitive(PrimitiveType.Cube);
            go_objs[i].name = "cube" + i;
            go_objs[i].transform.SetParent(wall.transform);
        }

        GameObject ball = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        ball.transform.SetParent(env.transform);
        Rigidbody ballRigidBody = ball.AddComponent<Rigidbody>(); // Add the rigidbody.
        ballRigidBody.mass = 5;
        ball.GetComponent<Renderer>().material.color = Color.blue;
        ball.name = "ball";

        collectibles = new GameObject("Collectibles");
        collectibles.transform.SetParent(env.transform);
        
            co_objs = GameObject.CreatePrimitive(PrimitiveType.Cube);
            //co_objs[i].name = "cube" + i;
            //co_objs.transform.Rotate(45, 90.0f, 0);
            co_objs.transform.SetParent(collectibles.transform);
                co_objs.GetComponent<Renderer>().material.color = Color.yellow;


        CreateEnvironemnt();
    }
 
         void CreateEnvironemnt()
        {
            SetPlane(plane);
            for (int i = 0; i < 4; i++)
            {
                SetCube(go_objs[i], i);
            }
        SetCollectibles(collectibles);
        }

    void SetPlane(GameObject obj)
    {
        obj.transform.localPosition = InputValues1.plane_pos;
        obj.transform.localRotation = InputValues1.plane_rot;
        obj.transform.localScale = InputValues1.plane_scale;
    }
    void SetCollectibles(GameObject obj)
    {
        obj.transform.localPosition = InputValues1.col_pos;
        obj.transform.localRotation = InputValues1.col_rot;
        obj.transform.localScale = InputValues1.col_scale;
    }
    void SetCube(GameObject obj, int index)
        {
            switch (index)
            {
                case 0:
                    obj.transform.localPosition = InputValues1.cube1_pos;
                    obj.transform.localRotation = InputValues1.cube1_rot;
                    break;
                case 1:
                    obj.transform.localPosition = InputValues1.cube2_pos;
                    obj.transform.localRotation = InputValues1.cube2_rot;
                    break;
                case 2:
                    obj.transform.localPosition = InputValues1.cube3_pos;
                    //obj.transform.localRotation = InputValues1.cube3and4_rot;
                     obj.transform.Rotate(0, 90.0f, 0);

                    break;
                case 3:
                    obj.transform.localPosition = InputValues1.cube4_pos;
                //obj.transform.localRotation = InputValues1.cube3and4_rot;
                obj.transform.Rotate(0, 90.0f, 0);

                break;


            }

            obj.transform.localScale = InputValues1.cube_scale;
        }

     
    }
 
