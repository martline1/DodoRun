using UnityEngine;

public class piso : MonoBehaviour
{
    public GameObject cuadroPiso;
    Vector3 puntoAparecer;

    public void aparecerCuadro()
    {
        GameObject temp = Instantiate(cuadroPiso, puntoAparecer, Quaternion.identity);
        puntoAparecer = temp.transform.GetChild(1).transform.position;
    }
    void Start()
    {
        for(int i = 0; i < 15; i++)
        {
            aparecerCuadro();
        }
        
        
    }

    
}
