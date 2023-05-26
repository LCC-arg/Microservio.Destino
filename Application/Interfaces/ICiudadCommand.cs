﻿using Application.Request.Ciudad;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface ICiudadCommand
    {
        Ciudad InsertCiudad(Ciudad ciudad);
        Ciudad UpdateCiudad(int ciudadId, CiudadRequest request);
        Ciudad RemoveCiudad(int ciudadId);
    }
}
