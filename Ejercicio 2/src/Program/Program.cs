using System;
using Library;
using Doc;
using Pat;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Doctor doctor1 = new Doctor("Armand");
            Patient paciente1 = new Patient("Steven Jhonson");

            AppointmentService appointment1 = new AppointmentService(paciente1, "986782342", "5555-555-555", DateTime.Now, "Wall Street", doctor1);



            Doctor doctor2 = new Doctor("");
            Patient paciente2 = new Patient("Ralf Manson");

            AppointmentService appointment2 = new AppointmentService(paciente2, "", "5555-555-555", DateTime.Now, "Queen Street", doctor2);




            // Codigo Anterior.
            /*
            string appointmentResult = AppointmentService.CreateAppointment("Steven Jhonson", "986782342", "5555-555-555", DateTime.Now, "Wall Street", "Armand");
            Console.WriteLine(appointmentResult);

            string appointmentResult2 = AppointmentService.CreateAppointment("Ralf Manson", "", "5555-555-555", DateTime.Now, "Queen Street", "");
            Console.WriteLine(appointmentResult2);
            */
        }
    }
}
