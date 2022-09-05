using System;

namespace Pat;

/*
Se creo esta clase con el proposito de que se pueda agregar los datos que sean deseados sobre el paciente.
*/
public class Patient
{
    public string Name { get; set; }

    public Patient(string name)
    {
        this.Name = name;
    }
}

