﻿using Proyecto_BK.DataAccess.Repository;
using Proyecto_BK.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_BK.BusinessLogic.Services
{
    public class GeneralServices
    {
        private readonly DepartamentoRepository _departamentosRepository;
      

        public GeneralServices(
               DepartamentoRepository departamentosRepository)

        {
            _departamentosRepository = departamentosRepository;
        }


        #region Departamentos
        public ServiceResult ListDepto()
        {
            var result = new ServiceResult();
            try
            {
                var list = _departamentosRepository.List();

                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error("Error de capa 8");
            }
        }
        public ServiceResult ListDepto(string Dept_Codigo)
        {
            var result = new ServiceResult();
            try
            {
                var list = _departamentosRepository.List(Dept_Codigo);

                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error("Error de capa 8");
            }
        }
        public ServiceResult CrearDepto(tbDepartamentos item)
        {
            var result = new ServiceResult();
            try
            {
                var reponse = _departamentosRepository.Insert(item);
                if (reponse.CodeStatus == 1)
                {
                    return result.Ok("Departamento creado con exito", reponse);
                }
                else
                {
                    return result.Error("Ya existe un departamento con ese codigo o con ese nombre");
                }
            }
            catch (Exception ex)
            {
                return result.Error("Error de capa 8");
            }
        }
        public ServiceResult EditarDepto(tbDepartamentos item)
        {
            var result = new ServiceResult();
            try
            {
                var reponse = _departamentosRepository.Update(item);
                if (reponse.CodeStatus == 1)
                {
                    return result.Ok($"Departamento {item.Dept_Codigo} editado con éxito", reponse);
                }
                else
                {
                    return result.Error("Ya existe un departamento con ese nombre");
                }
            }
            catch (Exception ex)
            {
                return result.Error("Error de capa 8");
            }
        }
        public ServiceResult EliminarDepto(string Dept_Codigo)
        {
            var result = new ServiceResult();
            try
            {
                var reponse = _departamentosRepository.Delete(Dept_Codigo);
                if (reponse.CodeStatus == 1)
                {
                    return result.Ok($"Departamento {Dept_Codigo} eliminado con éxito", reponse);
                }
                else
                {
                    return result.Error("No se encontró el departamento a eliminar");
                }
            }
            catch (Exception ex)
            {
                return result.Error("Error de capa 8");
            }
        }
        #endregion
    }
}
