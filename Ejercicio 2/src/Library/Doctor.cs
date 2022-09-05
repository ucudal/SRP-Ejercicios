using System;

namespace Doc;

/*
Se creo esta clase con el proposito de que se pueda agregar los datos que sean deseados sobre el doctor.
*/
public class Doctor
{
    public string Name { get; set; }


    public Doctor(string Name)
    {
        this.Name = Name;
    }
}
