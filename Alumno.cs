using System;

namespace CursoDemo4
{
    public class Alumno
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private DateTime fechaNacimiento;
        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }
        private string nombre;
        public void SetNombre(string _nombre)
        {
            nombre =_nombre;
        }
        public string GetNombre()
        {
            return this.nombre;
        }
        
        public void ObtenerCumpleaños()
        {

        }
        public string DefinirMes(int mes)
        {
            return (mes.ToString());
        }
        
    }
}