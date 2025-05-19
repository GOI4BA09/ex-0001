using UnityEngine;

public class sonaTeste : MonoBehaviour
{
    private int A;
    private int B;
    private int C;
    void Start()
    {
        A = 23;
        B = 18;
        //C = A + B;
        C = Soma(A, B);
        Debug.Log(C);
    }

    int Soma(int a, int b)
    {
        return a + b;
    }
    // Update is called once per frame
    void Update()
    {
    }
}
