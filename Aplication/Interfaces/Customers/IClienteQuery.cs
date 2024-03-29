﻿using Domain.Dtos;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IClienteQuery
    {
        Task<ClienteDto> FindByDni(string dni);
        Task<bool> FindById(int id);
    }
}
