using UnityEngine;
using System.Collections;
using Steamworks;

namespace S3
{
    public class Controlar_Player : MonoBehaviour
    {
        void Update()
        {
            float x = Input.GetAxis("Horizontal") * Time.deltaTime * 250.0f;
            float z = Input.GetAxis("Vertical") * Time.deltaTime * 10.0f;

            transform.Rotate(0, x, 0);
            transform.Translate(0, 0, z);
        }
    }
}
