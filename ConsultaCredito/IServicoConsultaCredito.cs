﻿using System.Collections.Generic;

namespace ConsultaCredito
{
    public interface IServicoConsultaCredito
    {
        IList<Pendencia> ConsultarPendenciasPorCPF(string cpf);
    }
}
