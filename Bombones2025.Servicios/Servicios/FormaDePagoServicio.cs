using Bombones2025.DatosSql.Repositorios;
using Bombones2025.Entidades.Entidades;
using Bombones2025.Utilidades;

namespace Bombones2025.Servicios.Servicios
{
    public class FormaDePagoServicio
    {
        private readonly FormaDePagoRepositorio _formaDePagoRepositorio = null!;

        public FormaDePagoServicio() 
        {
            try
            {
                _formaDePagoRepositorio = new FormaDePagoRepositorio(ConstantesDelSistema.umbralCache);

            }
            catch (Exception ex)
            {

                throw new Exception("Error al crear FormaDePagoRepositorio", ex);
            }
        }

        public List<FormaDePago> GetLista()
        {
            return _formaDePagoRepositorio.GetLista();
        }

        public void Guardar(FormaDePago formaDePago)
        {
            if (formaDePago.FormaDePagoId == 0)
            {
                _formaDePagoRepositorio.Agregar(formaDePago);

            }
            else
            {
                _formaDePagoRepositorio.Editar(formaDePago);
            }
        }

        public bool Existe(FormaDePago formaDePago)
        {
            return _formaDePagoRepositorio.Existe(formaDePago);
        }

        public void Borrar(int formaDePagoId)
        {
            _formaDePagoRepositorio.Borrar(formaDePagoId);
        }

        public List<FormaDePago> Filtrar(string textoParaFiltrar)
        {
            return _formaDePagoRepositorio.Filtrar(textoParaFiltrar);
        }
    }
}
