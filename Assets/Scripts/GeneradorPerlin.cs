using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorPerlin : MonoBehaviour
{

    public GameObject pieza;
    public int ancho;
    public int largo;
    public float escala;
    public int alturaMax;
    private GameObject[,] mapa;

    // Start is called before the first frame update
    void Start()
    {
        float semilla = Random.Range(0.0f, 100.0f);
        mapa = new GameObject[ancho, largo];

        for (int i = 0; i < ancho; i++) {

            for (int j = 0; j < largo; j++) {

                float coorX = semilla + i / escala;
                float coorZ = semilla + j / escala;

                int y = (int) (Mathf.PerlinNoise(coorX, coorZ) * alturaMax);

                //GameObject p = Instantiate(pieza, new Vector3(i,y,j), Quaternion.identity);

                if (y <= 30)
                {
					mapa[i,j] = Instantiate(pieza, new Vector3(i, 0, j), Quaternion.identity);
					//p.GetComponent<Renderer>().material.color = new Color32(255, 255, 255, 255);
                }


            }
        }

        
    }

    
}
