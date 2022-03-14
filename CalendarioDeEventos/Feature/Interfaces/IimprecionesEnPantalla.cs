using System;

namespace CalendarioDeEventos.Feature.Interfaces
{
    internal interface IImprecionesEnPantalla
    {
        void ImprecionesAPantalla(string[] NombreEventos, DateTime[] FechasEventos);
    }
}
