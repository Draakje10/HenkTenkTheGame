using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anima : MonoBehaviour
{
        // Start is called before the first frame update
        protected Animator Animation;

        protected void Awake()
        {
            Animation = GetComponent<Animator>();
        }

        protected void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
            Animation.SetBool("Shooting", true);
            }
            else if (Input.GetMouseButtonUp(0))
            {
            Animation.SetBool("Shooting", false);
            }
        }
}
