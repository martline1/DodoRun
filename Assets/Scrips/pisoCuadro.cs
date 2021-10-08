
using UnityEngine;

public class pisoCuadro : MonoBehaviour
{
    piso aparecerPiso;
    void Start()
    {
        aparecerPiso = GameObject.FindObjectOfType<piso>();
    }

    private void OnTriggerExit(Collider other)
    {
        aparecerPiso.aparecerCuadro();
        Destroy(gameObject, 2);
    }
    void Update()
    {
        
    }
}
