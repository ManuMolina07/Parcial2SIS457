using CadParcial2Mmc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClnParcial2Mmc
{
    public class HorarioProgramaCln
    {
        public static int crear(HorarioPrograma horario)
        {
            using (var context = new Parcial2MmcEntities())
            {
                var existe = context.HorarioPrograma
                    .Where(x => x.titulo == horario.titulo &&
                                x.idCanal == horario.idCanal &&
                                x.diaSemana == horario.diaSemana &&
                                x.horaInicio == horario.horaInicio)
                    .FirstOrDefault();

                if (existe != null)
                    throw new Exception($"El programa {horario.titulo} ya existe");

                context.HorarioPrograma.Add(horario);
                context.SaveChanges();

                return horario.id;
            }
        }

        public static int actualizar(HorarioPrograma horario)
        {
            using (var context = new Parcial2MmcEntities())
            {
                var existe = context.HorarioPrograma.Find(horario.id);

                if (existe == null)
                    throw new Exception($"El programa con id {horario.id} no existe");

                existe.idCanal = horario.idCanal;
                existe.titulo = horario.titulo;
                existe.horaInicio = horario.horaInicio;
                existe.horaFin = horario.horaFin;
                existe.diaSemana = horario.diaSemana;
                existe.conductorPrincipal = horario.conductorPrincipal;
                existe.usuarioRegistro = "admin";

                return context.SaveChanges();
            }
        }

        public static int eliminar(int id, string usuario)
        {
            using (var context = new Parcial2MmcEntities())
            {
                var existe = context.HorarioPrograma.Find(id);

                if (existe == null)
                    throw new Exception($"El programa con id {id} no existe");

                existe.estado = -1;
                existe.usuarioRegistro = usuario;

                return context.SaveChanges();
            }
        }

        public static HorarioPrograma obtenerUno(int id)
        {
            using (var context = new Parcial2MmcEntities())
            {
                var horario = context.HorarioPrograma.Find(id);

                if (horario == null)
                    throw new Exception($"El programa con id {id} no existe");

                return horario;
            }
        }

        public static List<HorarioPrograma> listar()
        {
            using (var context = new Parcial2MmcEntities())
            {
                return context.HorarioPrograma
                    .Where(x => x.estado == 1)
                    .OrderBy(x => x.titulo)
                    .ToList();
            }
        }

        public static List<paHorarioProgramaListar_Result> listarPa(string parametro)
        {
            using (var context = new Parcial2MmcEntities())
            {
                return context.paHorarioProgramaListar(parametro.Trim()).ToList();
            }
        }
    }
}