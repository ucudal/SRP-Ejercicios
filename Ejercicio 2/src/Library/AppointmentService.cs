using System;
using System.Text;

namespace Library
{

    public class AppointmentService
    {
        public object Patient { get; set; }
        public string ID { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime Date { get; set; }
        public string AppoinmentPlace { get; set; }
        public object Doctor { get; set; }
        public bool validAppointment{get;set;}

        // Constructor.
        public AppointmentService(object patient, string id, string phoneNumber, DateTime date, string appoinmentPlace, object doctor)
        {
            this.Patient = patient;
            this.ID = id;
            this.PhoneNumber = phoneNumber;
            this.Date = date;
            this.AppoinmentPlace = appoinmentPlace;
            this.Doctor = doctor;
            this.validAppointment = ValidationAppointmentService.CreateAppointment(patient,id,phoneNumber,date,appoinmentPlace,doctor);
        }
    }


    public class ValidationAppointmentService
    {
        public static bool CreateAppointment(object patient, string id, string phoneNumber, DateTime date, string appoinmentPlace, object doctor)
        {
            // Se ha utilizado el StringBuilder para informar que información es necesaria.
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            if (patient is null)
            {
                stringBuilder.Append("Unable to schedule appointment, 'name' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(id))
            {
                stringBuilder.Append("Unable to schedule appointment, 'id' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, 'phone number' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, 'appoinment place' is required\n");
                isValid = false;
            }


            if (doctor is null)
            {
                stringBuilder.Append("Unable to schedule appointment, 'doctor name' is required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Appoinment scheduled");

            }

            Console.WriteLine(stringBuilder.ToString()+"\n"+isValid);
            return isValid;
        }

    }
}


// Codigo original del ejercicio.
/*

Para que este progrma sea funcional se deberia crear un objeto,y no un string, que contenga toda la información de forma separada para su facilacceso.
Esto facilitaria el manejo de la infromación y permite su uso para otros fines, como la impresión de la información solo del paciente o del
doctor. En base a esto se decidio que se crearian 4 clases distinas una para la creación del objeto conla información de la consulta, otra
para la validación de dicha información. y dos mas que guardarian la información del paciente y el doctor.
    

public class AppointmentService
{
    public static string CreateAppointment(string name, string id, string phoneNumber, DateTime date, string appoinmentPlace, string doctorName)
    {
        StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
        Boolean isValid = true;

        if (string.IsNullOrEmpty(name))
        {
            stringBuilder.Append("Unable to schedule appointment, 'name' is required\n");
            isValid = false;
        }

        if (string.IsNullOrEmpty(id))
        {
            stringBuilder.Append("Unable to schedule appointment, 'id' is required\n");
            isValid = false;
        }

        if (string.IsNullOrEmpty(phoneNumber))
        {
            stringBuilder.Append("Unable to schedule appointment, 'phone number' is required\n");
            isValid = false;
        }

        if (string.IsNullOrEmpty(appoinmentPlace))
        {
            stringBuilder.Append("Unable to schedule appointment, 'appoinment place' is required\n");
            isValid = false;
        }


        if (string.IsNullOrEmpty(doctorName))
        {
            stringBuilder.Append("Unable to schedule appointment, 'doctor name' is required\n");
            isValid = false;
        }

        if (isValid)
        {
            stringBuilder.Append("Appoinment scheduled");
        }

        return stringBuilder.ToString();
    }

}


*/