using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class PlayerController : MonoBehaviour
    {
        Rigidbody physic;
        public int speed = 1;
        public float xmin;
        public float xmax;
        public float zmin;
        public float zmax;
        [SerializeField] GameObject shot;
        [SerializeField] GameObject shotspawn;
        [SerializeField] float nextFire;
        [SerializeField] float fireRate;
        AudioSource audioPlayer;
        void Start()
        {
            physic = GetComponent<Rigidbody>();
            audioPlayer = GetComponent<AudioSource>();
        }
        void Update()
        {
            Debug.Log(Time.time);
            if (Input.GetKey(KeyCode.Space) && Time.time > nextFire)
            {
                audioPlayer.Play();
                nextFire = Time.time + fireRate;
                Instantiate(shot, shotspawn.transform.position, shotspawn.transform.rotation);
            }
        }
        void FixedUpdate()
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
            Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);
            physic.velocity = movement * speed;

            Vector3 position = new Vector3(
                Mathf.Clamp(physic.position.x, xmin, xmax),
                -3,
                Mathf.Clamp(physic.position.z, zmin, zmax));

            physic.position = position;
            physic.rotation = Quaternion.Euler(0, 0, physic.velocity.x * (-10));


        }
    }