using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine.SceneManagement;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using System.Collections.Specialized;
using System.Security.Cryptography;



namespace Tests
{
    public class NewTestScript
    {
        [SetUp]
        public void setup()
        {
            SceneManager.LoadScene("newsceball", LoadSceneMode.Single);
        }



        [UnityTest]
        public IEnumerator CanFindPlayerGameObject()
        {
            GameObject go = null;
            go = GameObject.Find("Player");
            Assert.NotNull(go);



            yield return null;
        }
        [UnityTest]
        public IEnumerator SampleSceneIsLoaded()
        {
            Assert.AreEqual(SceneManager.GetActiveScene().name, "newsceball");
            yield return null;
        }



        [UnityTest]
        public IEnumerator MoveFront()
        {
            Vector3 before, after;
            GameObject player = GameObject.Find("Player");
            before = player.GetComponent<Transform>().position;



            Rigidbody rb;



            rb = player.GetComponent<Rigidbody>();
            rb.AddForce(new Vector3(0.0f, 0.0f, 100.0f) * 10);



            yield return null;
            yield return null;
            after = player.GetComponent<Transform>().position;
            Assert.AreNotEqual(before, after);
        }
        [UnityTest]
        public IEnumerator CollectionPointMakesThemDisappear()
        {
            GameObject pickup = GameObject.Find("PickUp");
            Assert.That(pickup);
            GameObject player = GameObject.Find("Player");
            Rigidbody rb;
            rb = player.GetComponent<Rigidbody>();
            rb.AddForce(new Vector3(200.0f, 0.0f, 0.0f) * 10);



            yield return null;
            yield return null;
            yield return null;
            yield return null;
            yield return null;
            yield return null;



            Assert.That(!pickup.activeInHierarchy, "Object is still active");
        }



        [UnityTest]
        public IEnumerator PickUp1()
        {
            GameObject pickup1 = GameObject.Find("PickUp (1)");
            Assert.That(pickup1);
            GameObject player = GameObject.Find("Player");
            Rigidbody rb;
            rb = player.GetComponent<Rigidbody>();
            rb.AddForce(new Vector3(20.0f, 0.0f, 200.0f) * 10);



            yield return null;
            yield return null;
            yield return null;
            yield return null;
            yield return null;
            yield return null;



            Assert.That(!pickup1.activeInHierarchy, "Object is still active");
        }
        [UnityTest]
        public IEnumerator JumpAction()
        {
            Vector3 before, after;
            GameObject player = GameObject.Find("Player");
            before = player.GetComponent<Transform>().position;



            Rigidbody rb;



            rb = player.GetComponent<Rigidbody>();
            rb.AddForce(new Vector3(0.0f, 1.0f, 0.0f) * 10);



            yield return null;
            yield return null;
            yield return null;
            yield return null;
            yield return null;




            after = player.GetComponent<Transform>().position;
            Assert.AreNotEqual(before, after);
        }



        [UnityTest]
        public IEnumerator MoveBack()
        {
            Vector3 before, after;
            GameObject player = GameObject.Find("Player");
            before = player.GetComponent<Transform>().position;



            Rigidbody rb;



            rb = player.GetComponent<Rigidbody>();
            rb.AddForce(new Vector3(0.0f, 0.0f, -100.0f) * 10);



            yield return null;
            yield return null;
            yield return null;
            yield return null;
            yield return null;




            after = player.GetComponent<Transform>().position;
            Assert.AreNotEqual(before, after);
        }




        [UnityTest]
        public IEnumerator HitTheWall()
        {
            //Vector3 before, after;
            GameObject wall = GameObject.Find("West Wall");
            Assert.That(wall);
            GameObject player = GameObject.Find("Player");
            //before = player.GetComponent<Transform>().position;



            Rigidbody rb;



            rb = player.GetComponent<Rigidbody>();
            rb.AddForce(new Vector3(0.0f, 0.0f, 400.0f) * 10);



            yield return null;
            yield return null;
            yield return null;
            yield return null;
            yield return null;





            Assert.That(wall.activeInHierarchy, "Object is not active");
        }



        /*[UnityTest]
        public IEnumerator PickUpParent()
        {
            GameObject pickup = GameObject.Find("Pickup Parent");
            Assert.That(pickup);
            GameObject player = GameObject.Find("Player");
            Rigidbody rb;
            rb = player.GetComponent<Rigidbody>();
            rb.AddForce(new Vector3(0.0f, 0.0f, 60.0f) * 10);

 

            yield return null;
            yield return null;
            yield return null;
            yield return null;

 

            Assert.That(!pickup.activeInHierarchy, "Object is still active");
        }*/




    }
}