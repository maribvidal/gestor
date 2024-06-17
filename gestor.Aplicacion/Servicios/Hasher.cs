using System;
using System.Security.Cryptography;
using System.Text;
using gestor.Aplicacion.Entidades;
using gestor.Aplicacion.Interfaces;

namespace gestor.Aplicacion.Servicios;

public class Hasher : IHasher
{
    public string ObtenerHash(string contraseña)
    {
        //NOTA: El algoritmo SHA256 no es recomendado para hashear contraseñas en la actualidad
        var contraBytes = Encoding.UTF8.GetBytes(contraseña);
        var contraHash = SHA256.HashData(contraBytes);
        return Convert.ToHexString(contraHash);
    }
}