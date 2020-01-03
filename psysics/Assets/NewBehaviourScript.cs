using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Required when Using UI elements.

public class NewBehaviourScript : MonoBehaviour
{
    float m = 10f;
    float k = 0.47f;
    float gx = 0f;
    float gy = -10f;
    float gz = 0f;
    float x0 = 0f;
    float y0 = 0f;
    float z0 = 0f;
    float v0x = 10f;
    float v0y = 10f;
    float v0z = 0f;
    float dt = 0.1f;
    float tmax = 10f;
    // Start is called before the first frame update
    void draw(float t, Color c, float size) {
        float x = xt(t);
        float y = yt(t);
        float z = zt(t);
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.position = new Vector3(x, y, z);
        sphere.transform.localScale -= new Vector3(1 - size, 1 - size, 1 - size);
        var sphereRenderer = sphere.GetComponent<Renderer>();
        
        sphereRenderer.material.SetColor("_Color", c);
    }



    float xt(float t)
    {
        return x0 + m / k * ((v0x - m * gx / k) * (1 - Mathf.Exp(-k / m * t)) + gx * t);
    }

    float yt(float t)
    {
        return y0 + m / k * ((v0y - m * gy / k) * (1 - Mathf.Exp(-k / m * t)) + gy * t);
    }

    float zt(float t)
    {
        
        return z0 + m / k * ((v0z - m * gz / k) * (1 - Mathf.Exp(-k / m * t)) + gz * t);
    }

    float vxt(float t)
    {
        return v0x * Mathf.Exp(-k / m * t) - gx * m / k * (1 - Mathf.Exp(-k / m * t));
    }

    float vyt(float t)
    {
        return v0y * Mathf.Exp(-k / m * t) + gy * m / k * (1 - Mathf.Exp(-k / m * t));
    }

    float vyz(float t)
    {
        return v0z * Mathf.Exp(-k / m * t) + gz * m / k * (1 - Mathf.Exp(-k / m * t));
    }

    public Slider mainSlider;
    public GameObject bullet;


    public void ValueChangeCheck()
    {
        float t = mainSlider.value;
        float x = xt(t);
        float y = yt(t);
        float z = zt(t);
        bullet.transform.position = new Vector3(x, y, z);
    }

    void Start()
    {
        mainSlider.onValueChanged.AddListener(delegate { ValueChangeCheck(); });
        float width, height, multi;
        multi = 5;
        width = (float)(Screen.width*0.8) / 5;
        height = 20;
        mainSlider.GetComponent< RectTransform>().sizeDelta = new Vector2(width, height);
        mainSlider.transform.localScale = new Vector3(multi, multi, 1);
        float size = 1f;
        int N = 20;
        for (float t = 0; t <= tmax; t+=dt) {
            draw(t, Color.red, size);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
