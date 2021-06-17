﻿using FactoryMethod.Vehicles;

namespace FactoryMethod.Factories
{
    class MotoTransporte : Transporte
    {
        protected override IVeiculo CriarTransporte()
        {
            return new Moto();
        }
    }
}
