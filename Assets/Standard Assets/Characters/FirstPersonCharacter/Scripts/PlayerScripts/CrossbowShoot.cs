using UnityEngine;



    public class CrossbowShoot : MonoBehaviour
    {
        public GameObject arrowPrefab;
        public Transform arrowLocation;

        public float shotPower = 100f;

        public SaveScript ss;

        void Start()
        {
            if (arrowLocation == null)
                arrowLocation = transform;
        }

        void Update()
        {
            if(Input.GetButtonDown("Fire1"))
            {
                if (ss.Arr > 0)
                {
                    Instantiate(arrowPrefab, arrowLocation.position, arrowLocation.rotation).GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * shotPower);
                }
            }
        }
    }

