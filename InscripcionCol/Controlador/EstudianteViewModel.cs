using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InscripcionCol.Controlador
{
    public class EstudianteViewModel
    {
        public int Id_Estudiante { get; set; }
        public Int64 Codigo_Rude { get; set; }
        public int Ci_E { get; set; }
        public string Ap_Paterno_E { get; set; }
        public string Ap_Materno_E { get; set; }
        public string Nombre_E { get; set; }
        public string Sexo { get; set; }
        public DateTime fecha_Nacimiento { get; set; }
        public int Grado { get; set; }
        public string Paralelo { get; set; }
        public int Ci_T { get; set; }
        public string Ap_Paterno_T { get; set; }
        public string Ap_Materno_T { get; set; }
        public string Nombre_T { get; set; }
        public int Telefono_Fijo { get; set; }
        public int Celular { get; set; }   
        //tienen que estar ocultos estos atributos en el controlador
        public string Complemento {  get; set; }
        public string Expedido {  get; set; }
        public string Pais {  get; set; }
        public string Departamento { get; set; }
        public string Provincia { get; set; }
        public string Localidad { get; set; }
        public string sexo {  get; set; }
        public string NumeroViviendaActual {  get; set; }
        public string DepartamentoActual { get; set; }
        public string ProvinciaActual { get; set; }
        public string MunicipioActual { get; set; }
        public string LocalidadActual { get; set; }
        public string ZonaActual { get; set; }
        public string AvenidaActual { get; set; }
        public string ComplementoTutor {  get; set; }
        public string ExpedidoTutor { get; set; }
        public string DepartamentoComprobante { get; set; }
        public DateTime FechaRegistroComprobante { get; set; }
    }
}
