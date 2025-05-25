using Bombones2025.Entidades.Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Bombones2025.DatosSql.Repositorios
{
    public class FormaDePagoRepositorio
    {
        private readonly bool _usarCache;
        private List<FormaDePago> _formasDePago = new();
        private readonly string? _connectionString;
        public FormaDePagoRepositorio(int umbralCache = 30)
        {
            _connectionString = ConfigurationManager
                    .ConnectionStrings["MiConexion"].ToString();
            var cantidadRegistros = ObtenerCantidadRegistros();
            _usarCache = cantidadRegistros <= umbralCache;
            if (_usarCache)
            {
                LeerDatos();

            }
        }

        private int ObtenerCantidadRegistros()
        {
            using (var cnn = new SqlConnection(_connectionString))
            {
                cnn.Open();
                string query = @"SELECT COUNT(*) FROM FormasDePago";
                using (var cmd = new SqlCommand(query, cnn))
                {
                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        private void LeerDatos()
        {
            try
            {
                using (var cnn = new SqlConnection(_connectionString))
                {
                    cnn.Open();
                    string query = "SELECT FormaDePagoId, Descripcion FROM FormasDePago";
                    using (var cmd = new SqlCommand(query, cnn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                FormaDePago formaDePago = ConstruirFormaDePago(reader);
                                _formasDePago.Add(formaDePago);
                            }
                        }
                    }

                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public List<FormaDePago> GetLista()
        {
            if (_usarCache)
            {
                return _formasDePago.OrderBy(p => p.Descripcion).ToList();
            }
            List<FormaDePago> lista = new List<FormaDePago>();
            using (var cnn = new SqlConnection(_connectionString))
            {
                cnn.Open();
                var query = "SELECT FormaDePagoId, Descripcion FROM FormasDePago ORDER BY Descipcion";
                using (var cmd = new SqlCommand(query, cnn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            FormaDePago p = ConstruirFormaDePago(reader);
                            lista.Add(p);
                        }
                    }
                }
            }
            return lista;
        }

        private FormaDePago ConstruirFormaDePago(SqlDataReader reader)
        {
            return new FormaDePago
            {
                FormaDePagoId=reader.GetInt32(0),
                Descripcion=reader.GetString(1)
            };
        }
        public void Agregar(FormaDePago formaDePago)
        {
            try
            {
                using (var cnn = new SqlConnection(_connectionString))
                {
                    cnn.Open();
                    string query = @"INSERT INTO FormasDePago (Descripcion)
                    VALUES(@Descripcion); SELECT SCOPE_IDENTITY();";
                    using (var cmd = new SqlCommand(query, cnn))
                    {
                        cmd.Parameters.AddWithValue("@Descripcion", formaDePago.Descripcion);
                        int formaDePagoId = (int)(decimal)cmd.ExecuteScalar();
                        formaDePago.FormaDePagoId = formaDePagoId;

                    }
                }
                if (_usarCache)
                {
                    _formasDePago.Add(formaDePago);

                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public bool Existe(FormaDePago formaDePago)
        {
            if (_usarCache)
            {
                return formaDePago.FormaDePagoId == 0 ? _formasDePago.Any(p => p.Descripcion == formaDePago.Descripcion)
                    : _formasDePago.Any(p => p.Descripcion == formaDePago.Descripcion
                        && p.FormaDePagoId != formaDePago.FormaDePagoId);
            }
            try
            {
                using (var cnn = new SqlConnection(_connectionString))
                {
                    cnn.Open();
                    string query;
                    if (formaDePago.FormaDePagoId == 0)
                    {
                        query = @"SELECT COUNT(*) FROM FormasDePago 
                            WHERE LOWER(Descripcion)=LOWER(@Descripcion)";

                    }
                    else
                    {
                        query = @"SELECT COUNT(*) FROM FormasDePago 
                            WHERE LOWER(Descripcion)=LOWER(@Descripcion) AND 
                                FormaDePagoId<>@FormaDePagoId";
                    }
                    using (var cmd = new SqlCommand(query, cnn))
                    {
                        if (formaDePago.FormaDePagoId != 0)
                        {
                            cmd.Parameters.AddWithValue("@FormaDePagoId", formaDePago.FormaDePagoId);
                        }
                        cmd.Parameters.AddWithValue("@Descripcion", formaDePago.Descripcion);
                        int cantidad = (int)cmd.ExecuteScalar();
                        return cantidad > 0;
                    }
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public void Borrar(int formaDePagoId)
        {
            try
            {
                using (var cnn = new SqlConnection(_connectionString))
                {
                    cnn.Open();
                    string query = @"DELETE FROM FormasDePago WHERE FormaDePagoId=@FormaDePagoId";
                    using (var cmd = new SqlCommand(query, cnn))
                    {
                        cmd.Parameters.AddWithValue("@FormaDePagoId", formaDePagoId);
                        cmd.ExecuteNonQuery();
                    }
                }
                if (_usarCache)
                {
                    FormaDePago? formaDePagoBorrar = _formasDePago.FirstOrDefault(p => p.FormaDePagoId == formaDePagoId);
                    if (formaDePagoBorrar == null) return;
                    _formasDePago.Remove(formaDePagoBorrar);

                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error al intentar borrar el registro", ex);
            }
        }

        public void Editar(FormaDePago formaDePago)
        {
            try
            {
                using (var cnn = new SqlConnection(_connectionString))
                {
                    cnn.Open();
                    var query = @"UPDATE FormasDePago SET Descripcion=@Descripcion
                               WHERE FormaDePagoId=@FormaDePagoId";
                    using (var cmd = new SqlCommand(query, cnn))
                    {
                        cmd.Parameters.AddWithValue("@Descripcion", formaDePago.Descripcion);
                        cmd.Parameters.AddWithValue("@FormaDePagoId", formaDePago.FormaDePagoId);
                        cmd.ExecuteNonQuery();
                    }
                    if (_usarCache)
                    {
                        FormaDePago? formaDePagoEditar = _formasDePago.FirstOrDefault(p => p.FormaDePagoId == formaDePago.FormaDePagoId);
                        if (formaDePagoEditar == null) return;
                        formaDePagoEditar.Descripcion = formaDePago.Descripcion;

                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error al intentar editar el registro", ex);
            }
        }

        public List<FormaDePago> Filtrar(string textoParaFiltrar)
        {
            if (_usarCache)
            {
                return _formasDePago
                    .Where(p => p.Descripcion
                        .StartsWith(textoParaFiltrar)).ToList();
            }
            var listaFiltrada = new List<FormaDePago>();

            try
            {
                using (var cnn = new SqlConnection(_connectionString))
                {
                    cnn.Open();
                    var query = @"select * from FormaDePagoes WHERE Descripcion LIKE @texto";
                    using (var cmd = new SqlCommand(query, cnn))
                    {
                        textoParaFiltrar += "%";
                        cmd.Parameters.AddWithValue("@texto", textoParaFiltrar);
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var formaDePago = ConstruirFormaDePago(reader);
                                listaFiltrada.Add(formaDePago);
                            }
                        }
                    }
                }
                return listaFiltrada;

            }
            catch (Exception ex)
            {

                throw new Exception("Error al intentar filtrar las Formas De Pago", ex);
            }
        }
    }
}
