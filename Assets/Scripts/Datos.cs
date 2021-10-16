using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Datos : MonoBehaviour
{
    public TextMeshProUGUI nombre_Lab;
    public TextMeshProUGUI descripcion_Lab;
    List<Pisos> Pisos = new List<Pisos>();
    public string NroPiso;
    public string NombreLab;
    
    public void DataTotal(string piso, string nombrelab)
    {
        Pisos.Add(
            new Pisos(
                "Sotano 3",
                "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's"+
                "standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to"+
                "make a type specimen book.It has survived not only five centuries, but also the leap into electronic typesetting,"+
                "remaining essentially unchanged.It was popularised in the 1960s with the release of Letraset sheets containing"+
                "Lorem Ipsum passages, and more recently with desktop publishing  software like Aldus PageMaker including"+
                "versions of Lorem Ipsum.w", 
                "Laboratorio de Destilacion",
                ""));
        Pisos.Add(
            new Pisos(
                "Sotano 3",
                "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's" +
                "standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to" +
                "make a type specimen book.It has survived not only five centuries, but also the leap into electronic typesetting," +
                "remaining essentially unchanged.It was popularised in the 1960s with the release of Letraset sheets containing" +
                "Lorem Ipsum passages, and more recently with desktop publishing  software like Aldus PageMaker including" +
                "versions of Lorem Ipsum.w",
                "Laboratorio de Procesos Industriales",
                ""));
        Pisos.Add(
            new Pisos(
                "Sotano 3",
                "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's" +
                "standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to" +
                "make a type specimen book.It has survived not only five centuries, but also the leap into electronic typesetting," +
                "remaining essentially unchanged.It was popularised in the 1960s with the release of Letraset sheets containing" +
                "Lorem Ipsum passages, and more recently with desktop publishing  software like Aldus PageMaker including" +
                "versions of Lorem Ipsum.w",
                "Laboratorio de Energias Alternativas",
                ""));
        Pisos.Add(
            new Pisos(
                "Sotano 3",
                "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's" +
                "standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to" +
                "make a type specimen book.It has survived not only five centuries, but also the leap into electronic typesetting," +
                "remaining essentially unchanged.It was popularised in the 1960s with the release of Letraset sheets containing" +
                "Lorem Ipsum passages, and more recently with desktop publishing  software like Aldus PageMaker including" +
                "versions of Lorem Ipsum.w",
                "Laboratorio de Suelos, Hidraulica, Estructuras y Topografia",
                ""));
    }
}
class Pisos
{
    string nro_piso;
    string descripcion1;
    string nombreLab;
    string descripcionLab;

    public Pisos(string nro_piso, string descripcion1, string nombreLab, string descripcionLab)
    {
        this.nro_piso = nro_piso;
        this.descripcion1 = descripcion1;
        this.nombreLab = nombreLab;
        this.descripcionLab = descripcionLab;
    }
}



