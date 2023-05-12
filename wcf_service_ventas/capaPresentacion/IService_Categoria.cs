﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace capaPresentacion
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServiceCategoria" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService_Categoria
    {
        [OperationContract]
        DataTable Mostrar();

        [OperationContract]
        DataTable BuscarNombre(string textobuscar);
    }
}
