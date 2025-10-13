using UnityEngine;

public class HelloWorld : MonoBehaviour
{

    //Zona de variables globales

    /*
    public int IntegerNumber = 0; otra persona puede acceder a este dato.
    private int _privateNumber = 1;
    [SerializeField] sirve para que aparezca este número privado en el inspector. 
    private int _case = 5;
    ámbito = encapsulamiento
    */

    public int IntegerNumber = -35;
    public float StudentGrade = 8.5f;
    public string StudentName = "Alarico";
    public bool IsAnActiveStudent = true;
    public char Password = '*';
    public long BigNumber = 12345679987654321;
    public double BigStudentGrade = 8.555555555d;
    public byte LittleNumber = 255;
    public byte ExampleAdd = 134;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        IntegerNumber = 5 + 8 - ((9 * 8) / 7);
        LittleNumber = 2 % 1; // LittleNumber = 0 (es el módulo)
        LittleNumber = 3 % 2; // LittleNumber = 1 (es el módulo)
        //Imprimir en consola --> imprime el último valor

        //Debug.Log("El resultado de la operación de módulo es: "LittleNumber);
        Debug.Log(LittleNumber + 1234); //Concatenar
        Debug.Log("El número más \"pequeño\" del mundo es: " + LittleNumber);
    }

    // Update is called once per frame
    void Update()
    {
        StudentGrade = StudentGrade + 1; //StudentGrade++; StudentGrade+1;
        LittleNumber = 254;
        //Va a imprimir en cada fotograma el valor 254
        Debug.Log(LittleNumber);
    }
}
