using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InscripcionCol.Modelo;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InscripcionCol.Controlador
{
    internal class BecaController
    {
        private readonly RegistroColegioDBEntities _db = new RegistroColegioDBEntities();
        private string connectionString = "Server=.\\SQLEXPRESS;Database=RegistroColegioDB;Integrated Security=True;";
        public void activargroupbox(GroupBox groupBox)
        {
            groupBox.Enabled = true;
        }
        public void desacGroupBox(GroupBox groupBox)
        {
            groupBox.Enabled = false;
        }
        public EstudianteViewModel BuscarEstudiantePorCI(int ci)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT id_estudiante, ap_paterno, ap_materno, nombre FROM TEstudiante WHERE ci = @ci";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ci", ci);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new EstudianteViewModel
                            {
                                Id_Estudiante = (int)reader["id_estudiante"],
                                Ap_Paterno_E = reader["ap_paterno"].ToString(),
                                Ap_Materno_E = reader["ap_materno"].ToString(),
                                Nombre_E = reader["nombre"].ToString()
                            };
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }
        public async Task<bool> RegistrarBecaAsync(BecaViewModel beca)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO TBeca (tipo, monto, fecha_ini, fecha_fin, id_estudiante) VALUES (@tipo, @monto, @fecha_ini, @fecha_fin, @id_estudiante)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@tipo", beca.Tipo);
                    command.Parameters.AddWithValue("@monto", beca.Monto);
                    command.Parameters.AddWithValue("@fecha_ini", beca.FechaIni);
                    command.Parameters.AddWithValue("@fecha_fin", beca.FechaFin);
                    command.Parameters.AddWithValue("@id_estudiante", beca.Id_Estudiante);

                    try
                    {
                        connection.Open();
                        int result = await command.ExecuteNonQueryAsync();
                        return result > 0;
                    }
                    catch (Exception)
                    {
                        // Manejar excepciones si es necesario
                        return false;
                    }
                }
            }
        }
        public List<BecaViewModel> ListarBecas()
        {
            var query = from beca in _db.TBeca
                        join estudiante in _db.TEstudiante on beca.id_estudiante equals estudiante.id_estudiante
                        select new BecaViewModel
                        {
                            Id_Estudiante = estudiante.id_estudiante,
                            CI = estudiante.ci,
                            Apellido_Paterno = estudiante.ap_paterno,
                            Apellido_Materno = estudiante.ap_materno,
                            Nombre = estudiante.nombre,
                            Tipo = beca.tipo,
                            Monto = beca.monto,
                            FechaIni = beca.fecha_ini,
                            FechaFin = beca.fecha_fin
                        };
            return query.ToList();
        }        
        public List<BecaViewModel> BuscarBeca(string param)
        {
            if (string.IsNullOrWhiteSpace(param))
            {
                return ListarBecas();
            }
            else
            {
                var becas = ListarBecas();
                return becas.Where(beca => beca.Tipo.Equals(param, StringComparison.OrdinalIgnoreCase)).ToList();
            }
        }
        public decimal ObtenerMontoPorTipo(string tipo)
        {
            switch (tipo.ToLower())
            {
                case "académica":
                    return 3000.00m;
                case "deportiva":
                    return 2500.00m;
                case "cultural":
                    return 2000.00m;
                case "socioeconomica":
                    return 3500.00m;
                case "inclusión":
                    return 3000.00m;
                default:
                    return 0.00m;
            }
        }
    }
}
