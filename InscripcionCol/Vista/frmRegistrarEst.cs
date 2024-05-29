using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InscripcionCol.Modelo;
using InscripcionCol.Controlador;
using InscripcionCol.Vista;
using System.Data.Entity.Migrations;
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace InscripcionCol
{
    public partial class frmRegistrarEst : Form
    {
        private readonly RegistroColegioDBEntities _db = new RegistroColegioDBEntities();
        private readonly EstudianteController _estudianteController;
        private readonly frmestudiante _frmestudiante;
        private EstudianteViewModel _estudianteSeleccionado;
        public frmRegistrarEst(frmestudiante frmEstudiante, EstudianteController estudianteController)
        {
            InitializeComponent();
            _frmestudiante = frmEstudiante;
            _estudianteController = estudianteController;
        }
        public frmRegistrarEst(frmestudiante frmEstudiante, EstudianteViewModel estudianteSeleccionado, EstudianteController estudianteController) : this(frmEstudiante, estudianteController)
        {
            _estudianteSeleccionado = estudianteSeleccionado;
            CargarDatosEstudianteSeleccionado();
        }
        private void CargarDatosEstudianteSeleccionado()
        {
            if (_estudianteSeleccionado != null)
            {
                txt_appaterno.Text = _estudianteSeleccionado.Ap_Paterno_E;
                txt_apmaterno.Text = _estudianteSeleccionado.Ap_Materno_E;
                txt_nombre.Text = _estudianteSeleccionado.Nombre_E;
                txt_ci.Text = _estudianteSeleccionado.Ci_E.ToString();
                txt_compl.Text = _estudianteSeleccionado.Complemento;
                txt_exp.Text = _estudianteSeleccionado.Expedido;
                txt_rude.Text = _estudianteSeleccionado.Codigo_Rude;
                if (_estudianteSeleccionado.Sexo == "M")
                {
                    rbtmasculino.Checked = true;
                }
                else 
                {
                    rbtfemenino.Checked = true;
                }
                date_nac.Value = _estudianteSeleccionado.fecha_Nacimiento;
                cbx_escol.Text = _estudianteSeleccionado.Grado.ToString();

                txt_paisNac.Text = _estudianteSeleccionado.Pais;
                txt_provinciaNac.Text = _estudianteSeleccionado.Provincia;
                txt_dptoNac.Text = _estudianteSeleccionado.Departamento;
                txt_localidadNac.Text = _estudianteSeleccionado.Localidad;
                cbx_dptoAct.Text = _estudianteSeleccionado.DepartamentoActual;
                txt_provinciaAct.Text = _estudianteSeleccionado.ProvinciaActual;
                txt_municipioAct.Text = _estudianteSeleccionado.MunicipioActual;
                txt_localidadAct.Text = _estudianteSeleccionado.LocalidadActual;
                txt_zonaAct.Text = _estudianteSeleccionado.ZonaActual;
                txt_avenAct.Text = _estudianteSeleccionado.AvenidaActual;
                txt_num.Text = _estudianteSeleccionado.NumeroViviendaActual;
                txt_telefono.Text = _estudianteSeleccionado.Telefono_Fijo.ToString();
                txt_cel.Text = _estudianteSeleccionado.Celular.ToString();
                txt_ciTutor.Text = _estudianteSeleccionado.Ci_T.ToString();
                txt_appaternoTutor.Text = _estudianteSeleccionado.Ap_Paterno_T;
                txt_apmaternoTutor.Text = _estudianteSeleccionado.Ap_Materno_T;
                txt_nombreTutor.Text = _estudianteSeleccionado.Nombre_T;
                txt_complTutor.Text = _estudianteSeleccionado.ComplementoTutor;
                txt_expTutor.Text = _estudianteSeleccionado.ExpedidoTutor;
                txt_dptoComprob.Text = _estudianteSeleccionado.DepartamentoComprobante;
                date_regComprob.Value = _estudianteSeleccionado.FechaRegistroComprobante;
            }
        }

        TEstudiante estudiante = new TEstudiante();
        TNacimiento nacimiento = new TNacimiento();
        TDireccion direccion = new TDireccion();
        TContacto contacto = new TContacto();
        TTutor tutor = new TTutor();
        TCurso curso = new TCurso();
        TComprobante comp = new TComprobante();
        TTutor_Est tutor_Est = new TTutor_Est();
        TDir_Est dir_Est=new TDir_Est();        

        public void asignarCurso()
        {
            Random rnd = new Random();
            int minCurso, maxCurso;

            switch (estudiante.grado_sec)
            {
                case 1:
                    minCurso = 1;
                    maxCurso = 5;
                    break;
                case 2:
                    minCurso = 6;
                    maxCurso = 10;
                    break;
                case 3:
                    minCurso = 11;
                    maxCurso = 15;
                    break;
                case 4:
                    minCurso = 16;
                    maxCurso = 20;
                    break;
                case 5:
                    minCurso = 21;
                    maxCurso = 25;
                    break;
                case 6:
                    minCurso = 26;
                    maxCurso = 30;
                    break;
                default:
                    throw new InvalidOperationException("Grado no válido");
            }

            comp.id_curso = rnd.Next(minCurso, maxCurso + 1);
        }
        private async void btn_guardar_Click(object sender, EventArgs e)
        {
            if(txt_appaterno.Text==""||txt_apmaterno.Text==""||txt_nombre.Text==""||txt_ci.Text==""||txt_rude.Text==""||
                txt_exp.Text==""||txt_compl.Text==""||cbx_escol.Text==""||txt_paisNac.Text==""||txt_dptoNac.Text==""||
                txt_provinciaNac.Text==""||txt_localidadNac.Text==""||cbx_dptoAct.Text==""||txt_provinciaAct.Text==""||
                txt_municipioAct.Text==""||txt_localidadAct.Text==""||txt_zonaAct.Text==""||txt_avenAct.Text==""||
                txt_num.Text==""||txt_telefono.Text==""||txt_cel.Text==""||txt_ciTutor.Text==""||txt_appaternoTutor.Text==""||
                txt_apmaternoTutor.Text==""||txt_nombreTutor.Text==""||txt_complTutor.Text==""||txt_expTutor.Text==""||
                txt_dptoComprob.Text=="")
            { 
                MessageBox.Show("Existen campos vacios","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            try
            {                
                estudiante.ap_paterno = txt_appaterno.Text;
                estudiante.ap_materno = txt_apmaterno.Text;
                estudiante.nombre = txt_nombre.Text;
                estudiante.ci = Convert.ToInt32(txt_ci.Text);
                estudiante.complemento = txt_compl.Text;
                estudiante.expedido = txt_exp.Text;
                estudiante.codigo_rude = txt_rude.Text;
                string genero;
                if (rbtmasculino.Checked == true)
                {
                    genero = "M";
                }
                else
                {
                    genero = "F";
                }
                estudiante.sexo = genero;
                estudiante.fec_nacimiento = date_nac.Value.Date;
                estudiante.grado_sec=Convert.ToInt32(cbx_escol.Text);
                bool estudianteRegistrado = await _estudianteController.RegistrarEstudianteAsync(estudiante);

                if(estudianteRegistrado)
                {                                    
                    nacimiento.id_estudiante = estudiante.id_estudiante;
                    nacimiento.pais = txt_paisNac.Text;
                    nacimiento.provincia = txt_provinciaNac.Text;
                    nacimiento.dpto = txt_dptoNac.Text;
                    nacimiento.localidad = txt_localidadNac.Text;
                    await _estudianteController.RegistrarNacimientoAsync(nacimiento);
                                        
                    direccion.dpto = cbx_dptoAct.Text;
                    direccion.provincia = txt_provinciaAct.Text;
                    direccion.municipio = txt_municipioAct.Text;
                    direccion.localidad = txt_localidadAct.Text;
                    direccion.zona=txt_zonaAct.Text;
                    direccion.avenida=txt_avenAct.Text;
                    direccion.nro_vivienda = txt_num.Text;
                    await _estudianteController.RegistrarDireccionAsync(direccion);

                    dir_Est.id_estudiante = estudiante.id_estudiante;
                    dir_Est.id_direccion = direccion.id_direccion;
                    await _estudianteController.RegistrarDir_EstAsync(dir_Est);

                    contacto.id_direccion=direccion.id_direccion;
                    contacto.telefono_fijo = Convert.ToInt32(txt_telefono.Text);
                    contacto.celular = Convert.ToInt32(txt_cel.Text);
                    await _estudianteController.RegistrarContactoAsync(contacto);

                    tutor.ci = Convert.ToInt32(txt_ciTutor.Text);
                    tutor.complemento = txt_complTutor.Text;
                    tutor.expedido = txt_expTutor.Text;
                    tutor.ap_paterno = txt_appaternoTutor.Text;
                    tutor.ap_materno = txt_apmaternoTutor.Text;
                    tutor.nombre = txt_nombreTutor.Text;
                    await _estudianteController.RegistrarTutorAsync(tutor);

                    tutor_Est.id_estudiante=estudiante.id_estudiante;
                    tutor_Est.id_tutor=tutor.id_tutor;
                    await _estudianteController.RegistrarTutor_EstAsync(tutor_Est);

                    comp.id_estudiante = estudiante.id_estudiante;
                    comp.id_tutor=tutor.id_tutor;
                    comp.lugar_dpto = txt_dptoComprob.Text;
                    comp.fecha_reg = date_regComprob.Value.Date;
                    asignarCurso();
                    await _estudianteController.RegistrarComprobanteAsync(comp);

                    MessageBox.Show("Se ha registrado el estudiante con exito","INFORMACIÓN",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    _frmestudiante.cargar();
                }
                else
                {
                    MessageBox.Show("Error al registrar el estudiante", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public TextBox txtci => txt_ci;
        public TextBox txtrude=>txt_rude;
        public TextBox txtapPaterno => txt_appaterno;
        public TextBox txtnombre => txt_nombre;
        public ComboBox txtgrado => cbx_escol;

        private void frmRegistrarEst_Load(object sender, EventArgs e)
        {

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            if (txt_appaterno.Text == "" || txt_apmaterno.Text == "" || txt_nombre.Text == "" || txt_ci.Text == "" || txt_rude.Text == "" ||
        txt_exp.Text == "" || txt_compl.Text == "" || cbx_escol.Text == "" || txt_paisNac.Text == "" || txt_dptoNac.Text == "" ||
        txt_provinciaNac.Text == "" || txt_localidadNac.Text == "" || cbx_dptoAct.Text == "" || txt_provinciaAct.Text == "" ||
        txt_municipioAct.Text == "" || txt_localidadAct.Text == "" || txt_zonaAct.Text == "" || txt_avenAct.Text == "" ||
        txt_num.Text == "" || txt_telefono.Text == "" || txt_cel.Text == "" || txt_ciTutor.Text == "" || txt_appaternoTutor.Text == "" ||
        txt_apmaternoTutor.Text == "" || txt_nombreTutor.Text == "" || txt_complTutor.Text == "" || txt_expTutor.Text == "" ||
        txt_dptoComprob.Text == "")
            {
                MessageBox.Show("Existen campos vacios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Obtener la entidad estudiante desde la base de datos
                var estudianteExistente = _db.TEstudiante.Find(_estudianteSeleccionado.Id_Estudiante);
                if (estudianteExistente == null)
                {
                    MessageBox.Show("El estudiante no existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Actualizar los datos del estudiante
                estudianteExistente.ap_paterno = txt_appaterno.Text;
                estudianteExistente.ap_materno = txt_apmaterno.Text;
                estudianteExistente.nombre = txt_nombre.Text;
                estudianteExistente.ci = Convert.ToInt32(txt_ci.Text);
                estudianteExistente.complemento = txt_compl.Text;
                estudianteExistente.expedido = txt_exp.Text;
                estudianteExistente.codigo_rude = txt_rude.Text;
                estudianteExistente.sexo = rbtmasculino.Checked ? "M" : "F";
                estudianteExistente.fec_nacimiento = date_nac.Value.Date;
                estudianteExistente.grado_sec = Convert.ToInt32(cbx_escol.Text);

                // Modificar el estudiante
                bool estudianteModificado = await _estudianteController.ModificarEstudianteAsync(estudianteExistente);

                if (estudianteModificado)
                {
                    // Obtener y modificar nacimiento
                    var nacimientoExistente = _db.TNacimiento.FirstOrDefault(n => n.id_estudiante == estudianteExistente.id_estudiante);
                    if (nacimientoExistente != null)
                    {
                        nacimientoExistente.pais = txt_paisNac.Text;
                        nacimientoExistente.provincia = txt_provinciaNac.Text;
                        nacimientoExistente.dpto = txt_dptoNac.Text;
                        nacimientoExistente.localidad = txt_localidadNac.Text;
                        await _estudianteController.ModificarNacimientoAsync(nacimientoExistente);
                    }

                    // Obtener y modificar dirección
                    var dirEstExistente = _db.TDir_Est.FirstOrDefault(de => de.id_estudiante == estudianteExistente.id_estudiante);
                    if (dirEstExistente != null)
                    {
                        var direccionExistente = _db.TDireccion.Find(dirEstExistente.id_direccion);
                        if (direccionExistente != null)
                        {
                            direccionExistente.dpto = cbx_dptoAct.Text;
                            direccionExistente.provincia = txt_provinciaAct.Text;
                            direccionExistente.municipio = txt_municipioAct.Text;
                            direccionExistente.localidad = txt_localidadAct.Text;
                            direccionExistente.zona = txt_zonaAct.Text;
                            direccionExistente.avenida = txt_avenAct.Text;
                            direccionExistente.nro_vivienda = txt_num.Text;
                            await _estudianteController.ModificarDireccionAsync(direccionExistente);
                        }

                        // Obtener y modificar contacto
                        var contactoExistente = _db.TContacto.FirstOrDefault(c => c.id_direccion == direccionExistente.id_direccion);
                        if (contactoExistente != null)
                        {
                            contactoExistente.telefono_fijo = Convert.ToInt32(txt_telefono.Text);
                            contactoExistente.celular = Convert.ToInt32(txt_cel.Text);
                            await _estudianteController.ModificarContactoAsync(contactoExistente);
                        }
                    }

                    // Obtener y modificar tutor
                    var tutorEstExistente=_db.TTutor_Est.FirstOrDefault(te=>te.id_estudiante==estudianteExistente.id_estudiante);
                    if (tutorEstExistente != null)
                    { 
                        var tutorExistente = _db.TTutor.Find(tutorEstExistente.id_tutor);
                        if (tutorExistente != null)
                        {
                            tutorExistente.ci = Convert.ToInt32(txt_ciTutor.Text);
                            tutorExistente.complemento = txt_complTutor.Text;
                            tutorExistente.expedido = txt_expTutor.Text;
                            tutorExistente.ap_paterno = txt_appaternoTutor.Text;
                            tutorExistente.ap_materno = txt_apmaternoTutor.Text;
                            tutorExistente.nombre = txt_nombreTutor.Text;
                            await _estudianteController.ModificarTutorAsync(tutorExistente);
                        }
                    }
                    // Obtener y modificar comprobante
                    var comprobanteExistente = _db.TComprobante.FirstOrDefault(c => c.id_estudiante == estudianteExistente.id_estudiante);
                    if (comprobanteExistente != null)
                    {
                        comprobanteExistente.lugar_dpto = txt_dptoComprob.Text;
                        comprobanteExistente.fecha_reg = date_regComprob.Value.Date;
                        await _estudianteController.ModificarComprobanteAsync(comprobanteExistente);
                    }

                    MessageBox.Show("Estudiante modificado con éxito", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _frmestudiante.cargar();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al modificar el estudiante", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        
    }
}
