using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeQueOrientacionSos : MonoBehaviour
{
    public string nombreAlumno;
    public int añoAlumno;
    public string orientacionAlumno;

    // Start is called before the first frame update
    void Start()
    {
        //nombre
        if (nombreAlumno == "")
        {
            Debug.Log("Error");
        }
        //año
        if (añoAlumno > 5 || añoAlumno < 1)
        {
            Debug.Log("Error");
            return;
        }

        if (añoAlumno < 3)
        {
            Debug.Log("Error. Aún estás en el ciclo básico");
            return;
        }
      
        //orientacion
        if (orientacionAlumno != "T" && orientacionAlumno != "D" && orientacionAlumno != "G" && orientacionAlumno != "M" && orientacionAlumno != "H")
        {
            Debug.Log("Solo puede ingresar T, D, G, M o H");
            return;
        }

        Debug.Log("Muchas gracias " + nombreAlumno + "!");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
